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
    public partial class FrmSignIn : Form
    {
        public FrmSignIn()
        {
            InitializeComponent();
        }

        sqlconnection connect = new sqlconnection();

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_patients (PatientName,PatientSurname,PatientTC,PatientMobile,PatientPassword,PatientGender) values (@p1,@p2,@p3,@p4,@p5,@p6)",connect.connection());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command.Parameters.AddWithValue("@p3", MskTc.Text);
            command.Parameters.AddWithValue("@p4", MskMobile.Text);
            command.Parameters.AddWithValue("@p5", TxtPassword.Text);
            command.Parameters.AddWithValue("@p6", CmbGender.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Sign Up Successful. Your Password: " + TxtPassword.Text,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
