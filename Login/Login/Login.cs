using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        //SqlConnection connection = new SqlConnection(@"soporte2\sqlexpress.AguaNoche.dbo");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ingreso = new ingreso();
            ingreso.Show(); 

            this.Hide();   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        internal class AguaNocheDataSet
        {
            public object Usuarios { get; internal set; }
            public string DataSetName { get; internal set; }
            public SchemaSerializationMode SchemaSerializationMode { get; internal set; }
        }

        internal class AguaNocheDataSetTableAdapters
        {
            internal class TableAdapterManager
            {
                public static object UpdateOrderOption { get; internal set; }
                public bool BackupDataSetBeforeUpdate { get; internal set; }
                public object UpdateOrder { get; internal set; }
                public UsuariosTableAdapter UsuariosTableAdapter { get; internal set; }

                internal void UpdateAll(AguaNocheDataSet aguaNocheDataSet)
                {
                    throw new NotImplementedException();
                }
            }

            internal class UsuariosTableAdapter
            {
                public bool ClearBeforeFill { get; internal set; }

                internal void TodosLosRegistros(object usuarios)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
