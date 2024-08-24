using System;
using System.Windows.Forms;
using NutriFlow.Forms;
using NutriFlow.Validation;
using ProjetoTematico.Forms;
using ProjetoTematico.MSSQL;

namespace ProjetoTematico
{
    public partial class LoginForm : Form
    {
        private ConnectionLogin Connection = new ConnectionLogin();
        private LoginValidation Validation = new LoginValidation();

        public LoginForm()
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
            CadastroForm Cadastro = new CadastroForm();

            ControlUtils.ShowAndCloseForm(this, typeof(CadastroForm));
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
                            ControlUtils.ShowAndCloseForm(this, typeof(MenuForm));
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
    }
}