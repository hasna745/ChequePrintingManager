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
using printingcheque1aa;
using interface_user;
using System.Web;


namespace other_face
{ 
    public partial class Form6 : Form
    {
        Form2 Form2;

        public string password;
        public string usern;
        public string passwo;
        public string user;

        public Form6()
        {

            InitializeComponent();



            // Définir la taille du formulaire à 800x600
            this.Size = new Size(800, 600);
            // Ou définir la taille du client (zone utilisable) du formulaire
            this.ClientSize = new Size(800, 600);
            // Démarrer le formulaire en plein écran
            this.WindowState = FormWindowState.Maximized;
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Hide();
            Form2 = new Form2();
            Form2.cin = password;
            Form2.ShowDialog();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label10.Text = usern;
            

            using (MySqlConnection conn = new MySqlConnection("server=127.0.0.1; port=3308;uid=root;pwd=ASZQ1234@;database=chequeprint;"))
                    {
                        try
                        {
                            // Open the connection
                            conn.Open();

                            // Use parameterized queries to prevent SQL injection
                            string query = "SELECT * FROM chequeprint.information_cheque_client WHERE cin = @password;";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@password", password);

                            // Create a DataTable to store the results
                            DataTable dt = new DataTable();

                            // Use a MySqlDataAdapter to fill the DataTable
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            da.Fill(dt);

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dt;

                            // Adjust the columns to fill the available space
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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


        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {



            ///// ici 
          


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(password);
        }
    }
}
