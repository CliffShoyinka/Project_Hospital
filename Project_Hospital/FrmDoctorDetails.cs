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
    public partial class FrmDoctorDetails : Form
    {
        public FrmDoctorDetails()
        {
            InitializeComponent();
        }

        sqlconnection connect = new sqlconnection();
        public string TC;

        private void FrmDoctorDetails_Load(object sender, EventArgs e)
        {
            LblDoctorTc.Text = TC;

            //Doctor Name Surname
            SqlCommand command = new SqlCommand("Select DoctorName, DoctorSurname from Tbl_Doctors where DoctorTC=@p1",connect.connection());
            command.Parameters.AddWithValue("@p1", LblDoctorTc.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read()) 
            { 
                LblNameSurname.Text = dr[0] + " " + dr[1];
            }
            connect.connection().Close();

            //Appointments
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments where AppointmentDoctor=" + LblNameSurname.Text + "'",connect.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmDoctorInformationUpdate frm = new FrmDoctorInformationUpdate();
            frm.TCNO = LblDoctorTc.Text;
            frm.Show();
        }

        private void BtnAnnouncements_Click(object sender, EventArgs e)
        {
            FrmAnnouncements frm = new FrmAnnouncements();
            frm.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            RchComplain.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();


        }
    }
}
