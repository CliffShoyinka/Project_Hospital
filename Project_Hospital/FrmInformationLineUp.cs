﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hospital
{
    public partial class FrmInformationLineUp : Form
    {
        public FrmInformationLineUp()
        {
            InitializeComponent();
        }

        public string tcno;
        private void FrmInformationLineUp_Load(object sender, EventArgs e)
        {
            MskTc.Text = tcno;
        }
    }
}
