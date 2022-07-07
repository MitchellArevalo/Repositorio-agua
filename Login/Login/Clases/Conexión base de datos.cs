using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Login
{
    class ConexionBD
    {

        //SqlConnection con = new SqlConnection(@"Data Source=SOPORTE2\SQLEXPRESS;Initial Catalog = AguaNoche; Integrated Security=True");

        public SqlConnection conectar()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=SOPORTE2\SQLEXPRESS;Initial Catalog = AguaNoche; Integrated Security=True");
                con.Open();
                return con;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public bool desconectar()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=SOPORTE2\SQLEXPRESS;Initial Catalog = AguaNoche; Integrated Security=True");
                con.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
