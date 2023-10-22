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

        sqlconnection connect = new sqlconnection();

        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;

            //name and surname writing
            SqlCommand command = new SqlCommand("Select PatientName,PatientSurname From Tbl_patients where PatientTC=@p1",connect.connection());
            command.Parameters.AddWithValue("@p1",LblTc.Text);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read()) 
            {
                LblNameSurname.Text = reader[0] + " " + reader[1];
            }

            connect.connection().Close();

            //Appointment history
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From  Tbl_Appointments Where PatientTC=" + tc, connect.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }
    }
}
