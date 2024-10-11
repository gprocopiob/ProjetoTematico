using ProjetoTematico;
using System;
using System.Windows.Forms;

namespace NutriFlow.Forms
{
    public partial class frmExercicio : Form
    {
        private string email;

        public frmExercicio(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void frmExercicio_Load(object sender, EventArgs e)
        {

        }
    }
}
