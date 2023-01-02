namespace Tablero
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnNuevoClientes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvClientes3 = new System.Windows.Forms.DataGridView();
            this.txtIDModificar = new System.Windows.Forms.TextBox();
            this.txtIDEliminar = new System.Windows.Forms.TextBox();
            this.txtModificarCliente = new System.Windows.Forms.TextBox();
            this.txtNuevoCliente = new System.Windows.Forms.TextBox();
            this.txtDocumentoNuevo = new System.Windows.Forms.TextBox();
            this.txtIDNuevo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumentoModificar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnEliminarCliente);
            this.panel1.Controls.Add(this.btnModificarCliente);
            this.panel1.Controls.Add(this.btnNuevoClientes);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 2;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Enabled = false;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCliente.Image")));
            this.btnEliminarCliente.Location = new System.Drawing.Point(3, 278);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(180, 42);
            this.btnEliminarCliente.TabIndex = 22;
            this.btnEliminarCliente.Text = "Eliminar  ";
            this.btnEliminarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Enabled = false;
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnModificarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarCliente.Image")));
            this.btnModificarCliente.Location = new System.Drawing.Point(3, 228);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(180, 42);
            this.btnModificarCliente.TabIndex = 21;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNuevoClientes
            // 
            this.btnNuevoClientes.Enabled = false;
            this.btnNuevoClientes.FlatAppearance.BorderSize = 0;
            this.btnNuevoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoClientes.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNuevoClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoClientes.Image")));
            this.btnNuevoClientes.Location = new System.Drawing.Point(3, 180);
            this.btnNuevoClientes.Name = "btnNuevoClientes";
            this.btnNuevoClientes.Size = new System.Drawing.Size(180, 42);
            this.btnNuevoClientes.TabIndex = 20;
            this.btnNuevoClientes.Text = "Nuevo      ";
            this.btnNuevoClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevoClientes.UseVisualStyleBackColor = true;
            this.btnNuevoClientes.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel4.Location = new System.Drawing.Point(0, 180);
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
            this.label1.Location = new System.Drawing.Point(52, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
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
            // dgvClientes3
            // 
            this.dgvClientes3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes3.Location = new System.Drawing.Point(481, 155);
            this.dgvClientes3.Name = "dgvClientes3";
            this.dgvClientes3.RowHeadersWidth = 51;
            this.dgvClientes3.RowTemplate.Height = 24;
            this.dgvClientes3.Size = new System.Drawing.Size(446, 386);
            this.dgvClientes3.TabIndex = 23;
            this.dgvClientes3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes3_CellClick);
            this.dgvClientes3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes3_CellContentClick);
            // 
            // txtIDModificar
            // 
            this.txtIDModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtIDModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDModificar.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtIDModificar.Location = new System.Drawing.Point(192, 241);
            this.txtIDModificar.Multiline = true;
            this.txtIDModificar.Name = "txtIDModificar";
            this.txtIDModificar.Size = new System.Drawing.Size(34, 21);
            this.txtIDModificar.TabIndex = 39;
            this.txtIDModificar.TextChanged += new System.EventHandler(this.txtIDModificar_TextChanged);
            // 
            // txtIDEliminar
            // 
            this.txtIDEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtIDEliminar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDEliminar.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtIDEliminar.Location = new System.Drawing.Point(192, 291);
            this.txtIDEliminar.Multiline = true;
            this.txtIDEliminar.Name = "txtIDEliminar";
            this.txtIDEliminar.Size = new System.Drawing.Size(34, 21);
            this.txtIDEliminar.TabIndex = 38;
            this.txtIDEliminar.TextChanged += new System.EventHandler(this.txtIDEliminar_TextChanged);
            // 
            // txtModificarCliente
            // 
            this.txtModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtModificarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModificarCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtModificarCliente.Location = new System.Drawing.Point(237, 241);
            this.txtModificarCliente.Multiline = true;
            this.txtModificarCliente.Name = "txtModificarCliente";
            this.txtModificarCliente.Size = new System.Drawing.Size(113, 21);
            this.txtModificarCliente.TabIndex = 36;
            this.txtModificarCliente.TextChanged += new System.EventHandler(this.txtModificarCliente_TextChanged);
            // 
            // txtNuevoCliente
            // 
            this.txtNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtNuevoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevoCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtNuevoCliente.Location = new System.Drawing.Point(237, 193);
            this.txtNuevoCliente.Multiline = true;
            this.txtNuevoCliente.Name = "txtNuevoCliente";
            this.txtNuevoCliente.Size = new System.Drawing.Size(113, 21);
            this.txtNuevoCliente.TabIndex = 34;
            this.txtNuevoCliente.TextChanged += new System.EventHandler(this.txtNuevoCliente_TextChanged);
            this.txtNuevoCliente.Leave += new System.EventHandler(this.txtNuevoCliente_Leave);
            // 
            // txtDocumentoNuevo
            // 
            this.txtDocumentoNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtDocumentoNuevo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumentoNuevo.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtDocumentoNuevo.Location = new System.Drawing.Point(359, 193);
            this.txtDocumentoNuevo.Multiline = true;
            this.txtDocumentoNuevo.Name = "txtDocumentoNuevo";
            this.txtDocumentoNuevo.Size = new System.Drawing.Size(116, 21);
            this.txtDocumentoNuevo.TabIndex = 40;
            this.txtDocumentoNuevo.Leave += new System.EventHandler(this.txtDocumentoNuevo_Leave);
            // 
            // txtIDNuevo
            // 
            this.txtIDNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtIDNuevo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDNuevo.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtIDNuevo.Location = new System.Drawing.Point(192, 193);
            this.txtIDNuevo.Multiline = true;
            this.txtIDNuevo.Name = "txtIDNuevo";
            this.txtIDNuevo.Size = new System.Drawing.Size(34, 21);
            this.txtIDNuevo.TabIndex = 41;
            this.txtIDNuevo.Leave += new System.EventHandler(this.txtIDNuevo_Leave);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(356, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 56;
            this.label5.Text = "DOCUMENTO";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(234, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 55;
            this.label4.Text = "CLIENTE";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(194, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 21);
            this.label3.TabIndex = 54;
            this.label3.Text = "ID";
            // 
            // txtDocumentoModificar
            // 
            this.txtDocumentoModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtDocumentoModificar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumentoModificar.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtDocumentoModificar.Location = new System.Drawing.Point(359, 241);
            this.txtDocumentoModificar.Multiline = true;
            this.txtDocumentoModificar.Name = "txtDocumentoModificar";
            this.txtDocumentoModificar.Size = new System.Drawing.Size(116, 21);
            this.txtDocumentoModificar.TabIndex = 57;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.txtDocumentoModificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDNuevo);
            this.Controls.Add(this.txtDocumentoNuevo);
            this.Controls.Add(this.txtIDModificar);
            this.Controls.Add(this.txtIDEliminar);
            this.Controls.Add(this.txtModificarCliente);
            this.Controls.Add(this.txtNuevoCliente);
            this.Controls.Add(this.dgvClientes3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnNuevoClientes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvClientes3;
        private System.Windows.Forms.TextBox txtIDModificar;
        private System.Windows.Forms.TextBox txtIDEliminar;
        private System.Windows.Forms.TextBox txtModificarCliente;
        private System.Windows.Forms.TextBox txtNuevoCliente;
        private System.Windows.Forms.TextBox txtDocumentoNuevo;
        private System.Windows.Forms.TextBox txtIDNuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumentoModificar;
    }
}