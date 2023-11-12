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
using System.Data.SqlTypes;

namespace Project_Hospital
{
    public partial class FrmAssitantDetail : Form
    {
        public FrmAssitantDetail()
        {
            InitializeComponent();
        }

        public string TCnumber;
        sqlconnection connect = new sqlconnection();


        private void FrmAssitantDetail_Load(object sender, EventArgs e)
        {
            LblTc.Text = TCnumber;  

            //ad-soyad
            SqlCommand command1 = new SqlCommand("Select AssistantNameSurname From Tbl_Assistants where AsistantTC=@p1", connect.connection());
            command1.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read()) 
            {
                LblNameSurname.Text = dr1[0].ToString();
            }
            connect.connection().Close();

            //addinng units to datagrid
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Units", connect.connection());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //adding doctors to list
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoctorName + ' ' + DoctorSurname) from Tbl_Doctors as 'Doctors', DoctorUnit", connect.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //adding units to list
            SqlCommand command2 = new SqlCommand("Select UnitName From Tbl_Units",connect.connection());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                CmbUnit.Items.Add(dr2[0]);
            }
            connect.connection().Close();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand commandSave = new SqlCommand("insert into Tbl_Appointments (AppointmentDate, AppointmentHour, AppointmentUnit, AppointmentDoctor) values (@r1, @r2, @r3, @r4)",connect.connection());
            commandSave.Parameters.AddWithValue("@r1", MskDate.Text);
            commandSave.Parameters.AddWithValue("@r2", MskTime.Text);
            commandSave.Parameters.AddWithValue("@r3", CmbUnit.Text);
            commandSave.Parameters.AddWithValue("@r4", CmbDoctor.Text);
            commandSave.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Appointment Created!");

        }

        private void CmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();

            SqlCommand command = new SqlCommand("Select DoctorName, DoctorSurname From Tbl_Doctors Where DoctorUnit=@p1",connect.connection());
            command.Parameters.AddWithValue("@p1", CmbUnit.Text);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read()) 
            {
                CmbDoctor.Items.Add(dr[0] + " " + dr[1]);
            }

            connect.connection().Close();
        }

        private void BtnCreateAnnouncement_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Announcements (Announcement) values (@a1)", connect.connection());
            command.Parameters.AddWithValue("@a1", RchAnnouncement.Text);
            command.ExecuteNonQuery();
            connect.connection();
            MessageBox.Show("Announcement Created");
        }

        private void BtnDoctorPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel drp = new FrmDoctorPanel();
            drp.Show();
        }
    }
}
