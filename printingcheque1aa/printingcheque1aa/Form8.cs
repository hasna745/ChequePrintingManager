using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Linq; // N'oubliez pas d'inclure cette directive using pour utiliser LINQ
using System.Windows.Forms;
using Tesseract;

namespace printingcheque1aa
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpeg;*.jpg;*.png;*.bmp";
            openFileDialog.Title = "Select an Image File for OCR";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                string extractedText = string.Empty;

                try
                {
                    string tessDataPath = @"C:\Program Files\Tesseract-OCR\tessdata";

                    using (var engine = new TesseractEngine(tessDataPath, "eng", EngineMode.Default))
                    {
                        using (var img = Pix.LoadFromFile(imagePath))
                        {
                            using (var page = engine.Process(img))
                            {
                                extractedText = page.GetText(); // Stocker le texte extrait dans une variable
                            }
                        }
                    }

                    textBoxExtractedText.Text = extractedText;

                    // Filtrer uniquement les chiffres
                    string onlyDigits = new string(extractedText.Where(char.IsDigit).ToArray());

                    // Obtenir les 20 derniers chiffres
                    string last20Digits = onlyDigits.Length >= 20
                        ? onlyDigits.Substring(onlyDigits.Length - 20)
                        : onlyDigits;

                    // Afficher ou utiliser le résultat comme souhaité
                    MessageBox.Show("Les 20 derniers chiffres sont: " + last20Digits);

                    Form2 form9 = new Form2();
                    form9.Last20Digits = last20Digits; // Passer les 20 derniers chiffres via la propriété
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'OCR: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
