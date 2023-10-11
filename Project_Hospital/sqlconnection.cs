using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hospital
{
    class sqlconnection
    {
        public SqlConnection connection()
        {
            SqlConnection connection = new SqlConnection("Data Source=MEHMETHAN;Initial Catalog=HospitalProject;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
