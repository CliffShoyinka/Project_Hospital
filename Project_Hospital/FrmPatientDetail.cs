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

            //fetch units
            SqlCommand command2 = new SqlCommand("Select UnitName From Tbl_Units", connect.connection());
            SqlDataReader dr2 = command2.ExecuteReader();
            while(dr2.Read()) 
            {
                CmbUnit.Items.Add(dr2[0]);
            }

            connect.connection().Close();
        }

        private void CmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();
            SqlCommand command3 = new SqlCommand("Select DoctorName,DoctorSurname From Tbl_Doctors Where DoctorUnit=@p1", connect.connection());
            command3.Parameters.AddWithValue("@p1", CmbUnit.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }

            connect.connection().Close();

        }

        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments Where AppointmentUnit='" + CmbUnit.Text + "' + and AppoinmentDoctor='" + CmbDoctor.Text + "' and AppointmentState=0", connect.connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void UpdateInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmInformationLineUp fr = new FrmInformationLineUp();
            fr.tcno = LblTc.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView2.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView2.Rows[selected].Cells[0].Value.ToString();
        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Appointments set AppointmentState=1, PatitentTC=@p1, PatitentReport=@p2 where AppointmentID=@p3", connect.connection());
            command.Parameters.AddWithValue("@p1", LblTc.Text);
            command.Parameters.AddWithValue("@p2", RchComplain.Text);
            command.Parameters.AddWithValue("@p3", TxtID.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Appointment took", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
