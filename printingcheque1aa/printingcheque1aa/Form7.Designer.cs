﻿namespace printingcheque1aa
{
    partial class Form7
    {
        // ... (omitted for brevity)




        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBBeneficaire = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbLieu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbRaison = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbPrix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TbNomDem = new System.Windows.Forms.TextBox();
            this.TbNomBank = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TbAdresseSiege = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 100);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(783, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(515, 60);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CHEQUE SYSTEME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(172, 949);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 88);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cheque";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(3, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 88);
            this.button2.TabIndex = 1;
            this.button2.Text = "Effect";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Imprimer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 88);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sortie";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom  de banque :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(904, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom ou dénomination :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1447, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adresse ou siège :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TBBeneficaire);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TbLieu);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.TbRaison);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TbPrix);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TbTime);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(196, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 332);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // TBBeneficaire
            // 
            this.TBBeneficaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBBeneficaire.Location = new System.Drawing.Point(182, 286);
            this.TBBeneficaire.Name = "TBBeneficaire";
            this.TBBeneficaire.Size = new System.Drawing.Size(448, 26);
            this.TBBeneficaire.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(352, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 26);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Beneficiaire :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Date de creation :";
            // 
            // TbLieu
            // 
            this.TbLieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbLieu.Location = new System.Drawing.Point(182, 177);
            this.TbLieu.Name = "TbLieu";
            this.TbLieu.Size = new System.Drawing.Size(448, 26);
            this.TbLieu.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Lieu :";
            // 
            // TbRaison
            // 
            this.TbRaison.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbRaison.Location = new System.Drawing.Point(182, 118);
            this.TbRaison.Name = "TbRaison";
            this.TbRaison.Size = new System.Drawing.Size(448, 26);
            this.TbRaison.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "La cause :";
            // 
            // TbPrix
            // 
            this.TbPrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPrix.Location = new System.Drawing.Point(182, 67);
            this.TbPrix.Name = "TbPrix";
            this.TbPrix.Size = new System.Drawing.Size(448, 26);
            this.TbPrix.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Prix :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TbTime
            // 
            this.TbTime.Location = new System.Drawing.Point(354, 14);
            this.TbTime.Name = "TbTime";
            this.TbTime.Size = new System.Drawing.Size(276, 26);
            this.TbTime.TabIndex = 4;
            this.TbTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Date d\'Echéance :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(660, 329);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(172, 555);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1752, 494);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "printingcheque1aa.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(862, 171);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1080, 331);
            this.reportViewer1.TabIndex = 12;
            // 
            // TbNomDem
            // 
            this.TbNomDem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNomDem.Location = new System.Drawing.Point(1154, 120);
            this.TbNomDem.Name = "TbNomDem";
            this.TbNomDem.Size = new System.Drawing.Size(226, 26);
            this.TbNomDem.TabIndex = 8;
            // 
            // TbNomBank
            // 
            this.TbNomBank.FormattingEnabled = true;
            this.TbNomBank.Location = new System.Drawing.Point(378, 120);
            this.TbNomBank.Name = "TbNomBank";
            this.TbNomBank.Size = new System.Drawing.Size(478, 28);
            this.TbNomBank.TabIndex = 9;
            this.TbNomBank.SelectedIndexChanged += new System.EventHandler(this.TbNomBank_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TbAdresseSiege
            // 
            this.TbAdresseSiege.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbAdresseSiege.Location = new System.Drawing.Point(1632, 133);
            this.TbAdresseSiege.Name = "TbAdresseSiege";
            this.TbAdresseSiege.Size = new System.Drawing.Size(249, 26);
            this.TbAdresseSiege.TabIndex = 13;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1924, 1049);
            this.Controls.Add(this.TbAdresseSiege);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TbNomBank);
            this.Controls.Add(this.TbNomDem);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "ChequePrint";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Windows Form Designer generated code

        // ... (other generated code)

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TbNomDem;
        private System.Windows.Forms.ComboBox TbNomBank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker TbTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbRaison;
        private System.Windows.Forms.TextBox TbPrix;
        private System.Windows.Forms.TextBox TbLieu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBBeneficaire;
        private System.Windows.Forms.TextBox TbAdresseSiege;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
