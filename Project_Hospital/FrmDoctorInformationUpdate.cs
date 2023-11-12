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
    public partial class FrmDoctorInformationUpdate : Form
    {
        public FrmDoctorInformationUpdate()
        {
            InitializeComponent();
        }

        sqlconnection connect = new sqlconnection();
        public string TCNO;

        private void FrmDoctorInformationUpdate_Load(object sender, EventArgs e)
        {
            MskTc.Text = TCNO;

            SqlCommand command = new SqlCommand("Select * from Tbl_Doctors where DoctorTC=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", MskTc.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read()) 
            {
                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                CmbUnit.Text = dr[3].ToString();
                TxtPassword.Text = dr[5].ToString();
            }
            connect.connection().Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Doctors set DoctorName=@p1, DoctorSurname=@p2, DoctorUnit=@p3, DoctorPassword=@p4 where DoctorTC=@p5", connect.connection());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command.Parameters.AddWithValue("@p3", CmbUnit.Text);
            command.Parameters.AddWithValue("@p4", TxtPassword.Text);
            command.Parameters.AddWithValue("@p5", MskTc.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Record Updated");

        }
    }
}
