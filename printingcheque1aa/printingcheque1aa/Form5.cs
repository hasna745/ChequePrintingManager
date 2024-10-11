
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using WindowsFormsApp5;
using interface_user;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
using other_face;


namespace printingcheque1aa
{
    public partial class Form5 : Form
    {
        public string cin;

        // Connection
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1; port=3308;uid=root;pwd=ASZQ1234@;database=chequeprint;");

        public Form5()
        {

            InitializeComponent();

            // Définir la taille du formulaire à 800x600
            this.Size = new Size(800, 600);
            // Ou définir la taille du client (zone utilisable) du formulaire
            this.ClientSize = new Size(800, 600);
            // Démarrer le formulaire en plein écran
            this.WindowState = FormWindowState.Maximized;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Empty event handler can be removed if not needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Empty event handler can be removed if not needed
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Empty event handler can be removed if not needed
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Empty event handler can be removed if not needed
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

            try
            {
                // Ouvrir la connexion
                conn.Open();

                // Utiliser des requêtes paramétrées
                string query = "SELECT * FROM chequeprint.information_cheque_client ORDER BY id_client DESC;";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Créer un DataTable pour stocker les résultats
                DataTable dt = new DataTable();

                // Utiliser un MySqlDataAdapter pour remplir le DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                // Lier le DataTable au DataGridView
                dataGridView1.DataSource = dt;

                // Ajuster les colonnes pour qu'elles remplissent tout l'espace disponible
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fermer la connexion
                conn.Close();
            }

            try
            {
                // Open the connection
                conn.Open();

                // Use parameterized queries
                string query = "SELECT * FROM chequeprint.banque_names;";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Execute the query and retrieve the data
                MySqlDataReader reader = cmd.ExecuteReader();

                // Populate the ComboBox with data from the database
                while (reader.Read())
                {
                    TbNomBank.Items.Add(reader.GetString("banque_namescol"));
                }

                // Close the reader
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Empty event handler can be removed if not needed
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Empty event handler can be removed if not needed
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Empty event handler can be removed if not needed
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // Empty event handler can be removed if not needed
        }

        private void button3_Click(object sender, EventArgs e)
        {

            

        }





        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {





            if (string.IsNullOrWhiteSpace(TbLieu.Text) ||
          string.IsNullOrWhiteSpace(TbTime.Text) ||
          string.IsNullOrWhiteSpace(TbRaison.Text) ||
          string.IsNullOrWhiteSpace(TbPrix.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
            else
            {
                try
                {
                    // Conversion du montant en texte
                    int amount = int.Parse(TbPrix.Text);
                    string amountInWords = NumberToWordsConverter.Convert(amount);
                    string valeurAVerifier = "BMCE Bank of Africa";
                    string valeurAVerifier1 = "Banque Centrale Populair";
                    string valeurAVerifier2 = "Attijariwafa Bank";
                    string valeurAVerifier3 = "CIH Bank";
                    string valeurAVerifier4 = "CFG Bank";
                    string valeurAVerifier5 = "Crédit Agricole du Maroc";
                    string valeurAVerifier6 = "Société Générale Maroc";
                    string valeurAVerifier7 = "BMCI";

                    ReportParameterCollection reportParameters = new ReportParameterCollection
                {
                    new ReportParameter("prix","#"+ TbPrix.Text + "#"),
                    new ReportParameter("prix_lettre","#"+ amountInWords +"#"),
                    new ReportParameter("Raison", TbRaison.Text),
                    new ReportParameter("temp", TbTime.Text),
                    new ReportParameter("ville", TbLieu.Text)
                };


                    if (TbNomBank.SelectedItem != null && TbNomBank.SelectedItem.ToString() == valeurAVerifier)
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "printingcheque1aa.BMCE.rdlc";
                    }
                    else if (TbNomBank.SelectedItem != null && TbNomBank.SelectedItem.ToString() == valeurAVerifier1)
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "printingcheque1aa.bank_populaire.rdlc";
                    }
                    else if (TbNomBank.SelectedItem != null && TbNomBank.SelectedItem.ToString() == valeurAVerifier2)
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "printingcheque1aa.Attijari_wafabanque.rdlc";
                    }
                    else if (TbNomBank.SelectedItem != null && TbNomBank.SelectedItem.ToString() == valeurAVerifier3)
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "printingcheque1aa.CIH.rdlc";
                    }
                    else if (TbNomBank.SelectedItem != null && TbNomBank.SelectedItem.ToString() == valeurAVerifier4)
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "printingcheque1aa.CFG.rdlc";
                    }
                    else if (TbNomBank.SelectedItem != null && TbNomBank.SelectedItem.ToString() == valeurAVerifier5)
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "printingcheque1aa.Credit_Agricole.rdlc";
                    }
                    else if (TbNomBank.SelectedItem != null && TbNomBank.SelectedItem.ToString() == valeurAVerifier6)
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "printingcheque1aa.BMCI.rdlc";
                    }
                    else if (TbNomBank.SelectedItem != null && TbNomBank.SelectedItem.ToString() == valeurAVerifier7)
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "printingcheque1aa.BMCI.rdlc";
                    }

                    this.reportViewer1.LocalReport.SetParameters(reportParameters);

                    // Actualisation du rapport
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //--------------------------------------connection--------------------------------------------------------------

                try
                {
                    // Open the connection
                    conn.Open();

                    // Use parameterized queries
                    string query = "INSERT INTO information_cheque_client (ville, raison, temps, nom_banque, numero_de_cheque,prix,cin) " +
                                   "VALUES (@ville, @raison, @temps, @nom_banque, @numero_de_cheque,@prix,@cin)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters
                    cmd.Parameters.AddWithValue("@ville", TbLieu.Text);
                    cmd.Parameters.AddWithValue("@raison", TbRaison.Text);
                    cmd.Parameters.AddWithValue("@temps", TbTime.Text);
                    cmd.Parameters.AddWithValue("@nom_banque", TbNomBank.Text);
                    cmd.Parameters.AddWithValue("@numero_de_cheque", TbNumeroCheque.Text);
                    cmd.Parameters.AddWithValue("@prix", TbPrix.Text);
                    cmd.Parameters.AddWithValue("@cin", cin);

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Données insérées avec succès");

                    // Close the connection
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'insertion : " + ex.Message);
                    conn.Close();
                }
                //----------------------------------------------------------------------------------------------------------

            }

            }



            private void TbNomBank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                TbLieu.Text = row.Cells["ville"].Value.ToString();
                TbRaison.Text = row.Cells["raison"].Value.ToString();
                TbTime.Text = row.Cells["temps"].Value.ToString();
                TbNomBank.Text = row.Cells["nom_banque"].Value.ToString();
                TbNumeroCheque.Text = row.Cells["numero_de_cheque"].Value.ToString();
                TbPrix.Text = row.Cells["prix"].Value.ToString();

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


    }
}

