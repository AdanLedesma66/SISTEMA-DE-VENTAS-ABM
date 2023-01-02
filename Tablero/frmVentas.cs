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
    public partial class frmVentas : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = CONEXION_CLIENT ; PASSWORD = Adan1234 ; USER ID = SYSTEM;");
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_VENTAABM_LIST", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvClientes4.DataSource = tabla;
            ora.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar4_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_VENTAABM_LIST", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvClientes4.DataSource = tabla;
            ora.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("INSERTAR_VENTA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtIDNuevo.Text);
                comando.Parameters.Add("numd", OracleType.Number).Value = Convert.ToInt32(txtDocumentoNuevo.Text);
                comando.Parameters.Add("vent", OracleType.VarChar).Value = txtNuevoVentas.Text;
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
                OracleCommand comando = new OracleCommand("SP_VENTAABM_LIST", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvClientes4.DataSource = tabla;

            }
            catch (Exception)
            {

            }
            ora.Close();
            this.txtNuevoVentas.Clear();
            this.txtDocumentoNuevo.Clear();
            this.txtIDNuevo.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("MODIFICAR_VENTA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtIDModificar.Text);
                comando.Parameters.Add("numd", OracleType.Number).Value = Convert.ToInt32(txtDocumentoModificar.Text);
                comando.Parameters.Add("ent", OracleType.VarChar).Value = txtModificarventas.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto Modificado");
            }
            catch
            {
                MessageBox.Show("No ha Insertado Correctamente");
            }
            ora.Close();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_VENTAABM_LIST", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvClientes4.DataSource = tabla;

            }
            catch
            {

            }
            ora.Close();
            this.txtModificarventas.Clear();
            this.txtIDModificar.Clear();
            this.txtDocumentoModificar.Clear();
        }

        private void txtEliminarVentas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_VENTA", ora);
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
                OracleCommand comando = new OracleCommand("SP_VENTAABM_LIST", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvClientes4.DataSource = tabla;

            }
            catch
            {

            }
            ora.Close();
            this.txtIDEliminar.Clear();

        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
           
        }

        private void txtNuevoVentas_TextChanged(object sender, EventArgs e)
        {
            btnNuevoVentas.Enabled = true;

        }

        private void txtIDModificar_TextChanged(object sender, EventArgs e)
        {
            btnModificarVentas.Enabled = true;
        }

        private void txtModificarventas_TextChanged(object sender, EventArgs e)
        {
            btnModificarVentas.Enabled = true;

        }

        private void txtIDEliminar_TextChanged(object sender, EventArgs e)
        {
            btnEliminarVentas.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        ErrorProvider errorP = new ErrorProvider();
        private void dgvClientes4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ora.Open();
            txtDocumentoModificar.Text = Convert.ToString(dgvClientes4.CurrentRow.Cells["DOCUMENTO"].Value);
            txtIDModificar.Text = Convert.ToString(dgvClientes4.CurrentRow.Cells["ID"].Value); 
            txtModificarventas.Text = Convert.ToString(dgvClientes4.CurrentRow.Cells["VENTA"].Value);
            ora.Close();
        }

        private void txtNuevoVentas_Leave(object sender, EventArgs e)
        {

            if (VALIDAD.txtValidarNuevo(txtNuevoVentas))
                errorP.SetError(txtNuevoVentas, "No Puede dejar Vacio");
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

        private void txtDocumentoNuevo_Leave(object sender, EventArgs e)
        {
            if (VALIDAD.txtValidarNuevo(txtDocumentoNuevo))
                errorP.SetError(txtDocumentoNuevo, "No Puede dejar Vacio");
            else
                errorP.Clear();
        }
    }
}
