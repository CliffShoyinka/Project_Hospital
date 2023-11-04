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
    public partial class AssistantEntrance : Form
    {
        public AssistantEntrance()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Assistants where AsisstantTC=@p1 and AsisstantPassword=@p2",connect.connection());
            command.Parameters.AddWithValue();
        }
    }
}
