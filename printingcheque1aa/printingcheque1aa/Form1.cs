using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using interface_user;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using other_face;

namespace printingcheque1aa
{
    public partial class Form1 : Form

    {
       

        MySqlConnection conn = new MySqlConnection("server=127.0.0.1; port=3308;uid=root;pwd=ASZQ1234@;database=chequeprint;");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(400, 200);
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            Location = new Point(400, 50);

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            TbCin.UseSystemPasswordChar = !checkBox2.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            TbCin.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TbCin.UseSystemPasswordChar = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 froma = new Form4();
            froma.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string cin = TbCin.Text;
                string nomUtilisateur = textBox2.Text;

                string query = "SELECT COUNT(*) FROM chequeprint WHERE cin = @cin AND nomUtilisateur = @nomUtilisateur;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cin", cin);
                cmd.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("L'identifiant et le nom d'utilisateur existent.");
                    this.Hide();
                    string username = TbCin.Text;
                    string password = textBox2.Text;
                    Form3 froma = new Form3(username,password);
                    froma.ShowDialog();
                }
                else
                {
                    MessageBox.Show("L'identifiant ou le nom d'utilisateur n'existent pas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
            finally
            {
                conn.Close();
               
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Form1 form &&
                   CanRaiseEvents == form.CanRaiseEvents &&
                   EqualityComparer<EventHandlerList>.Default.Equals(Events, form.Events) &&
                   EqualityComparer<ISite>.Default.Equals(Site, form.Site) &&
                   EqualityComparer<IContainer>.Default.Equals(Container, form.Container) &&
                   DesignMode == form.DesignMode &&
                   EqualityComparer<AccessibleObject>.Default.Equals(AccessibilityObject, form.AccessibilityObject) &&
                   AccessibleDefaultActionDescription == form.AccessibleDefaultActionDescription &&
                   AccessibleDescription == form.AccessibleDescription &&
                   AccessibleName == form.AccessibleName &&
                   AccessibleRole == form.AccessibleRole &&
                   AllowDrop == form.AllowDrop &&
                   Anchor == form.Anchor &&
                   AutoSize == form.AutoSize &&
                   EqualityComparer<Point>.Default.Equals(AutoScrollOffset, form.AutoScrollOffset) &&
                   EqualityComparer<LayoutEngine>.Default.Equals(LayoutEngine, form.LayoutEngine) &&
                   EqualityComparer<Color>.Default.Equals(BackColor, form.BackColor) &&
                   EqualityComparer<Image>.Default.Equals(BackgroundImage, form.BackgroundImage) &&
                   BackgroundImageLayout == form.BackgroundImageLayout &&
                   EqualityComparer<BindingContext>.Default.Equals(BindingContext, form.BindingContext) &&
                   Bottom == form.Bottom &&
                   EqualityComparer<Rectangle>.Default.Equals(Bounds, form.Bounds) &&
                   CanFocus == form.CanFocus &&
                   CanRaiseEvents == form.CanRaiseEvents &&
                   CanSelect == form.CanSelect &&
                   Capture == form.Capture &&
                   CausesValidation == form.CausesValidation &&
                   EqualityComparer<Rectangle>.Default.Equals(ClientRectangle, form.ClientRectangle) &&
                   EqualityComparer<Size>.Default.Equals(ClientSize, form.ClientSize) &&
                   CompanyName == form.CompanyName &&
                   ContainsFocus == form.ContainsFocus &&
                   EqualityComparer<ContextMenu>.Default.Equals(ContextMenu, form.ContextMenu) &&
                   EqualityComparer<ContextMenuStrip>.Default.Equals(ContextMenuStrip, form.ContextMenuStrip) &&
                   EqualityComparer<Control.ControlCollection>.Default.Equals(Controls, form.Controls) &&
                   Created == form.Created &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, form.CreateParams) &&
                   EqualityComparer<Cursor>.Default.Equals(Cursor, form.Cursor) &&
                   EqualityComparer<ControlBindingsCollection>.Default.Equals(DataBindings, form.DataBindings) &&
                   EqualityComparer<Cursor>.Default.Equals(DefaultCursor, form.DefaultCursor) &&
                   EqualityComparer<Padding>.Default.Equals(DefaultMargin, form.DefaultMargin) &&
                   EqualityComparer<Size>.Default.Equals(DefaultMaximumSize, form.DefaultMaximumSize) &&
                   EqualityComparer<Size>.Default.Equals(DefaultMinimumSize, form.DefaultMinimumSize) &&
                   EqualityComparer<Padding>.Default.Equals(DefaultPadding, form.DefaultPadding) &&
                   EqualityComparer<Size>.Default.Equals(DefaultSize, form.DefaultSize) &&
                   DeviceDpi == form.DeviceDpi &&
                   EqualityComparer<Rectangle>.Default.Equals(DisplayRectangle, form.DisplayRectangle) &&
                   IsDisposed == form.IsDisposed &&
                   Disposing == form.Disposing &&
                   Dock == form.Dock &&
                   DoubleBuffered == form.DoubleBuffered &&
                   Enabled == form.Enabled &&
                   Focused == form.Focused &&
                   EqualityComparer<Font>.Default.Equals(Font, form.Font) &&
                   FontHeight == form.FontHeight &&
                   EqualityComparer<Color>.Default.Equals(ForeColor, form.ForeColor) &&
                   EqualityComparer<IntPtr>.Default.Equals(Handle, form.Handle) &&
                   HasChildren == form.HasChildren &&
                   Height == form.Height &&
                   IsHandleCreated == form.IsHandleCreated &&
                   InvokeRequired == form.InvokeRequired &&
                   IsAccessible == form.IsAccessible &&
                   IsMirrored == form.IsMirrored &&
                   Left == form.Left &&
                   EqualityComparer<Point>.Default.Equals(Location, form.Location) &&
                   EqualityComparer<Padding>.Default.Equals(Margin, form.Margin) &&
                   EqualityComparer<Size>.Default.Equals(MaximumSize, form.MaximumSize) &&
                   EqualityComparer<Size>.Default.Equals(MinimumSize, form.MinimumSize) &&
                   Name == form.Name &&
                   EqualityComparer<Control>.Default.Equals(Parent, form.Parent) &&
                   ProductName == form.ProductName &&
                   ProductVersion == form.ProductVersion &&
                   RecreatingHandle == form.RecreatingHandle &&
                   EqualityComparer<Region>.Default.Equals(Region, form.Region) &&
                   RenderRightToLeft == form.RenderRightToLeft &&
                   ResizeRedraw == form.ResizeRedraw &&
                   Right == form.Right &&
                   RightToLeft == form.RightToLeft &&
                   ScaleChildren == form.ScaleChildren &&
                   EqualityComparer<ISite>.Default.Equals(Site, form.Site) &&
                   EqualityComparer<Size>.Default.Equals(Size, form.Size) &&
                   TabIndex == form.TabIndex &&
                   TabStop == form.TabStop &&
                   EqualityComparer<object>.Default.Equals(Tag, form.Tag) &&
                   Text == form.Text &&
                   Top == form.Top &&
                   EqualityComparer<Control>.Default.Equals(TopLevelControl, form.TopLevelControl) &&
                   ShowKeyboardCues == form.ShowKeyboardCues &&
                   ShowFocusCues == form.ShowFocusCues &&
                   UseWaitCursor == form.UseWaitCursor &&
                   Visible == form.Visible &&
                   Width == form.Width &&
                   EqualityComparer<IWindowTarget>.Default.Equals(WindowTarget, form.WindowTarget) &&
                   EqualityComparer<Size>.Default.Equals(PreferredSize, form.PreferredSize) &&
                   EqualityComparer<Padding>.Default.Equals(Padding, form.Padding) &&
                   CanEnableIme == form.CanEnableIme &&
                   DefaultImeMode == form.DefaultImeMode &&
                   ImeMode == form.ImeMode &&
                   ImeModeBase == form.ImeModeBase &&
                   AutoScroll == form.AutoScroll &&
                   EqualityComparer<Size>.Default.Equals(AutoScrollMargin, form.AutoScrollMargin) &&
                   EqualityComparer<Point>.Default.Equals(AutoScrollPosition, form.AutoScrollPosition) &&
                   EqualityComparer<Size>.Default.Equals(AutoScrollMinSize, form.AutoScrollMinSize) &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, form.CreateParams) &&
                   EqualityComparer<Rectangle>.Default.Equals(DisplayRectangle, form.DisplayRectangle) &&
                   HScroll == form.HScroll &&
                   EqualityComparer<HScrollProperties>.Default.Equals(HorizontalScroll, form.HorizontalScroll) &&
                   VScroll == form.VScroll &&
                   EqualityComparer<VScrollProperties>.Default.Equals(VerticalScroll, form.VerticalScroll) &&
                   EqualityComparer<DockPaddingEdges>.Default.Equals(DockPadding, form.DockPadding) &&
                   EqualityComparer<SizeF>.Default.Equals(AutoScaleDimensions, form.AutoScaleDimensions) &&
                   EqualityComparer<SizeF>.Default.Equals(AutoScaleFactor, form.AutoScaleFactor) &&
                   AutoScaleMode == form.AutoScaleMode &&
                   AutoValidate == form.AutoValidate &&
                   EqualityComparer<BindingContext>.Default.Equals(BindingContext, form.BindingContext) &&
                   CanEnableIme == form.CanEnableIme &&
                   EqualityComparer<Control>.Default.Equals(ActiveControl, form.ActiveControl) &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, form.CreateParams) &&
                   EqualityComparer<SizeF>.Default.Equals(CurrentAutoScaleDimensions, form.CurrentAutoScaleDimensions) &&
                   EqualityComparer<Form>.Default.Equals(ParentForm, form.ParentForm) &&
                   EqualityComparer<IButtonControl>.Default.Equals(AcceptButton, form.AcceptButton) &&
                   EqualityComparer<Form>.Default.Equals(ActiveMdiChild, form.ActiveMdiChild) &&
                   AllowTransparency == form.AllowTransparency &&
                   AutoScale == form.AutoScale &&
                   EqualityComparer<Size>.Default.Equals(AutoScaleBaseSize, form.AutoScaleBaseSize) &&
                   AutoScroll == form.AutoScroll &&
                   AutoSize == form.AutoSize &&
                   AutoSizeMode == form.AutoSizeMode &&
                   AutoValidate == form.AutoValidate &&
                   EqualityComparer<Color>.Default.Equals(BackColor, form.BackColor) &&
                   FormBorderStyle == form.FormBorderStyle &&
                   EqualityComparer<IButtonControl>.Default.Equals(CancelButton, form.CancelButton) &&
                   EqualityComparer<Size>.Default.Equals(ClientSize, form.ClientSize) &&
                   ControlBox == form.ControlBox &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, form.CreateParams) &&
                   DefaultImeMode == form.DefaultImeMode &&
                   EqualityComparer<Size>.Default.Equals(DefaultSize, form.DefaultSize) &&
                   EqualityComparer<Rectangle>.Default.Equals(DesktopBounds, form.DesktopBounds) &&
                   EqualityComparer<Point>.Default.Equals(DesktopLocation, form.DesktopLocation) &&
                   DialogResult == form.DialogResult &&
                   HelpButton == form.HelpButton &&
                   EqualityComparer<Icon>.Default.Equals(Icon, form.Icon) &&
                   IsMdiChild == form.IsMdiChild &&
                   IsMdiContainer == form.IsMdiContainer &&
                   IsRestrictedWindow == form.IsRestrictedWindow &&
                   KeyPreview == form.KeyPreview &&
                   EqualityComparer<Point>.Default.Equals(Location, form.Location) &&
                   EqualityComparer<Rectangle>.Default.Equals(MaximizedBounds, form.MaximizedBounds) &&
                   EqualityComparer<Size>.Default.Equals(MaximumSize, form.MaximumSize) &&
                   EqualityComparer<MenuStrip>.Default.Equals(MainMenuStrip, form.MainMenuStrip) &&
                   EqualityComparer<Padding>.Default.Equals(Margin, form.Margin) &&
                   EqualityComparer<MainMenu>.Default.Equals(Menu, form.Menu) &&
                   EqualityComparer<Size>.Default.Equals(MinimumSize, form.MinimumSize) &&
                   MaximizeBox == form.MaximizeBox &&
                   EqualityComparer<Form[]>.Default.Equals(MdiChildren, form.MdiChildren) &&
                   EqualityComparer<Form>.Default.Equals(MdiParent, form.MdiParent) &&
                   EqualityComparer<MainMenu>.Default.Equals(MergedMenu, form.MergedMenu) &&
                   MinimizeBox == form.MinimizeBox &&
                   Modal == form.Modal &&
                   Opacity == form.Opacity &&
                   EqualityComparer<Form[]>.Default.Equals(OwnedForms, form.OwnedForms) &&
                   EqualityComparer<Form>.Default.Equals(Owner, form.Owner) &&
                   EqualityComparer<Rectangle>.Default.Equals(RestoreBounds, form.RestoreBounds) &&
                   RightToLeftLayout == form.RightToLeftLayout &&
                   ShowInTaskbar == form.ShowInTaskbar &&
                   ShowIcon == form.ShowIcon &&
                   ShowWithoutActivation == form.ShowWithoutActivation &&
                   EqualityComparer<Size>.Default.Equals(Size, form.Size) &&
                   SizeGripStyle == form.SizeGripStyle &&
                   StartPosition == form.StartPosition &&
                   TabIndex == form.TabIndex &&
                   TabStop == form.TabStop &&
                   Text == form.Text &&
                   TopLevel == form.TopLevel &&
                   TopMost == form.TopMost &&
                   EqualityComparer<Color>.Default.Equals(TransparencyKey, form.TransparencyKey) &&
                   WindowState == form.WindowState &&
                   EqualityComparer<IContainer>.Default.Equals(components, form.components) &&
                   EqualityComparer<BackgroundWorker>.Default.Equals(backgroundWorker1, form.backgroundWorker1) &&
                   EqualityComparer<Button>.Default.Equals(button1, form.button1) &&
                   EqualityComparer<Button>.Default.Equals(button2, form.button2) &&
                   EqualityComparer<CheckBox>.Default.Equals(checkBox1, form.checkBox1) &&
                   EqualityComparer<Button>.Default.Equals(button3, form.button3) &&
                   EqualityComparer<Label>.Default.Equals(label1, form.label1) &&
                   EqualityComparer<Label>.Default.Equals(label4, form.label4) &&
                   EqualityComparer<Label>.Default.Equals(label2, form.label2) &&
                   EqualityComparer<Label>.Default.Equals(label5, form.label5) &&
                   EqualityComparer<TextBox>.Default.Equals(TbCin, form.TbCin) &&
                   EqualityComparer<TextBox>.Default.Equals(textBox2, form.textBox2) &&
                   EqualityComparer<PictureBox>.Default.Equals(pictureBox1, form.pictureBox1) &&
                   EqualityComparer<Label>.Default.Equals(label3, form.label3) &&
                   EqualityComparer<CheckBox>.Default.Equals(checkBox2, form.checkBox2) &&
                   EqualityComparer<Label>.Default.Equals(label6, form.label6) &&
                   EqualityComparer<Label>.Default.Equals(label7, form.label7) &&
                   EqualityComparer<Panel>.Default.Equals(panel2, form.panel2) &&
                   EqualityComparer<Label>.Default.Equals(label8, form.label8) &&
                   EqualityComparer<PictureBox>.Default.Equals(pictureBox2, form.pictureBox2) &&
                   EqualityComparer<Button>.Default.Equals(button4, form.button4) &&
                   EqualityComparer<MySqlConnection>.Default.Equals(conn, form.conn);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
