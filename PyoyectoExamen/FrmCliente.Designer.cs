
namespace PyoyectoExamen
{
    partial class FrmCliente
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
            this.GpbCliente = new System.Windows.Forms.GroupBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtCodPedido = new System.Windows.Forms.TextBox();
            this.txtNumSegSocial = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApmaterno = new System.Windows.Forms.TextBox();
            this.txtAppaterno = new System.Windows.Forms.TextBox();
            this.lblCodPedido = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblSEgSocial = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblApmaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAppaterno = new System.Windows.Forms.Label();
            this.dgbClientes = new System.Windows.Forms.DataGridView();
            this.ApPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSegSoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GpbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GpbCliente
            // 
            this.GpbCliente.Controls.Add(this.txtCedula);
            this.GpbCliente.Controls.Add(this.lblCedula);
            this.GpbCliente.Controls.Add(this.btnGuardar);
            this.GpbCliente.Controls.Add(this.cmbCategoria);
            this.GpbCliente.Controls.Add(this.cmbSexo);
            this.GpbCliente.Controls.Add(this.txtCodPedido);
            this.GpbCliente.Controls.Add(this.txtNumSegSocial);
            this.GpbCliente.Controls.Add(this.txtNombre);
            this.GpbCliente.Controls.Add(this.txtApmaterno);
            this.GpbCliente.Controls.Add(this.txtAppaterno);
            this.GpbCliente.Controls.Add(this.lblCodPedido);
            this.GpbCliente.Controls.Add(this.lblCategoria);
            this.GpbCliente.Controls.Add(this.lblSEgSocial);
            this.GpbCliente.Controls.Add(this.lblSexo);
            this.GpbCliente.Controls.Add(this.lblApmaterno);
            this.GpbCliente.Controls.Add(this.lblNombre);
            this.GpbCliente.Controls.Add(this.lblAppaterno);
            this.GpbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbCliente.Location = new System.Drawing.Point(23, 26);
            this.GpbCliente.Name = "GpbCliente";
            this.GpbCliente.Size = new System.Drawing.Size(910, 289);
            this.GpbCliente.TabIndex = 0;
            this.GpbCliente.TabStop = false;
            this.GpbCliente.Text = "Cliente";
            this.GpbCliente.Enter += new System.EventHandler(this.GpbCliente_Enter);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(713, 175);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(171, 29);
            this.txtCedula.TabIndex = 16;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(758, 135);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(70, 24);
            this.lblCedula.TabIndex = 15;
            this.lblCedula.Text = "Cedula";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(779, 222);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 50);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Nuevo",
            "Longevo"});
            this.cmbCategoria.Location = new System.Drawing.Point(253, 175);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(185, 32);
            this.cmbCategoria.TabIndex = 13;
            this.cmbCategoria.Text = "Nuevo";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(713, 77);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(171, 32);
            this.cmbSexo.TabIndex = 12;
            this.cmbSexo.Text = "Masculino";
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.Location = new System.Drawing.Point(470, 176);
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.Size = new System.Drawing.Size(206, 29);
            this.txtCodPedido.TabIndex = 11;
            // 
            // txtNumSegSocial
            // 
            this.txtNumSegSocial.Location = new System.Drawing.Point(10, 176);
            this.txtNumSegSocial.Name = "txtNumSegSocial";
            this.txtNumSegSocial.Size = new System.Drawing.Size(206, 29);
            this.txtNumSegSocial.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(470, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 29);
            this.txtNombre.TabIndex = 9;
            // 
            // txtApmaterno
            // 
            this.txtApmaterno.Location = new System.Drawing.Point(232, 80);
            this.txtApmaterno.Name = "txtApmaterno";
            this.txtApmaterno.Size = new System.Drawing.Size(206, 29);
            this.txtApmaterno.TabIndex = 8;
            // 
            // txtAppaterno
            // 
            this.txtAppaterno.Location = new System.Drawing.Point(10, 81);
            this.txtAppaterno.Name = "txtAppaterno";
            this.txtAppaterno.Size = new System.Drawing.Size(206, 29);
            this.txtAppaterno.TabIndex = 7;
            // 
            // lblCodPedido
            // 
            this.lblCodPedido.AutoSize = true;
            this.lblCodPedido.Location = new System.Drawing.Point(494, 135);
            this.lblCodPedido.Name = "lblCodPedido";
            this.lblCodPedido.Size = new System.Drawing.Size(166, 24);
            this.lblCodPedido.TabIndex = 6;
            this.lblCodPedido.Text = "Codigo del pedido";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(302, 135);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(90, 24);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblSEgSocial
            // 
            this.lblSEgSocial.AutoSize = true;
            this.lblSEgSocial.Location = new System.Drawing.Point(3, 135);
            this.lblSEgSocial.Name = "lblSEgSocial";
            this.lblSEgSocial.Size = new System.Drawing.Size(227, 24);
            this.lblSEgSocial.TabIndex = 4;
            this.lblSEgSocial.Text = "Numero del seguro social";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(758, 41);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(54, 24);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo";
            // 
            // lblApmaterno
            // 
            this.lblApmaterno.AutoSize = true;
            this.lblApmaterno.Location = new System.Drawing.Point(250, 41);
            this.lblApmaterno.Name = "lblApmaterno";
            this.lblApmaterno.Size = new System.Drawing.Size(153, 24);
            this.lblApmaterno.TabIndex = 2;
            this.lblApmaterno.Text = "Apellido Materno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(528, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(88, 24);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombres";
            // 
            // lblAppaterno
            // 
            this.lblAppaterno.AutoSize = true;
            this.lblAppaterno.Location = new System.Drawing.Point(12, 41);
            this.lblAppaterno.Name = "lblAppaterno";
            this.lblAppaterno.Size = new System.Drawing.Size(149, 24);
            this.lblAppaterno.TabIndex = 0;
            this.lblAppaterno.Text = "Apellido Paterno";
            // 
            // dgbClientes
            // 
            this.dgbClientes.AllowUserToAddRows = false;
            this.dgbClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApPaterno,
            this.ApMaterno,
            this.Nombres,
            this.Sexo,
            this.NumSegSoc,
            this.Cedula,
            this.Categoria,
            this.CodigoPedido});
            this.dgbClientes.Location = new System.Drawing.Point(33, 321);
            this.dgbClientes.Name = "dgbClientes";
            this.dgbClientes.Size = new System.Drawing.Size(900, 150);
            this.dgbClientes.TabIndex = 1;
            // 
            // ApPaterno
            // 
            this.ApPaterno.HeaderText = "Apellido Paterno";
            this.ApPaterno.Name = "ApPaterno";
            this.ApPaterno.Width = 150;
            // 
            // ApMaterno
            // 
            this.ApMaterno.HeaderText = "Apellido Materno";
            this.ApMaterno.Name = "ApMaterno";
            this.ApMaterno.Width = 150;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.Width = 250;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.Width = 125;
            // 
            // NumSegSoc
            // 
            this.NumSegSoc.HeaderText = "Numero de seguridad social";
            this.NumSegSoc.Name = "NumSegSoc";
            this.NumSegSoc.Width = 250;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.Width = 150;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 150;
            // 
            // CodigoPedido
            // 
            this.CodigoPedido.HeaderText = "Codigo del pedido";
            this.CodigoPedido.Name = "CodigoPedido";
            this.CodigoPedido.Width = 190;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(969, 510);
            this.Controls.Add(this.dgbClientes);
            this.Controls.Add(this.GpbCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.GpbCliente.ResumeLayout(false);
            this.GpbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpbCliente;
        private System.Windows.Forms.Label lblCodPedido;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblSEgSocial;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblApmaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAppaterno;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtCodPedido;
        private System.Windows.Forms.TextBox txtNumSegSocial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApmaterno;
        private System.Windows.Forms.TextBox txtAppaterno;
        private System.Windows.Forms.DataGridView dgbClientes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSegSoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPedido;
    }
}