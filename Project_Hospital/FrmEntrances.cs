using System;
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
    public partial class FrmEntrances : Form
    {
        public FrmEntrances()
        {
            InitializeComponent();
        }

        private void BtnPatientEntrance_Click(object sender, EventArgs e)
        {
            FrmPatientEnterence fr = new FrmPatientEnterence();
            fr.Show();
            this.Hide();
        }

        private void BtnDoctorEntrance_Click(object sender, EventArgs e)
        {
            FrmDoctorEntrance fr = new FrmDoctorEntrance();
            fr.Show();
            this.Hide();
        }

        private void BtnAssistantEntrance_Click(object sender, EventArgs e)
        {
            FrmAssistant fr = new FrmAssistant();
            fr.Show();
            this.Hide();
        }
    }
}
