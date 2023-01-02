using Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablero
{
    public partial class frmClientes : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = CONEXION_CLIENT ; PASSWORD = Adan1234 ; USER ID = SYSTEM;");
        public frmClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCargar2_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_CLIENTEABM_LIST", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvClientes3.DataSource = tabla;

            ora.Close();



        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_CLIENTEABM_LIST", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvClientes3.DataSource = tabla;

            ora.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("INSERTAR_CLIENTES", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtIDNuevo.Text);
                comando.Parameters.Add("numd", OracleType.Number).Value = Convert.ToInt32(txtDocumentoNuevo.Text);
                comando.Parameters.Add("client", OracleType.VarChar).Value = txtNuevoCliente.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto Insertado");
            }
            catch (Exception)
            {
                MessageBox.Show("No ha Insertado Correctamente");
            }
            ora.Close();

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_CLIENTEABM_LIST", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvClientes3.DataSource = tabla;

            }
            catch (Exception)
            {

            }
                ora.Close();
            this.txtNuevoCliente.Clear();
            this.txtDocumentoNuevo.Clear();
            this.txtIDNuevo.Clear();

            

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("MODIFICAR_CLIENTES", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtIDModificar.Text);
                comando.Parameters.Add("numd", OracleType.Number).Value = Convert.ToInt32(txtDocumentoModificar.Text);
                comando.Parameters.Add("client", OracleType.VarChar).Value = txtModificarCliente.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto Actualizado");
            }
            catch  
            {
                MessageBox.Show("No ha Insertado Correctamente");
            }
            ora.Close();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_CLIENTEABM_LIST", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvClientes3.DataSource = tabla;

            }
            catch (Exception)
            {

            }
            ora.Close();


            this.txtModificarCliente.Clear();
            this.txtIDModificar.Clear();
            this.txtDocumentoModificar.Clear();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_CLIENTES", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtIDEliminar.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto Eliminado");
            }
            catch
            {
                MessageBox.Show("No ha Insertado Correctamente");
            }
            ora.Close();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_CLIENTEABM_LIST", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvClientes3.DataSource = tabla;

            }
            catch (Exception)
            {

            }
            ora.Close();
            this.txtIDEliminar.Clear();

        }

        private void txtIDModificar_TextChanged(object sender, EventArgs e)
        {
            btnModificarCliente.Enabled = true;
        }

        private void dgvClientes3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void txtNuevoCliente_TextChanged(object sender, EventArgs e)
        {
            btnNuevoClientes.Enabled = true;


        }

        private void txtModificarCliente_TextChanged(object sender, EventArgs e)
        {
            btnModificarCliente.Enabled=true;
        }

        private void txtIDEliminar_TextChanged(object sender, EventArgs e)
        {
            btnEliminarCliente.Enabled=true;    
        }

        private void dgvClientes3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ora.Open();
            txtIDModificar.Text = Convert.ToString(dgvClientes3.CurrentRow.Cells["ID"].Value);
            txtModificarCliente.Text = Convert.ToString(dgvClientes3.CurrentRow.Cells["CLIENTE"].Value);
            txtDocumentoModificar.Text = Convert.ToString(dgvClientes3.CurrentRow.Cells["DOCUMENTO"].Value);

            ora.Close();
        }
        ErrorProvider errorP = new ErrorProvider();
        private void txtDocumentoNuevo_Leave(object sender, EventArgs e)
        {
            if (VALIDAD.txtValidarNuevo(txtDocumentoNuevo))
                errorP.SetError(txtDocumentoNuevo, "No Puede dejar Vacio");
            else
                errorP.Clear();
        }

        private void txtNuevoCliente_Leave(object sender, EventArgs e)
        {
            if (VALIDAD.txtValidarNuevo(txtNuevoCliente))
                errorP.SetError(txtNuevoCliente, "No Puede dejar Vacio");
            else
                errorP.Clear();
        }

        private void txtIDNuevo_Leave(object sender, EventArgs e)
        {
            if (VALIDAD.txtValidarNuevo(txtIDNuevo))
                errorP.SetError(txtIDNuevo, "No Puede dejar Vacio");
            else
                errorP.Clear();
        }
    }
}
