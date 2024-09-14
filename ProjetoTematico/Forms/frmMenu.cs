using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ProjetoTematico;
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

        private void FormShow(Type formType)
        {
            if (!typeof(Form).IsAssignableFrom(formType))
            {
                throw new ArgumentException("Tipo fornecido não é um Form", nameof(formType));
            }

            Form frm = (Form)Activator.CreateInstance(formType);

            //ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            frm.AutoScaleMode = AutoScaleMode.Dpi;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlForms.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            LoadImage("logo_planejamento.png", btnExercicios);
        }

        private void LoadImage(string image, Button btn)
        {
            string iconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Utils", image);
            Image yourImage = Image.FromFile(iconPath);
            btn.Image = new Bitmap(yourImage, new Size(30, 30));
        }

        private void btnExercicios_Click(object sender, EventArgs e)
        {
            FormShow(typeof(frmExercicio));
        }

        private void pbxMenu_Click(object sender, EventArgs e)
        {
            ShowPanelBotoes(false);
        }

        private void ShowPanelBotoes(bool isPanelVisible)
        {
            pnlBotoes.Visible = isPanelVisible;

            if (!isPanelVisible)
            {
                CreateButtonMenu();
            }
            else
            {
                HideButtonMenu();
            }

            ResizeForm(isPanelVisible);
        }

        private void HideButtonMenu()
        {
            PictureBox btnMenu = this.Controls.OfType<PictureBox>().FirstOrDefault(btn => btn.Name == "btnMenu");

            if (btnMenu != null)
            {
                btnMenu.Visible = false; // Torna o botão invisível
            }
        }

        private void CreateButtonMenu()
        {
            PictureBox newButton = new PictureBox();

            newButton.Name = "btnMenu";
            newButton.Text = "Clique Aqui";
            newButton.Size = new Size(31, 24);
            newButton.Location = new Point(12, 12);
            newButton.Click += new EventHandler(btnMenu_Click);
            newButton.BackColor = SystemColors.Control;
            newButton.Cursor = Cursors.Hand;

            Image yourImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Utils", "logo_menu.png"));
            newButton.Image = new Bitmap(yourImage, new Size(30, 30));
            newButton.SizeMode = PictureBoxSizeMode.Zoom;

            this.Controls.Add(newButton);

            newButton.BringToFront();            
        }

        private void ResizeForm(bool isDefaultSize)
        {
            if (isDefaultSize)
            {
                this.Size = new Size(901, 534);
            }
            else
            {
                this.Size = new Size(704, 495);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ShowPanelBotoes(true);
        }
    }
}
