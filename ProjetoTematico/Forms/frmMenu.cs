using System;
using System.Drawing;
using System.Windows.Forms;
using ProjetoTematico.Forms;

namespace NutriFlow.Forms
{
    public partial class frmMenu : Form
    {
        private Form frmAtivo;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro frm = new frmCadastro();

            frm.BtnVoltarr.Visible = false;

            FormShow(frm);

        }

        private void FormShow(Form frm)
        {
            //ActiveForm.Close();
            frmAtivo = frm;
            frm.TopLevel = false;
            frm.AutoScaleMode = AutoScaleMode.Dpi;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Width = 577;
            frm.Height = 454;
            panelForms.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Image yourImage = Image.FromFile("C:\\Users\\Gabriela - PLMPRO\\Downloads\\ProjetoTematico\\ProjetoTematico\\Utils\\edit.ico");
            btnCadastro.Image = new Bitmap(yourImage, new Size(30, 30));
        }
    }
}
