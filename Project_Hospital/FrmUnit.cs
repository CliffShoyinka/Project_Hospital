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
    public partial class FrmUnit : Form
    {
        public FrmUnit()
        {
            InitializeComponent();
        }

        sqlconnection connect = new sqlconnection();

        private void FrmUnit_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Units", connect.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Units (UnitName) values (@u1)", connect.connection());
            command.Parameters.AddWithValue("@u1", TxtUnitName.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Unit added","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            TxtUnitId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            TxtUnitName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete From Tbl_Units where Unitid=@u1",connect.connection();
            command.Parameters.AddWithValue("@u1", TxtUnitId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Unit Deleted");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update tbl_Units set UnitName=@p1 where UnitName=@p2",connect.connection());
            command.Parameters.AddWithValue("@p1", TxtUnitName.Text);
            command.Parameters.AddWithValue("@p2", TxtUnitId.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Unit Updated");
        }
    }
}
