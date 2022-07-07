using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            llenarGrid();

        }
        private void llenarGrid()
        {
            //DataTable datos = DatosBD.listar();

            DatosBD datos = new DatosBD();


            // MessageBox.Show(datos.listar().ToString());
            if (datos.listar() == null)
            {
                MessageBox.Show("No se logró acceder a los datos");
            }
            else
            {
                dglista.DataSource = datos.listar().DefaultView;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form viajar = new Menu();
            viajar.Show();

            this.Hide();
        }

        private void dglista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form viajar = new agregar_usuario();
            viajar.Show();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            DatosBD datos = new DatosBD();


            // MessageBox.Show(datos.listar().ToString());
            if (datos.listar() == null)
            {
                MessageBox.Show("No se logró acceder a los datos");
            }
            else
            {
                dglista.DataSource = datos.listar().DefaultView;
            }
            this.Refresh();
        }
        
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            

        }

        private void Deletebutton_Click_1(object sender, EventArgs e)
        {

            try
            {
                string nombre;
                nombre = nombre = Convert.ToString(dglista.CurrentRow.Cells["Nombre"].Value); ;

                DialogResult resul = MessageBox.Show("Seguro que quiere eliminar a" + nombre + " del sistema?", "Eliminar Registro", MessageBoxButtons.YesNo);
                if (resul == DialogResult.Yes)
                {
                    ConexionBD bd = new ConexionBD();

                    string ID_eliminar;

                    ID_eliminar = Convert.ToString(dglista.CurrentRow.Cells["IdUsuarios"].Value);

                    string eliminar = "DELETE Tabla_Usuarios WHERE IdUsuarios = " + ID_eliminar;

                    SqlCommand comandoeliminar = new SqlCommand(eliminar, bd.conectar());
                    comandoeliminar.ExecuteNonQuery();
                    bd.desconectar();
                    MessageBox.Show("El usuario se ha eliminado correctamente");
                    DatosBD datos = new DatosBD();


                    // MessageBox.Show(datos.listar().ToString());
                    if (datos.listar() == null)
                    {
                        MessageBox.Show("No se logró acceder a los datos");
                    }
                    else
                    {
                        dglista.DataSource = datos.listar().DefaultView;
                    }
                    this.Refresh();
                }

                
            }
            catch(SqlException wrong)
            {
                MessageBox.Show("Error Generated. Details: " + wrong.ToString());
            }
           

           

           
            
            /*ConexionBD conex = new ConexionBD();
              string sql = "DELETE * FROM Tabla_Usuarios WHERE IdUsuarios = '" + ID_eliminar + "' ";
              SqlCommand comandoid = new SqlCommand(sql, conex.conectar());
              comandoid.ExecuteReader();
             conex.desconectar();*/
        }
    }
}
