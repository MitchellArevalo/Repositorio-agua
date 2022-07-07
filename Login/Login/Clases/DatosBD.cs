using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class DatosBD
    {

        public void insertUsuarios(string Documento_identidad, string nombre, string correo, string rol, string contra, string user)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SOPORTE2\SQLEXPRESS;Initial Catalog = AguaNoche; Integrated Security=True");
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO Tabla_Usuarios(Documento, Nombre, Usuario, Rol, Password, Correo_Electronico)VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", Documento_identidad, nombre, user, rol, contra, correo), con);

            comando.ExecuteNonQuery();
           
            con.Close();

        }

        public DataTable listar()
        {
            try
            {
                ConexionBD con1 = new ConexionBD();
                string sql = "SELECT * FROM Tabla_Usuarios";
                Console.WriteLine(sql);
                SqlCommand comando = new SqlCommand(sql, con1.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);

                con1.desconectar();

                return dt;


            }
            catch (Exception)
            {
                return null;
            }
        }

        



    }
}
