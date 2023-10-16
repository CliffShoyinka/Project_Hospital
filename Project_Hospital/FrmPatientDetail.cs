using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Hospital
{
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
        }

        public string tc;

        sqlconnection bgl = new sqlconnection();

        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;


        }
    }
}
