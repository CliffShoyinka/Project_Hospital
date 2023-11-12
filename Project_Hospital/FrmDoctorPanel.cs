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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }

        sqlconnection connect = new sqlconnection();
        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            //adding doctors to list
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoctorName * from Tbl_Doctors as 'Doctors', DoctorUnit", connect.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //adding units to list
            SqlCommand command2 = new SqlCommand("Select UnitName From Tbl_Units", connect.connection());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                CmbUnit.Items.Add(dr2[0]);
            }
            connect.connection().Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Doctors (DoctorName, DoctorSurname,DoctorUnit, DoctorTC, DoctorPassword) values (@d1, @d2, @d3, @d4, @d5)", connect.connection());
            command.Parameters.AddWithValue("@d1", TxtName.Text);
            command.Parameters.AddWithValue("@d2", TxtSurname.Text);
            command.Parameters.AddWithValue("@d3", CmbUnit.Text);
            command.Parameters.AddWithValue("@d4", MskTC);
            command.Parameters.AddWithValue("@d5", TxtPassword);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Doctor Added", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            CmbUnit.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_Doctors where DoctorTC=@p1",connect.connection());
            command.Parameters.AddWithValue("@p1", MskTC.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Record Deleted","Attention!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Doctors set DoctorName=@d1, DoctorSurname=@d2, DoctorUnit=@d3, DoctorTC=@d4, DoctorPassword=@d5", connect.connection());
            command.Parameters.AddWithValue("@d1", TxtName.Text);
            command.Parameters.AddWithValue("@d2", TxtSurname.Text);
            command.Parameters.AddWithValue("@d3", CmbUnit.Text);
            command.Parameters.AddWithValue("@d4", MskTC);
            command.Parameters.AddWithValue("@d5", TxtPassword);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Doctor Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
