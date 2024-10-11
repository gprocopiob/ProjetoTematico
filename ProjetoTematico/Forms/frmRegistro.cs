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
    }
}
