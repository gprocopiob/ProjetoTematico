using System;
using System.Drawing;
using NutriFlow.Forms;
using NutriFlow.Objects;
using System.Windows.Forms;
using NutriFlow.Connection;
using NutriFlow.Validation;

namespace ProjetoTematico.Forms
{
    public partial class frmCadastro : Form
    {
        private ConnectionCadastro Connection = new ConnectionCadastro();
        private ValidationCadastro Validation = new ValidationCadastro();
        private string email;

        public frmCadastro(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlUtils.ShowAndCloseForm(this, typeof(frmLogin), email);
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
            ObjectUser user = new ObjectUser(txbNome.Text, txbSobrenome.Text, cmbGenero.Text, txbEmail.Text, txbSenha.Text);

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
            else if (Connection.EmailExistente(user.Email))
            {
                SetLoginInvalido("Email já cadastrado.", true);
            }
            else
            {
                try
                {
                    bool success = Connection.Insert(user);

                    if (success)
                    {
                        MessageBox.Show($"Cadastro realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ControlUtils.ShowAndCloseForm(this, typeof(frmMenu), email);
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

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}

