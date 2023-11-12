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
    public partial class FrmDoctorEntrance : Form
    {
        public FrmDoctorEntrance()
        {
            InitializeComponent();
        }

        sqlconnection connect = new sqlconnection();
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Doctors where DoctorTC=@p1 and DoctorPassword=@p2", connect.connection());
            command.Parameters.AddWithValue("@p1", TxtTc.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read()) 
            {
                FrmDoctorDetails fr = new FrmDoctorDetails();
                fr.TC = TxtTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password or user name");
            }
            connect.connection().Close();
        }
    }
}
