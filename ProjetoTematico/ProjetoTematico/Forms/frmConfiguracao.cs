using System;
using NutriFlow.Forms;
using System.Windows.Forms;
using ProjetoTematico;
using NutriFlow.Objects;
using NutriFlow.Utils;
using NutriFlow.Connection;

namespace NutriFlow
{
    public partial class frmConfiguracao : Form
    {
        private string email;
        private ValidationConfiguracao Validation = new ValidationConfiguracao();
        private ConnectionConfiguracao Connection = new ConnectionConfiguracao();

        public frmConfiguracao(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {
            ObjectConfiguracao configuracao = Connection.GetUser(email);

            if (!string.IsNullOrEmpty(configuracao.Email))
            {
                txbNome.Text = configuracao.Nome;
                txbSobrenome.Text = configuracao.Sobrenome;
                txbEmail.Text = configuracao.Email;
                txbSenha.Text = configuracao.Senha;
                cmbGenero.SelectedItem = configuracao.Genero;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControlUtils.ShowAndCloseForm(this, typeof(frmMenu), email);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ObjectConfiguracao configuracao = new ObjectConfiguracao(txbNome.Text, txbSobrenome.Text, cmbGenero.Text, txbEmail.Text, txbSenha.Text);

            if (!Validation.IsConfiguracaoCompleta(configuracao))
            {
                MessageBox.Show("Preencha todos os campos para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    bool success = Connection.UpdateDados(configuracao);

                    if (success)
                    {
                        MessageBox.Show($"Cadastro alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar cadastro.{Environment.NewLine}Detalhes do erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void pbx_Click(object sender, EventArgs e)
        {
            txbSenha.UseSystemPasswordChar = false;
            pbxShow.Visible= false;
            pbxHide.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txbSenha.UseSystemPasswordChar = true;
            pbxHide.Visible = false;
            pbxShow.Visible = true;
        }

    }
}
