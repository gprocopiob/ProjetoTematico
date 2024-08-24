using NutriFlow.Connection;
using System;
using System.Drawing;
using System.Windows.Forms;
using ProjetoTematico;
using NutriFlow.Objects;
using System.Linq.Expressions;
using NutriFlow.Validation;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;
using NutriFlow.Forms;

namespace ProjetoTematico.Forms
{
    public partial class CadastroForm : Form
    {
        private CadastroConnection Connection = new CadastroConnection();
        private CadastroValidation Validation = new CadastroValidation();

        public CadastroForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlUtils.ShowAndCloseForm(this, typeof(LoginForm));
        }

        private void frmCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void VerifyPassword()
        {
            string pwd1 = txbSenha.Text;
            string pwd2 = txbConfirmacaoSenha.Text;

            if (pwd1 == pwd2)
            {
                lblStatus.Text = "Senhas coincidentes";
                lblStatus.ForeColor = Color.Green;
                btnCadastrar.Enabled = true;
            }
            else
            {
                lblStatus.Text = "As senhas não coincidem";
                lblStatus.ForeColor = Color.Red;
                btnCadastrar.Enabled = false;
            }
        }

        private void txbSenha_KeyUp_1(object sender, KeyEventArgs e)
        {
            VerifyPassword();
        }

        private void txbConfirmacaoSenha_KeyUp_1(object sender, KeyEventArgs e)
        {
            VerifyPassword();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            UserObject user = GetUser();

            if (Validation.IsUserNull(user))
            {
                SetLoginInvalido("Usuário não atribuído");
            }
            else if (!Validation.IsUserFilled(user))
            {
                SetLoginInvalido("Preencha todos os campos para continuar");
            }
            else if (!Validation.IsEmailValido(user.Email))
            {
                SetLoginInvalido("Email inválido", false);
            }
            else
            {
                try
                {
                    bool success = Connection.Insert(user);

                    if (success)
                    {
                        MessageBox.Show($"Cadastro realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ControlUtils.ShowAndCloseForm(this, typeof(MenuForm));
                    }
                }

                catch (Exception ex)
                {
                    string message = ex.Message.ToUpper();

                    if (message.Contains("VIOLATION OF PRIMARY KEY CONSTRAINT"))
                    {
                        MessageBox.Show($"Email em uso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Erro ao realizar cadastro.{Environment.NewLine}Detalhes do erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private UserObject GetUser()
        {
            try
            {
                int id = Connection.GetLastID();
                string nome = txbNome.Text;
                string sobrenome = txbSobrenome.Text;
                string genero = cmbGenero.Text;
                string email = txbEmail.Text;
                string senha = txbSenha.Text;

                UserObject user = null;

                if (id != 0)
                {
                    user = new UserObject(id, nome, sobrenome, genero, email, senha);
                }
                return user;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter índex de tabela.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }
        public void SetLoginInvalido(string message, bool cleanProps = true)
        {
            if (cleanProps)
            {
                ControlUtils.ClearControls(txbNome, txbSobrenome, cmbGenero, txbEmail, txbSenha, txbConfirmacaoSenha);
            }
            else
            {
                txbEmail.Focus();
            }

            MessageBox.Show($"{message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

