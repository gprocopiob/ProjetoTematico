using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriFlow.Forms
{
    internal class ValidationObjetivo
    {
        public bool IsObjetivoValido(params CheckBox[] ckbs)
        {
            foreach (var ckb in ckbs)
            {
                if (ckb.Checked)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsMetaValidada(params NumericUpDown[] numerics)
        {
            foreach (var num in numerics)
            {
                if (num.Value == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
