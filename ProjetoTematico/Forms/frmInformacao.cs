﻿using System;
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
    public partial class frmInformacao : Form
    {
        private string email;

        public frmInformacao(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void frmInformacao_Load(object sender, EventArgs e)
        {

        }
    }
}
