using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data.SqlClient;
using interface_user;
using other_face;


namespace printingcheque1aa
{
    public partial class Form4 : Form
    {
        //connection
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1; port=3308;uid=root;pwd=ASZQ1234@;database=chequeprint;");
        private void connectionmb()
        {
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Location = new Point(400, 50);
        }

        private void BtnInscrire_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TbIdentifiant.Text) ||
       string.IsNullOrWhiteSpace(TbNom.Text) ||
       string.IsNullOrWhiteSpace(TbPrenom.Text) ||
       string.IsNullOrWhiteSpace(TbNomUtilisateur.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
            else
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Use parameterized queries
                    string query = "INSERT INTO chequeprint (cin, nom, prenom, nomUtilisateur) VALUES (@cin, @nom, @prenom, @nomUtilisateur)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Set the parameter values
                    cmd.Parameters.AddWithValue("@cin", TbIdentifiant.Text);
                    cmd.Parameters.AddWithValue("@nom", TbNom.Text);
                    cmd.Parameters.AddWithValue("@prenom", TbPrenom.Text);
                    cmd.Parameters.AddWithValue("@nomUtilisateur", TbNomUtilisateur.Text);

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Données insérées avec succès");

                    // Close the connection
                    conn.Close();

                    this.Hide();
                    Form1 froma = new Form1();
                    froma.ShowDialog();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }



            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        



    }
}
