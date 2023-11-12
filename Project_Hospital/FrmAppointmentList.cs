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
    public partial class FrmAppointmentList : Form
    {
        public FrmAppointmentList()
        {
            InitializeComponent();
        }

        sqlconnection connect = new sqlconnection();
        private void FrmAppointmentList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments", connect.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
