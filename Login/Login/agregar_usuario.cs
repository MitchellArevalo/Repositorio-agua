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
    public partial class agregar_usuario : Form
    {
        public agregar_usuario()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        

        private void CheckContra_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckContra.Checked == true)
            {
                txt_password.UseSystemPasswordChar = false;
            } else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

       


        private void btn_guardar_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_documento.Text == string.Empty || txt_nombre.Text == string.Empty || checkedListBox1.SelectedItems.Count == 0 || txt_email.Text == string.Empty || txt_password.Text == string.Empty || txt_username.Text == string.Empty)
                {
                    MessageBox.Show("Todos los campos deben estar llenos");
                }
                else
                {
                    string Documento_identidad, nombre, correo, contra, user, rol;


                Documento_identidad = txt_documento.Text;
                nombre = txt_nombre.Text;
                correo = txt_email.Text;
                rol = checkedListBox1.SelectedItem.ToString();
                contra = txt_password.Text;
                user = txt_username.Text;

                    MessageBox.Show(rol);


                    ConexionBD conex = new ConexionBD();
                    string sql = "SELECT* FROM Tabla_Usuarios WHERE Correo_Electronico = '" + correo + "' OR Documento = '" + Documento_identidad + "'OR Usuario = '" + user + "'";
                    SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());
                    SqlDataReader leer = comandocorreo.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        correo = leer["Correo_Electronico"].ToString();
                        if (correo == txt_email.Text)
                        {
                            MessageBox.Show("El correo electrónico " + correo + " ya existe en nuestro sistema");
                            this.txt_email.Clear();
                        }

                        Documento_identidad = leer["Documento"].ToString();
                        if (Documento_identidad == txt_documento.Text)
                        {
                            MessageBox.Show("El documento de identidad " + Documento_identidad + " ya existe en nuestro sistema");
                            this.txt_documento.Clear();
                        }

                        user = leer["Usuario"].ToString();
                        if (user == txt_username.Text)
                        {
                            MessageBox.Show("El nombre de usuario " + user + " ya existe en nuestro sistema");
                            this.txt_username.Clear();
                        }
                        conex.desconectar();
                    }
                    else
                    {
                        conex.desconectar();

                        DatosBD misdatos = new DatosBD();
                        misdatos.insertUsuarios(Documento_identidad, nombre, correo, rol, contra, user);

                        this.txt_documento.Clear();
                        this.txt_nombre.Clear();
                        this.txt_email.Clear();
                        this.txt_password.Clear();
                        this.txt_username.Clear();

                        MessageBox.Show("Usuario creado con exito");

                    }
                }
            }
            catch (SqlException ex1)
            {
                Console.WriteLine("Error Generated. Details: " + ex1.ToString());
            }
        }

        private void Expandir_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Expandir_Checkbox.Checked == true)
            {
                checkedListBox1.Size = new Size(332, 129);
            }
            else
            {
                checkedListBox1.Size = new Size(332, 29);
            }
        }

        private void agregar_usuario_Load(object sender, EventArgs e)
        {

        }

        private void list_rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
    }

