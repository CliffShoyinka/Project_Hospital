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

        sqlconnection connect = new sqlconnection();
        private void BtnEnter_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("Select* from Tbl_Assistants where AsisstantTC=@p1 and AsisstantPassword=@p2", connect.connection());
            command.Parameters.AddWithValue("@p1", TxtTc.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read()) 
            { 
                FrmAssitantDetail fad = new FrmAssitantDetail();
                fad.TCnumber = TxtTc.Text;
                fad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali TC & Sifre");
            }
            connect.connection().Close();

            
            
        }

        private void AssistantEntrance_Load(object sender, EventArgs e)
        {

        }
    }
}
