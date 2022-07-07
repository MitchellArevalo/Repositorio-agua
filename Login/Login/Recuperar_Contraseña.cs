using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;
using System.Net.Configuration;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Data.SqlClient;



namespace Login
{
    public partial class Recuperar_Contraseña : Form
    {
        public Recuperar_Contraseña()
        {
            InitializeComponent();
        }
        //SqlConnection connection = new SqlConnection(@"Data Source=SOPORTE2\SQLEXPRESS;Initial Catalog = AguaNoche; Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {

            Form viajar = new ingreso();
            viajar.Show();

            this.Hide();
        }



        public static void SendMail(string correo, string contra, string user)
        { 

            string bodymessage =
               " <center><h1>¡Hola " + user + "!</ h1 >" +
               "<h2> Se ha hecho una solicitud para recuperar tu contraseña</h2>" +
               "<h2> tu contraseña es: " + contra + " </h2>" +
               "<strong><p> Att:</p></strong>" +
               "<img id=LogoAgua src=\"https://franchiasoc.com.ar/ecoblogger/cuidemos-el-agua/cuidemos-el-agua.jpg\" alt=\"Logo\"></center>";
            

            try
            {

                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("mitchella2002@hotmail.es");
                message.To.Add(new MailAddress(correo));
                message.Subject = "Recuperación de contraseña";
                message.IsBodyHtml = true;  
                message.Body = bodymessage;
                smtp.Port = 587;
                smtp.Host = "smtp.office365.com"; 
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("mitchella2002@hotmail.es", "andru3005");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                MessageBox.Show("El correo se ha enviado correctamente a la dirección " + correo);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al enviar el correo electronico" + ex);

                
            }
        }

        private void RecuperarPassword_Click(object sender, EventArgs e)
        {
            try
            {
                string destinatario, correo_recuperado, contra, user;

                correo_recuperado = CorreoRecuperar.Text;
                destinatario = "";
                contra = "";
                user = "";


                ConexionBD conex = new ConexionBD();
                string sql = "SELECT* FROM Tabla_Usuarios WHERE Correo_Electronico = '" + correo_recuperado + "'";
                SqlCommand comandocorreo = new SqlCommand(sql, conex.conectar());
                SqlDataReader leer = comandocorreo.ExecuteReader();
                if (leer.Read() == true)
                {
                    destinatario = leer["Correo_Electronico"].ToString();
                    contra = leer["Password"].ToString();
                    user = leer["Usuario"].ToString();
                }
                else
                {
                    MessageBox.Show("El correo electrónico no se encuentra en el sistema");
                }

                SendMail(destinatario,contra,user);

                conex.desconectar();

            }
            catch (Exception a)
            {
                
                MessageBox.Show(a.Message+a.StackTrace);
            }
        }

        private void CorreoRecuperar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Recuperar_Contraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
