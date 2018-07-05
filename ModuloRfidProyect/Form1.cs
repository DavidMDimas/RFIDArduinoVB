using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ModuloRfidProyect
{

    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            serialPort1.Open();
            serialPort1.DataReceived += serialPort1_DataReceived;

        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string POT = serialPort1.ReadLine();
            this.BeginInvoke(new LineReceivedEvent(LineReceived), POT);
        }

        private delegate void LineReceivedEvent(string POT);

        private void LineReceived(string POT)
        {
            //What to do with the received line here
            txtTag.Text = POT.Trim();
            if (txtTag.Text == "71342475367")
            {
                imageAcceso.Visible = true;
                imageDenegado.Visible = false;
            }
            else
            {
                imageDenegado.Visible = true;
                imageAcceso.Visible = false;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "rfidProyecto";
            MySqlConnection conn = new MySqlConnection(builder.ToString());
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT into alumnos (matricula, Nombre) values (@matricula, @nombre)";

            cmd.Parameters.AddWithValue("@matricula", txtTag.Text);
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
