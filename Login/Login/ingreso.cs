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

namespace Login
{
    public partial class ingreso : Form
    {
        public ingreso()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=SOPORTE2\SQLEXPRESS;Initial Catalog = AguaNoche; Integrated Security=True");

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form Form1 = new Login();
            Form1.Show();
            this.Hide();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

            string username, password;

            username = Username_Text_Box.Text;
            password = Password_TextBox.Text;


            try
            {
                connection.Open();

                string validar = "SELECT * FROM Tabla_Usuarios WHERE Usuario = '" + username + "' AND Password = '" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(validar, connection);

                DataTable DB = new DataTable();
                sda.Fill(DB);

                if (DB.Rows.Count > 0)
                {

                    Form Menu = new Menu();
                    Menu.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Los datos ingresados son erroneos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Username_Text_Box.Clear();
                    Password_TextBox.Clear();

                    Username_Text_Box.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Inicio de sesion invalido");
            }
            finally
            {
                connection.Close();
            }
        }

        private void ingreso_Load(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Enter(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Password_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string username, password;

                username = Username_Text_Box.Text;
                password = Password_TextBox.Text;


                try
                {
                    connection.Open();

                    string validar = "SELECT * FROM Tabla_Usuarios WHERE Usuario = '" + username + "' AND Password = '" + password + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(validar, connection);

                    DataTable DB = new DataTable();
                    sda.Fill(DB);

                    if (DB.Rows.Count > 0)
                    {

                        Form Menu = new Menu();
                        Menu.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Los datos ingresados son erroneos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Username_Text_Box.Clear();
                        Password_TextBox.Clear();

                        Username_Text_Box.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Inicio de sesion invalido");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form viaje = new Recuperar_Contraseña();
            viaje.Show();

            this.Hide();
        }
    }
    }
