using ProjetoTematico.Forms;
using System;
using System.Windows.Forms;
using ProjetoTematico;

namespace ProjetoTematico
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCadastro frmCadastro = new frmCadastro();

            frmCadastro.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text;
            string senha = txbSenha.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                ControlUtils.ClearControls(txbEmail, txbSenha);

                MessageBox.Show("Login Inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Loga
            }
        }
    }
}
