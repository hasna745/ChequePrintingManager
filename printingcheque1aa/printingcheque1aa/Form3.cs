using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using printingcheque1aa;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using interface_user;
using other_face;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;


namespace interface_user
{
    public partial class Form3 : Form
    {
        Form2 Form2;
        Form6 Form6;
        public string passwo;
        public string user;

        public Form3(string user, string pass)
        {
            InitializeComponent();
            label10.Text = pass;
            label11.Text = user;

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

            Form6 = new Form6();
            Form6.password= label11.Text;
            Form6.usern = label10.Text;
            Form6.ShowDialog();
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

            Form2 = new Form2();
            Form2.cin=label11.Text;
            Form2.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label11.Visible = false;
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
