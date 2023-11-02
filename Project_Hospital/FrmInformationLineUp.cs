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

namespace Project_Hospital
{
    public partial class FrmInformationLineUp : Form
    {
        public FrmInformationLineUp()
        {
            InitializeComponent();
        }

        public string tcno;

        sqlconnection connect = new sqlconnection();
        private void FrmInformationLineUp_Load(object sender, EventArgs e)
        {
            MskTc.Text = tcno;
            SqlCommand command = new SqlCommand("Select * from Tbl_Patients where PatientTC=@p1",connect.connection());
            command.Parameters.AddWithValue("@p1", MskTc.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read()) 
            {
                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                MskMobile.Text = dr[3].ToString();
                TxtPassword.Text = dr[4].ToString();
                CmbGender.Text = dr[5].ToString();
            }

            connect.connection().Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("update Tbl_Patients set PatientName=@p1, PatientNameSurname=@p2, PatientMobile=@p3, PatientPassword=@p4, PatientGender=@p5 where Patient=@p6", connect.connection());
            command2.Parameters.AddWithValue("@p1", TxtName.Text);
            command2.Parameters.AddWithValue("@p2", TxtSurname);
            command2.Parameters.AddWithValue("@p3", MskMobile);
            command2.Parameters.AddWithValue("@p4", TxtPassword);
            command2.Parameters.AddWithValue("@p5", CmbGender);
            command2.Parameters.AddWithValue("@p6", MskTc.Text);
            command2.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Your information is uptaded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
        }
    }
}
