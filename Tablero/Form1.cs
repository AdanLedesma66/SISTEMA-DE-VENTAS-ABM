using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Productos;
using System.Data.OracleClient;

namespace Tablero
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            OracleConnection ora = new OracleConnection("DATA SOURCE = CONEXION_CLIENT ; PASSWORD = Adan1234 ; USER ID = SYSTEM;");
            ora.Open();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
      
            Form Formulario = new FrmProductos();
            Formulario.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Form ventas = new frmVentas();
            ventas.Show();  
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form clientes = new frmClientes();
            clientes.Show();    
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
