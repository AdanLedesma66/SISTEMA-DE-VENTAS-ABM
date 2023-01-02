namespace Tablero
{
    partial class frmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarVentas = new System.Windows.Forms.Button();
            this.btnModificarVentas = new System.Windows.Forms.Button();
            this.btnNuevoVentas = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvClientes4 = new System.Windows.Forms.DataGridView();
            this.txtIDModificar = new System.Windows.Forms.TextBox();
            this.txtIDEliminar = new System.Windows.Forms.TextBox();
            this.txtModificarventas = new System.Windows.Forms.TextBox();
            this.txtNuevoVentas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDNuevo = new System.Windows.Forms.TextBox();
            this.txtDocumentoNuevo = new System.Windows.Forms.TextBox();
            this.txtDocumentoModificar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnEliminarVentas);
            this.panel1.Controls.Add(this.btnModificarVentas);
            this.panel1.Controls.Add(this.btnNuevoVentas);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 1;
            // 
            // btnEliminarVentas
            // 
            this.btnEliminarVentas.Enabled = false;
            this.btnEliminarVentas.FlatAppearance.BorderSize = 0;
            this.btnEliminarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVentas.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEliminarVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarVentas.Image")));
            this.btnEliminarVentas.Location = new System.Drawing.Point(5, 279);
            this.btnEliminarVentas.Name = "btnEliminarVentas";
            this.btnEliminarVentas.Size = new System.Drawing.Size(180, 42);
            this.btnEliminarVentas.TabIndex = 22;
            this.btnEliminarVentas.Text = "Eliminar  ";
            this.btnEliminarVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarVentas.UseVisualStyleBackColor = true;
            this.btnEliminarVentas.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificarVentas
            // 
            this.btnModificarVentas.Enabled = false;
            this.btnModificarVentas.FlatAppearance.BorderSize = 0;
            this.btnModificarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarVentas.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnModificarVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarVentas.Image")));
            this.btnModificarVentas.Location = new System.Drawing.Point(5, 225);
            this.btnModificarVentas.Name = "btnModificarVentas";
            this.btnModificarVentas.Size = new System.Drawing.Size(180, 42);
            this.btnModificarVentas.TabIndex = 21;
            this.btnModificarVentas.Text = "Modificar";
            this.btnModificarVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificarVentas.UseVisualStyleBackColor = true;
            this.btnModificarVentas.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNuevoVentas
            // 
            this.btnNuevoVentas.Enabled = false;
            this.btnNuevoVentas.FlatAppearance.BorderSize = 0;
            this.btnNuevoVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoVentas.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNuevoVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoVentas.Image")));
            this.btnNuevoVentas.Location = new System.Drawing.Point(5, 172);
            this.btnNuevoVentas.Name = "btnNuevoVentas";
            this.btnNuevoVentas.Size = new System.Drawing.Size(180, 42);
            this.btnNuevoVentas.TabIndex = 20;
            this.btnNuevoVentas.Text = "Nuevo      ";
            this.btnNuevoVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevoVentas.UseVisualStyleBackColor = true;
            this.btnNuevoVentas.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel4.Location = new System.Drawing.Point(2, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 150);
            this.panel4.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Volver   ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 162);
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
            this.label1.Location = new System.Drawing.Point(56, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
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
            // dgvClientes4
            // 
            this.dgvClientes4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes4.Location = new System.Drawing.Point(481, 173);
            this.dgvClientes4.Name = "dgvClientes4";
            this.dgvClientes4.RowHeadersWidth = 51;
            this.dgvClientes4.RowTemplate.Height = 24;
            this.dgvClientes4.Size = new System.Drawing.Size(458, 392);
            this.dgvClientes4.TabIndex = 25;
            this.dgvClientes4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes4_CellClick);
            this.dgvClientes4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes4_CellContentClick);
            // 
            // txtIDModificar
            // 
            this.txtIDModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtIDModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDModificar.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtIDModificar.Location = new System.Drawing.Point(194, 238);
            this.txtIDModificar.Multiline = true;
            this.txtIDModificar.Name = "txtIDModificar";
            this.txtIDModificar.Size = new System.Drawing.Size(34, 19);
            this.txtIDModificar.TabIndex = 39;
            this.txtIDModificar.TextChanged += new System.EventHandler(this.txtIDModificar_TextChanged);
            // 
            // txtIDEliminar
            // 
            this.txtIDEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtIDEliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDEliminar.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtIDEliminar.Location = new System.Drawing.Point(194, 292);
            this.txtIDEliminar.Multiline = true;
            this.txtIDEliminar.Name = "txtIDEliminar";
            this.txtIDEliminar.Size = new System.Drawing.Size(34, 18);
            this.txtIDEliminar.TabIndex = 38;
            this.txtIDEliminar.TextChanged += new System.EventHandler(this.txtIDEliminar_TextChanged);
            // 
            // txtModificarventas
            // 
            this.txtModificarventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtModificarventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModificarventas.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtModificarventas.Location = new System.Drawing.Point(231, 238);
            this.txtModificarventas.Multiline = true;
            this.txtModificarventas.Name = "txtModificarventas";
            this.txtModificarventas.Size = new System.Drawing.Size(118, 19);
            this.txtModificarventas.TabIndex = 36;
            this.txtModificarventas.TextChanged += new System.EventHandler(this.txtModificarventas_TextChanged);
            // 
            // txtNuevoVentas
            // 
            this.txtNuevoVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtNuevoVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevoVentas.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtNuevoVentas.Location = new System.Drawing.Point(231, 185);
            this.txtNuevoVentas.Multiline = true;
            this.txtNuevoVentas.Name = "txtNuevoVentas";
            this.txtNuevoVentas.Size = new System.Drawing.Size(118, 19);
            this.txtNuevoVentas.TabIndex = 34;
            this.txtNuevoVentas.TextChanged += new System.EventHandler(this.txtNuevoVentas_TextChanged);
            this.txtNuevoVentas.Leave += new System.EventHandler(this.txtNuevoVentas_Leave);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(350, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 59;
            this.label5.Text = "PRECIO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(231, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 58;
            this.label4.Text = "VENTA";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(194, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 21);
            this.label3.TabIndex = 57;
            this.label3.Text = "ID";
            // 
            // txtIDNuevo
            // 
            this.txtIDNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtIDNuevo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDNuevo.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtIDNuevo.Location = new System.Drawing.Point(194, 185);
            this.txtIDNuevo.Multiline = true;
            this.txtIDNuevo.Name = "txtIDNuevo";
            this.txtIDNuevo.Size = new System.Drawing.Size(34, 19);
            this.txtIDNuevo.TabIndex = 60;
            this.txtIDNuevo.Leave += new System.EventHandler(this.txtIDNuevo_Leave);
            // 
            // txtDocumentoNuevo
            // 
            this.txtDocumentoNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtDocumentoNuevo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumentoNuevo.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtDocumentoNuevo.Location = new System.Drawing.Point(353, 185);
            this.txtDocumentoNuevo.Multiline = true;
            this.txtDocumentoNuevo.Name = "txtDocumentoNuevo";
            this.txtDocumentoNuevo.Size = new System.Drawing.Size(122, 19);
            this.txtDocumentoNuevo.TabIndex = 61;
            this.txtDocumentoNuevo.Leave += new System.EventHandler(this.txtDocumentoNuevo_Leave);
            // 
            // txtDocumentoModificar
            // 
            this.txtDocumentoModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtDocumentoModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumentoModificar.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtDocumentoModificar.Location = new System.Drawing.Point(353, 238);
            this.txtDocumentoModificar.Multiline = true;
            this.txtDocumentoModificar.Name = "txtDocumentoModificar";
            this.txtDocumentoModificar.Size = new System.Drawing.Size(122, 19);
            this.txtDocumentoModificar.TabIndex = 62;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.txtDocumentoModificar);
            this.Controls.Add(this.txtDocumentoNuevo);
            this.Controls.Add(this.txtIDNuevo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDModificar);
            this.Controls.Add(this.txtIDEliminar);
            this.Controls.Add(this.txtModificarventas);
            this.Controls.Add(this.txtNuevoVentas);
            this.Controls.Add(this.dgvClientes4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminarVentas;
        private System.Windows.Forms.Button btnModificarVentas;
        private System.Windows.Forms.Button btnNuevoVentas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvClientes4;
        private System.Windows.Forms.TextBox txtIDModificar;
        private System.Windows.Forms.TextBox txtIDEliminar;
        private System.Windows.Forms.TextBox txtModificarventas;
        private System.Windows.Forms.TextBox txtNuevoVentas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDNuevo;
        private System.Windows.Forms.TextBox txtDocumentoNuevo;
        private System.Windows.Forms.TextBox txtDocumentoModificar;
    }
}