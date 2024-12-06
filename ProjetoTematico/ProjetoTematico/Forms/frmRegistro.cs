using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriFlow.Forms
{
    public partial class frmRegistro : Form
    {
        private string email;

        public frmRegistro(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void txbCalorias_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCalorias_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validação dos campos
            if (string.IsNullOrWhiteSpace(txbAlimento.Text) ||
                string.IsNullOrWhiteSpace(txbQuantidade.Text) ||
                string.IsNullOrWhiteSpace(txbCalorias.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Adicionar calorias ao ListView
            listView1.Items.Add(txbCalorias.Text);

            // Limpar os campos para o próximo registro
            txbAlimento.Clear();
            txbQuantidade.Clear();
            txbCalorias.Clear();

            // Focar no primeiro campo (opcional)
            txbAlimento.Focus();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenu.FormShow(typeof(frmInformacao), email);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
