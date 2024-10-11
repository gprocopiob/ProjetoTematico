using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriFlow
{
    public partial class frmConfiguracao : Form
    {
        private string email;

        public frmConfiguracao(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {

        }
    }
}
