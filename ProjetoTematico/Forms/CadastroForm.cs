using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTematico.Forms
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm frmLogin = new LoginForm();

            frmLogin.ShowDialog();
        }

        private void frmCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txbConfirmacaoSenha_KeyUp(object sender, KeyEventArgs e)
        {
            VerifyPassword();
        }

        private void txbSenha_KeyUp(object sender, KeyEventArgs e)
        {
            VerifyPassword();
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
    }
}
