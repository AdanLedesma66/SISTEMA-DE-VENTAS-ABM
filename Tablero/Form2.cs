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
using Tablero;

namespace Productos
{
    public partial class FrmProductos : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = CONEXION_CLIENT ; PASSWORD = Adan1234 ; USER ID = SYSTEM;");
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_PRODUCTOABM_LIST", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvClientes2.DataSource = tabla;

            ora.Close();
        }

        private void btnCargar1_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar2_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_PRODUCTOABM_LIST", ora);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvClientes2.DataSource = tabla;

            ora.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtNuevoProducto == null)
            {
                Console.WriteLine("NO HA INTRODUCIDO NINGUN PRODUCTO");
            }
            else
            {

            }
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("INSERTAR_PRODUCTOS", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtIDNumero.Text);
                comando.Parameters.Add("numd", OracleType.Number).Value = Convert.ToInt32(txtNuevoRuc.Text);
                comando.Parameters.Add("inser", OracleType.VarChar).Value = txtNuevoProducto.Text;
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
                OracleCommand comando = new OracleCommand("SP_PRODUCTOABM_LIST", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvClientes2.DataSource = tabla;

            }
            catch
            {

            }
                ora.Close();
            this.txtNuevoProducto.Clear ();
            this.txtNuevoRuc.Clear ();

        }

        private void txtIDProducto_TextChanged(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
        }

        private void dgvClientes2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("MODIFICAR_PRODUCTOS", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtIDModificar.Text);
                comando.Parameters.Add("numd", OracleType.Number).Value = Convert.ToInt32(txtModificarDocumento.Text);
                comando.Parameters.Add("product", OracleType.VarChar).Value = txtModificarProducto1.Text;
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
                OracleCommand comando = new OracleCommand("SP_PRODUCTOABM_LIST", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvClientes2.DataSource = tabla;

            }
            catch
            {

            }
            ora.Close();
            this.txtIDModificar.Clear();
            this.txtModificarProducto1.Clear();
            this.txtModificarDocumento.Clear();

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("ELIMINAR_PRODUCTOS", ora);
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
                OracleCommand comando = new OracleCommand("SP_PRODUCTOABM_LIST", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_CURSOR", OracleType.Cursor).Direction = ParameterDirection.Output;

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvClientes2.DataSource = tabla;

            }
            catch
            {

            }
            ora.Close();
            this.txtIDEliminar.Clear(); 
        }

        private void txtNuevoProducto_TextChanged(object sender, EventArgs e)
        {
           
            btnNuevo.Enabled = true;
            
        }
        
        private void txtIDModificar_Click(object sender, EventArgs e)
        {

        }

        //private void txtModificarProducto(object sender, EventArgs e)
        //{
            
        //}

        private void txtModificarProducto_TextChanged(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
        }

        private void txtIDEliminar_TextChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void dgvClientes2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ora.Open();
            txtIDModificar.Text = Convert.ToString(dgvClientes2.CurrentRow.Cells["ID"].Value);
            txtModificarProducto1.Text = Convert.ToString(dgvClientes2.CurrentRow.Cells["NOMBRE"].Value);
            txtModificarDocumento.Text = Convert.ToString(dgvClientes2.CurrentRow.Cells["DOCUMENTO"].Value);
            ora.Close();
        }
        ErrorProvider errorP = new ErrorProvider();
        private void txtNuevoProducto_Leave(object sender, EventArgs e)
        {
            if (VALIDAD.txtValidarNuevo(txtNuevoProducto))
                errorP.SetError(txtNuevoProducto, "No Puede dejar Vacio");
            else
                errorP.Clear();
        }

        private void txtIDNumero_Leave(object sender, EventArgs e)
        {

            if (VALIDAD.txtValidarNuevo(txtIDNumero))
                errorP.SetError(txtIDNumero, "No Puede dejar Vacio");
            else
                errorP.Clear();
        }

        private void txtNuevoRuc_Leave(object sender, EventArgs e)
        {
            if (VALIDAD.txtValidarNuevo(txtNuevoRuc))
                errorP.SetError(txtNuevoRuc, "No Puede dejar Vacio");
            else
                errorP.Clear();
        }
    }
}
