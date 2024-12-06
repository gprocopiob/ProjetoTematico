using System;
using System.Drawing;
using ProjetoTematico;
using NutriFlow.Objects;
using System.Windows.Forms;
using NutriFlow.Connection;

namespace NutriFlow.Forms
{
    public partial class frmObjetivo : Form
    {
        public event EventHandler CancelClicked;
        private ValidationObjetivo Validation = new ValidationObjetivo();
        private ConnectionObjetivo Connection = new ConnectionObjetivo();
        private string email;

        public frmObjetivo(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void txbHidratacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlUtils.AllowNumbersAndComa(sender, e);
        }

        private void txbCalorias_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlUtils.AllowNumbersAndComa(sender, e);
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            frmMenu.FormShow(typeof(frmInformacao), email);
        }

        private void PaintCheckBox(CheckBox ckb)
        {
            if (ckb.Checked)
            {
                ckb.ForeColor = Color.Green;
            }
            else
            {
                ckb.ForeColor = Color.Black;
            }
        }

        private void ckbPerda_CheckedChanged(object sender, EventArgs e)
        {
            PaintCheckBox(ckbPerda);

            if (ckbPerda.Checked)
            {
                ChangeEnabledStatus(ckbGanho, false);
            }
            else
            {
                ChangeEnabledStatus(ckbGanho, true);
            }
        }

        private void ChangeEnabledStatus(CheckBox ckb, bool isChecked)
        {
            ckb.Checked = false;
            ckb.Enabled = isChecked;
        }

        private void ckbGanho_CheckedChanged(object sender, EventArgs e)
        {
            PaintCheckBox(ckbGanho);

            if (ckbGanho.Checked)
            {
                ChangeEnabledStatus(ckbPerda, false);
            }
            else
            {
                ChangeEnabledStatus(ckbPerda, true);
            }
        }

        private void ckbSono_CheckedChanged(object sender, EventArgs e)
        {
            PaintCheckBox(ckbSono);
        }

        private void ckbHidratacao_CheckedChanged(object sender, EventArgs e)
        {
            PaintCheckBox(ckbHidratacao);
        }

        private void ckbHabitos_CheckedChanged(object sender, EventArgs e)
        {
            PaintCheckBox(ckbHabitos);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Validation.IsObjetivoValido(ckbPerda, ckbGanho, ckbSono, ckbHidratacao, ckbHabitos))
            {
                MessageBox.Show("Preencha os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Validation.IsMetaValidada(nudPesoAtual, nudPesoDesejado))
            {
                MessageBox.Show("Preencha o objetivo para continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    ObjectObjetivos objetivo = GetObjetivos();

                    bool success = Connection.Insert(objetivo);

                    if (success)
                    {
                        MessageBox.Show($"Cadastro realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("VIOLATION OF PRIMARY KEY CONSTRAINT"))
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
        private ObjectObjetivos GetObjetivos()
        {
            try
            {
                string Email = this.email;
                string Hidratacao = txbHidratacao.Text;
                string Consumo = txbCalorias.Text;
                string Exercicio = nudExercicio.Value.ToString();
                string Peso_Atual = nudPesoAtual.Value.ToString();
                string Peso_Desejado = nudPesoDesejado.Value.ToString();
                string Perda_Peso = ckbPerda.Checked ? "True" : "False";
                string Ganho_Peso = ckbGanho.Checked ? "True" : "False";
                string Melhora_Sono = ckbSono.Checked ? "True" : "False";
                string Melhora_Hidratacao = ckbHidratacao.Checked ? "True" : "False";
                string Melhora_Alimentacao = ckbHabitos.Checked ? "True" : "False";

                ObjectObjetivos metas = null;

                metas = new ObjectObjetivos(Email, Hidratacao, Consumo, Exercicio, Peso_Atual, Peso_Desejado, Perda_Peso, Ganho_Peso, Melhora_Sono, Melhora_Hidratacao, Melhora_Alimentacao);

                return metas;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter índex de tabela.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        private void frmObjetivo_Load(object sender, EventArgs e)
        {
            bool isObjetivoCadastrado = Connection.isObjetivoCadastrado(email);

            if (isObjetivoCadastrado)
            {
                ShowButton(btnAlterar, btnSalvar);

                ObjectObjetivos objetivos = Connection.GetObjetivos(email);

                if (objetivos != null)
                {
                    txbHidratacao.Text = objetivos.Hidratacao;
                    txbCalorias.Text = objetivos.Consumo;
                    nudExercicio.Value = Convert.ToInt32(objetivos.Exercicio);
                    nudPesoAtual.Value = Convert.ToInt32(objetivos.Peso_Atual);
                    nudPesoDesejado.Value = Convert.ToInt32(objetivos.Peso_Desejado);
                    ckbPerda.Checked = objetivos.Perda_Peso == "True";
                    ckbGanho.Checked = objetivos.Ganho_Peso == "True";
                    ckbSono.Checked = objetivos.Melhora_Sono == "True";
                    ckbHidratacao.Checked = objetivos.Hidratacao == "True";
                    ckbHabitos.Checked = objetivos.Melhora_Alimentacao == "True";
                }
            }
            else
            {
                ShowButton(btnSalvar, btnAlterar);
            }
        }
        private void ShowButton(Button btnMostrar, Button btnOcultar)
        {
            btnMostrar.Location = new Point(150, 441);
            btnMostrar.Visible = true;
            btnOcultar.Location = new Point(12, 445);
            btnOcultar.Visible = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ObjectObjetivos objetivos = GetObjetivos();

            try
            {
                bool success = Connection.AlteraObjetivo(objetivos);

                if (success)
                {
                    MessageBox.Show("Objetivos atualizados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Erro ao alterar objetivos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar objetivos.{Environment.NewLine}{Environment.NewLine}Detalhes do Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}