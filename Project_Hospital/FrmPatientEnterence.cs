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
    public partial class FrmPatientEnterence : Form
    {
        public FrmPatientEnterence()
        {
            InitializeComponent();
        }

        

        private void LnkSignUp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignIn fr = new FrmSignIn();
            fr.Show();
        }
    }
}
