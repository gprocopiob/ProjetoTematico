using System;
using NutriFlow.Forms;
using System.Windows.Forms;
using NutriFlow.Validation;
using ProjetoTematico.Forms;
using ProjetoTematico.MSSQL;

namespace ProjetoTematico
{
    public partial class frmLogin : Form
    {
        private ConnectionLogin Connection = new ConnectionLogin();
        private ValidationLogin Validation = new ValidationLogin();

        public frmLogin()
        {
            InitializeComponent();

            //        new ToastContentBuilder()
            //.AddArgument("action", "viewConversation")
            //.AddArgument("conversationId", 9813)
            //.AddText("Andrew sent you a picture")
            //.AddText("Check this out, The Enchantments in Washington!")
            //.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            ControlUtils.ShowAndCloseForm(this, typeof(frmCadastro));
        }

        private void txbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();

                e.SuppressKeyPress = true;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                string email = txbEmail.Text.ToUpper();
                string password = txbSenha.Text;

                if (!Validation.IsLoginFilled(email, password))
                {
                    SetLoginInvalido("Login Inválido");
                }
                else if (!Validation.IsValidEmail(email))
                {
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
                            ControlUtils.ShowAndCloseForm(this, typeof(frmMenu));
                        }
                        else
                        {
                            SetLoginInvalido("Login inválido");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao realizar login.{Environment.NewLine}Detalhes do erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void SetLoginInvalido(string message)
        {
            ControlUtils.ClearControls(txbEmail, txbSenha);

            MessageBox.Show($"{message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ControlUtils.ShowAndCloseForm(this, typeof(frmMenu));
        }
    }
}