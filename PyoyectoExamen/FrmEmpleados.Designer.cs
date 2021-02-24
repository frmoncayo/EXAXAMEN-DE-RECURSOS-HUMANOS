
namespace PyoyectoExamen
{
    partial class FrmEmpleados
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
            this.gobEmpleado = new System.Windows.Forms.GroupBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.cmbcontrato = new System.Windows.Forms.ComboBox();
            this.txtnumerosocial = new System.Windows.Forms.TextBox();
            this.txtapmaterna = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.txtappaterno = new System.Windows.Forms.TextBox();
            this.lbltipocontrato = new System.Windows.Forms.Label();
            this.lblnumseguridadsocial = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapmaterno = new System.Windows.Forms.Label();
            this.lblppaterno = new System.Windows.Forms.Label();
            this.dgvempleados = new System.Windows.Forms.DataGridView();
            this.appaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apmaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipcontrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gobEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // gobEmpleado
            // 
            this.gobEmpleado.Controls.Add(this.lblCedula);
            this.gobEmpleado.Controls.Add(this.txtCedula);
            this.gobEmpleado.Controls.Add(this.btnguardar);
            this.gobEmpleado.Controls.Add(this.cmbcontrato);
            this.gobEmpleado.Controls.Add(this.txtnumerosocial);
            this.gobEmpleado.Controls.Add(this.txtapmaterna);
            this.gobEmpleado.Controls.Add(this.txtnombre);
            this.gobEmpleado.Controls.Add(this.cmbsexo);
            this.gobEmpleado.Controls.Add(this.txtappaterno);
            this.gobEmpleado.Controls.Add(this.lbltipocontrato);
            this.gobEmpleado.Controls.Add(this.lblnumseguridadsocial);
            this.gobEmpleado.Controls.Add(this.lblsexo);
            this.gobEmpleado.Controls.Add(this.lblnombre);
            this.gobEmpleado.Controls.Add(this.lblapmaterno);
            this.gobEmpleado.Controls.Add(this.lblppaterno);
            this.gobEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobEmpleado.Location = new System.Drawing.Point(41, 42);
            this.gobEmpleado.Name = "gobEmpleado";
            this.gobEmpleado.Size = new System.Drawing.Size(759, 190);
            this.gobEmpleado.TabIndex = 0;
            this.gobEmpleado.TabStop = false;
            this.gobEmpleado.Text = "EMPLEADOS";
            this.gobEmpleado.Enter += new System.EventHandler(this.gobEmpleado_Enter);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(457, 78);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(51, 16);
            this.lblCedula.TabIndex = 17;
            this.lblCedula.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(403, 112);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(151, 22);
            this.txtCedula.TabIndex = 16;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(637, 112);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 15;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // cmbcontrato
            // 
            this.cmbcontrato.FormattingEnabled = true;
            this.cmbcontrato.Items.AddRange(new object[] {
            "Nuevo",
            "Longevo"});
            this.cmbcontrato.Location = new System.Drawing.Point(194, 110);
            this.cmbcontrato.Name = "cmbcontrato";
            this.cmbcontrato.Size = new System.Drawing.Size(151, 24);
            this.cmbcontrato.TabIndex = 14;
            this.cmbcontrato.Text = "Nuevo";
            // 
            // txtnumerosocial
            // 
            this.txtnumerosocial.Location = new System.Drawing.Point(17, 111);
            this.txtnumerosocial.Name = "txtnumerosocial";
            this.txtnumerosocial.Size = new System.Drawing.Size(151, 22);
            this.txtnumerosocial.TabIndex = 12;
            // 
            // txtapmaterna
            // 
            this.txtapmaterna.Location = new System.Drawing.Point(194, 45);
            this.txtapmaterna.Name = "txtapmaterna";
            this.txtapmaterna.Size = new System.Drawing.Size(151, 22);
            this.txtapmaterna.TabIndex = 11;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(372, 45);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(221, 22);
            this.txtnombre.TabIndex = 10;
            // 
            // cmbsexo
            // 
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbsexo.Location = new System.Drawing.Point(611, 45);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(121, 24);
            this.cmbsexo.TabIndex = 9;
            this.cmbsexo.Text = "Femenino";
            // 
            // txtappaterno
            // 
            this.txtappaterno.Location = new System.Drawing.Point(17, 45);
            this.txtappaterno.Name = "txtappaterno";
            this.txtappaterno.Size = new System.Drawing.Size(151, 22);
            this.txtappaterno.TabIndex = 8;
            // 
            // lbltipocontrato
            // 
            this.lbltipocontrato.AutoSize = true;
            this.lbltipocontrato.Location = new System.Drawing.Point(224, 78);
            this.lbltipocontrato.Name = "lbltipocontrato";
            this.lbltipocontrato.Size = new System.Drawing.Size(106, 16);
            this.lbltipocontrato.TabIndex = 7;
            this.lbltipocontrato.Text = "Tipo de contrato";
            // 
            // lblnumseguridadsocial
            // 
            this.lblnumseguridadsocial.AutoSize = true;
            this.lblnumseguridadsocial.Location = new System.Drawing.Point(23, 78);
            this.lblnumseguridadsocial.Name = "lblnumseguridadsocial";
            this.lblnumseguridadsocial.Size = new System.Drawing.Size(178, 16);
            this.lblnumseguridadsocial.TabIndex = 5;
            this.lblnumseguridadsocial.Text = "Numero de seguridad social";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(651, 29);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(39, 16);
            this.lblsexo.TabIndex = 4;
            this.lblsexo.Text = "Sexo";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(456, 29);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(64, 16);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombres";
            // 
            // lblapmaterno
            // 
            this.lblapmaterno.AutoSize = true;
            this.lblapmaterno.Location = new System.Drawing.Point(221, 29);
            this.lblapmaterno.Name = "lblapmaterno";
            this.lblapmaterno.Size = new System.Drawing.Size(110, 16);
            this.lblapmaterno.TabIndex = 2;
            this.lblapmaterno.Text = "Apellido Materno";
            // 
            // lblppaterno
            // 
            this.lblppaterno.AutoSize = true;
            this.lblppaterno.Location = new System.Drawing.Point(48, 29);
            this.lblppaterno.Name = "lblppaterno";
            this.lblppaterno.Size = new System.Drawing.Size(108, 16);
            this.lblppaterno.TabIndex = 1;
            this.lblppaterno.Text = "Apellido Paterno";
            // 
            // dgvempleados
            // 
            this.dgvempleados.AllowUserToAddRows = false;
            this.dgvempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appaterno,
            this.apmaterno,
            this.nombre,
            this.sexo,
            this.numeroseg,
            this.Cedula,
            this.tipcontrato,
            this.sueldo});
            this.dgvempleados.Location = new System.Drawing.Point(41, 249);
            this.dgvempleados.Name = "dgvempleados";
            this.dgvempleados.Size = new System.Drawing.Size(759, 150);
            this.dgvempleados.TabIndex = 1;
            // 
            // appaterno
            // 
            this.appaterno.HeaderText = "Apellido Paterno";
            this.appaterno.Name = "appaterno";
            this.appaterno.Width = 200;
            // 
            // apmaterno
            // 
            this.apmaterno.HeaderText = "Apellido Materno";
            this.apmaterno.Name = "apmaterno";
            this.apmaterno.Width = 200;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 200;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            // 
            // numeroseg
            // 
            this.numeroseg.HeaderText = "Numero de seguridad";
            this.numeroseg.Name = "numeroseg";
            this.numeroseg.Width = 150;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.Width = 150;
            // 
            // tipcontrato
            // 
            this.tipcontrato.HeaderText = "Tipo Contrato";
            this.tipcontrato.Name = "tipcontrato";
            // 
            // sueldo
            // 
            this.sueldo.HeaderText = "Sueldo";
            this.sueldo.Name = "sueldo";
            this.sueldo.Width = 190;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.dgvempleados);
            this.Controls.Add(this.gobEmpleado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmpleados";
            this.gobEmpleado.ResumeLayout(false);
            this.gobEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gobEmpleado;
        private System.Windows.Forms.TextBox txtnumerosocial;
        private System.Windows.Forms.TextBox txtapmaterna;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.Windows.Forms.TextBox txtappaterno;
        private System.Windows.Forms.Label lbltipocontrato;
        private System.Windows.Forms.Label lblnumseguridadsocial;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapmaterno;
        private System.Windows.Forms.Label lblppaterno;
        private System.Windows.Forms.ComboBox cmbcontrato;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dgvempleados;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn appaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipcontrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo;
    }
}