using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using ProjetoTematico;
using ProjetoTematico.Forms;

namespace NutriFlow.Forms
{
    public partial class frmMenu : Form
    {
        private Form frmAtivo;
        public bool isTabSelected = false;

        public frmMenu()
        {
            InitializeComponent();
        }
        private void FormShow(Type formType)
        {
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
        }

        private void LoadImage(string image, Button btn, int width, int height)
        {
            string iconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Utils", image);
            Image yourImage = Image.FromFile(iconPath);
            btn.Image = new Bitmap(yourImage, new Size(width, height));
        }

        private void btnExercicios_Click(object sender, EventArgs e)
        {
            isTabSelected = true;

            FormShow(typeof(frmExercicio));
        }

        private void SetPanelBotoes(bool isPanelVisible)
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
                btnMenu.Visible = false;
            }
        }

        private void CreateButtonMenu()
        {
            PictureBox newButton = new PictureBox();

            newButton.Name = "btnMenu";
            newButton.Text = "Clique Aqui";
            newButton.Size = new Size(26, 16);
            newButton.Location = new Point(12, 24);
            newButton.BackColor = SystemColors.Control;
            newButton.Cursor = Cursors.Hand;

            Image yourImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Utils", "logo_menu.png"));
            newButton.Image = new Bitmap(yourImage, new Size(30, 30));
            newButton.SizeMode = PictureBoxSizeMode.Zoom;

            newButton.Click += new EventHandler(btnMenu_Click);

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
            SetPanelBotoes(true);
        }

        private void pbxMenu_MouseEnter(object sender, EventArgs e)
        {
            ShowToolTip(pbxMenu, "Ocultar menu");
        }
        public void ShowToolTip(Control ctrl, string title)
        {
            ttpHint.IsBalloon = false;
            ttpHint.ToolTipIcon = ToolTipIcon.Info;
            ttpHint.Show(title, ctrl);
        }

        private void pbxMenu_MouseLeave(object sender, EventArgs e)
        {
            HideToolTip(pbxMenu);
        }

        private void HideToolTip(Control ctrl)
        {
            ttpHint.Hide(ctrl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isTabSelected = true;

            FormShow(typeof(frmObjetivo));
        }

        private void btnExercicio_MouseEnter(object sender, EventArgs e)
        {
            ChangeForeColor(true, pnlExercicio, lblExercicio, pbxExercicio);
        }

        private void btnExercicio_MouseLeave(object sender, EventArgs e)
        {
            ChangeForeColor(false, pnlExercicio, lblExercicio, pbxExercicio);
        }
        public void ChangeForeColor(bool isMouseIn, params Control[] controls)
        {
            Color color = isMouseIn ? Color.FromArgb(70, 130, 180) : Color.FromArgb(0, 0, 100);

            foreach (var control in controls)
            {
                if (control is PictureBox)
                {
                    ((PictureBox)control).BackColor = color;
                }
                else if (control is Label)
                {
                    ((Label)control).BackColor = color;
                }
                else if (control is Panel)
                {
                    ((Panel)control).BackColor = color;
                }
            }
        }

        private void pnlRegistro_MouseEnter(object sender, EventArgs e)
        {
            ChangeForeColor(true, pnlRegistro, lblRegistro, pbxRegistro);
        }

        private void pnlRegistro_MouseLeave(object sender, EventArgs e)
        {
            ChangeForeColor(false, pnlRegistro, lblRegistro, pbxRegistro);
        }

        private void pnlRegistro_Click(object sender, EventArgs e)
        {
            isTabSelected = true;

            FormShow(typeof(frmRegistro));
        }

        private void pnlObjetivo_MouseEnter(object sender, EventArgs e)
        {
            ChangeForeColor(true, pnlObjetivo, lblObjetivo, pbxObjetivo);
        }
        private void pnlObjetivo_MouseLeave(object sender, EventArgs e)
        {
            ChangeForeColor(false, pnlObjetivo, lblObjetivo, pbxObjetivo);
        }

        private void pnlConfiguracao_MouseEnter(object sender, EventArgs e)
        {
            ChangeForeColor(true, pnlConfiguracao, lblConfiguracao, pbxConfiguracao);
        }

        private void pnlConfiguracao_MouseLeave(object sender, EventArgs e)
        {
            ChangeForeColor(false, pnlConfiguracao, lblConfiguracao, pbxConfiguracao);
        }

        private void pnlObjetivo_Click(object sender, EventArgs e)
        {
            isTabSelected = true;

            FormShow(typeof(frmObjetivo));
        }

        private void pbxMenu_Click(object sender, EventArgs e)
        {
            if (isTabSelected)
            {
                isTabSelected = true;
                SetPanelBotoes(false);
            }
            else
            {
                MessageBox.Show("Nenhuma aba foi selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pnlConfiguracao_Click(object sender, EventArgs e)
        {
            isTabSelected = true;

            FormShow(typeof(frmConfiguracao));
        }

        private void pnlExercicio_Click(object sender, EventArgs e)
        {
            isTabSelected = true;

            FormShow(typeof(frmExercicio));
        }
    }
}