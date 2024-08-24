using System;
using System.Windows.Forms;
using NutriFlow.Validation;
using ProjetoTematico.Forms;
using ProjetoTematico.MSSQL;

namespace ProjetoTematico
{
    public partial class frmLogin : Form
    {
        private ConnectionLogin Connection = new ConnectionLogin();
        private LoginValidation Validation = new LoginValidation();

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text;
            string password = txbSenha.Text;

            if (!Validation.IsLoginFilled(email, password))
            {
                SetLoginInvalido("Login Inválido");
            }
            else if(!Validation.IsValidEmail(email)){

                SetLoginInvalido("Email Inválido");
            }
            else
            {
                try
                {
                    ConnectionLogin conLogin = new ConnectionLogin();

                    bool loginSuccessful = conLogin.Login(email, password);

                    if (loginSuccessful)
                    {
                        // Chama outro form
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao realizar login.{Environment.NewLine}Detalhes do erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        public void SetLoginInvalido(string message)
        {
            ControlUtils.ClearControls(txbEmail, txbSenha);

            MessageBox.Show($"{message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
