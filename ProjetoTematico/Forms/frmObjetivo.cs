using System;
using System.Drawing;
using System.Windows.Forms;
using NutriFlow;
using ProjetoTematico;

namespace NutriFlow.Forms
{
    public partial class frmObjetivo : Form
    {
        public event EventHandler CancelClicked;

        public frmObjetivo()
        {
            InitializeComponent();
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
            frmMenu.FormShow(typeof(frmInformacao));
        }

        private void PaintCheckBox(CheckBox ckb)
        {
            if (ckb.Checked) {
                ckb.ForeColor = Color.Green;
            }
            else {
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
    }
}
