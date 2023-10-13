using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace Project_Hospital
{
    public partial class FrmPatientEnterence : Form
    {
        public FrmPatientEnterence()
        {
            InitializeComponent();
        }

        sqlconnection connect = new sqlconnection();

        private void LnkSignUp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignIn fr = new FrmSignIn();
            fr.Show();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Tbl_patients Where PatientTC=@p1 and PatientPassword=@p2", connect.connection());
            command.Parameters.AddWithValue("@p1", TxtTc.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read()) 
            {
                FrmPatientDetail fr = new FrmPatientDetail();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong TC & Password");
            }

            connect.connection().Close();
        }
    }
}
