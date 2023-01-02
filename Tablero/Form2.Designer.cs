namespace Productos
{
    partial class FrmProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvClientes2 = new System.Windows.Forms.DataGridView();
            this.txtIDEliminar = new System.Windows.Forms.TextBox();
            this.txtNuevoProducto = new System.Windows.Forms.TextBox();
            this.txtIDModificar = new System.Windows.Forms.TextBox();
            this.txtModificarProducto1 = new System.Windows.Forms.TextBox();
            this.txtModificarDocumento = new System.Windows.Forms.TextBox();
            this.txtIDNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNuevoRuc = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnConfiguracion);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 577);
            this.panel1.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(7, 270);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(180, 42);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar  ";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(5, 222);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(180, 42);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Enabled = false;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(4, 170);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(180, 42);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo      ";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel4.Location = new System.Drawing.Point(0, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 150);
            this.panel4.TabIndex = 10;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.Image")));
            this.btnConfiguracion.Location = new System.Drawing.Point(3, 532);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(180, 42);
            this.btnConfiguracion.TabIndex = 3;
            this.btnConfiguracion.Text = "Volver";
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 162);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(57, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLT S. A";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(45, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvClientes2
            // 
            this.dgvClientes2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes2.Location = new System.Drawing.Point(480, 174);
            this.dgvClientes2.Name = "dgvClientes2";
            this.dgvClientes2.RowHeadersWidth = 51;
            this.dgvClientes2.RowTemplate.Height = 24;
            this.dgvClientes2.Size = new System.Drawing.Size(459, 340);
            this.dgvClientes2.TabIndex = 25;
            this.dgvClientes2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes2_CellClick);
            this.dgvClientes2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes2_CellContentClick);
            // 
            // txtIDEliminar
            // 
            this.txtIDEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtIDEliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDEliminar.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtIDEliminar.Location = new System.Drawing.Point(196, 283);
            this.txtIDEliminar.Multiline = true;
            this.txtIDEliminar.Name = "txtIDEliminar";
            this.txtIDEliminar.Size = new System.Drawing.Size(34, 19);
            this.txtIDEliminar.TabIndex = 44;
            this.txtIDEliminar.TextChanged += new System.EventHandler(this.txtIDEliminar_TextChanged);
            // 
            // txtNuevoProducto
            // 
            this.txtNuevoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtNuevoProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevoProducto.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtNuevoProducto.Location = new System.Drawing.Point(236, 187);
            this.txtNuevoProducto.Multiline = true;
            this.txtNuevoProducto.Name = "txtNuevoProducto";
            this.txtNuevoProducto.Size = new System.Drawing.Size(116, 19);
            this.txtNuevoProducto.TabIndex = 40;
            this.txtNuevoProducto.TextChanged += new System.EventHandler(this.txtNuevoProducto_TextChanged);
            this.txtNuevoProducto.Leave += new System.EventHandler(this.txtNuevoProducto_Leave);
            // 
            // txtIDModificar
            // 
            this.txtIDModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtIDModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDModificar.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtIDModificar.Location = new System.Drawing.Point(196, 235);
            this.txtIDModificar.Multiline = true;
            this.txtIDModificar.Name = "txtIDModificar";
            this.txtIDModificar.Size = new System.Drawing.Size(34, 19);
            this.txtIDModificar.TabIndex = 45;
            this.txtIDModificar.TextChanged += new System.EventHandler(this.txtIDProducto_TextChanged);
            // 
            // txtModificarProducto1
            // 
            this.txtModificarProducto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtModificarProducto1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModificarProducto1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarProducto1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtModificarProducto1.Location = new System.Drawing.Point(236, 235);
            this.txtModificarProducto1.Multiline = true;
            this.txtModificarProducto1.Name = "txtModificarProducto1";
            this.txtModificarProducto1.Size = new System.Drawing.Size(116, 19);
            this.txtModificarProducto1.TabIndex = 46;
            // 
            // txtModificarDocumento
            // 
            this.txtModificarDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtModificarDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModificarDocumento.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtModificarDocumento.Location = new System.Drawing.Point(358, 235);
            this.txtModificarDocumento.Multiline = true;
            this.txtModificarDocumento.Name = "txtModificarDocumento";
            this.txtModificarDocumento.Size = new System.Drawing.Size(116, 19);
            this.txtModificarDocumento.TabIndex = 48;
            // 
            // txtIDNumero
            // 
            this.txtIDNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtIDNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDNumero.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtIDNumero.Location = new System.Drawing.Point(196, 187);
            this.txtIDNumero.Multiline = true;
            this.txtIDNumero.Name = "txtIDNumero";
            this.txtIDNumero.Size = new System.Drawing.Size(34, 19);
            this.txtIDNumero.TabIndex = 49;
            this.txtIDNumero.Leave += new System.EventHandler(this.txtIDNumero_Leave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(196, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(236, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "PRODUCTO";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(355, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "PRECIO";
            // 
            // txtNuevoRuc
            // 
            this.txtNuevoRuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtNuevoRuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevoRuc.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoRuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtNuevoRuc.Location = new System.Drawing.Point(358, 187);
            this.txtNuevoRuc.Multiline = true;
            this.txtNuevoRuc.Name = "txtNuevoRuc";
            this.txtNuevoRuc.Size = new System.Drawing.Size(116, 19);
            this.txtNuevoRuc.TabIndex = 47;
            this.txtNuevoRuc.Leave += new System.EventHandler(this.txtNuevoRuc_Leave);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDNumero);
            this.Controls.Add(this.txtModificarDocumento);
            this.Controls.Add(this.txtNuevoRuc);
            this.Controls.Add(this.txtModificarProducto1);
            this.Controls.Add(this.txtIDModificar);
            this.Controls.Add(this.txtIDEliminar);
            this.Controls.Add(this.txtNuevoProducto);
            this.Controls.Add(this.dgvClientes2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "o";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvClientes2;
        private System.Windows.Forms.TextBox txtIDEliminar;
        private System.Windows.Forms.TextBox txtModificarProducto;
        private System.Windows.Forms.TextBox txtNuevoProducto;
        private System.Windows.Forms.TextBox txtIDModificar;
        private System.Windows.Forms.TextBox txtModificarProducto1;
        private System.Windows.Forms.TextBox txtModificarDocumento;
        private System.Windows.Forms.TextBox txtIDNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNuevoRuc;
    }
}

