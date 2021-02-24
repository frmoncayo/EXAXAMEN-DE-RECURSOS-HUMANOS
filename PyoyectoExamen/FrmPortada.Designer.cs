
namespace PyoyectoExamen
{
    partial class FrmPortada
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblExamen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GboNavegador = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BtnEmpleado = new System.Windows.Forms.Button();
            this.btbCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GboNavegador.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "MONCAYO SINCHIGUANO FLAVIO ROLANDO";
            // 
            // lblExamen
            // 
            this.lblExamen.AutoSize = true;
            this.lblExamen.BackColor = System.Drawing.Color.Transparent;
            this.lblExamen.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamen.Location = new System.Drawing.Point(262, 125);
            this.lblExamen.Name = "lblExamen";
            this.lblExamen.Size = new System.Drawing.Size(363, 30);
            this.lblExamen.TabIndex = 4;
            this.lblExamen.Text = "EXAMEN SEGUNDO PARCIAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "PROGRAMACION VISUAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "NRC: 4101";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PyoyectoExamen.Properties.Resources.COMPUTADORA;
            this.pictureBox2.Location = new System.Drawing.Point(12, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PyoyectoExamen.Properties.Resources.REDES;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GboNavegador
            // 
            this.GboNavegador.BackgroundImage = global::PyoyectoExamen.Properties.Resources.AAAS;
            this.GboNavegador.Controls.Add(this.btnSalir);
            this.GboNavegador.Controls.Add(this.BtnEmpleado);
            this.GboNavegador.Controls.Add(this.btbCliente);
            this.GboNavegador.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboNavegador.Location = new System.Drawing.Point(363, 170);
            this.GboNavegador.Name = "GboNavegador";
            this.GboNavegador.Size = new System.Drawing.Size(309, 224);
            this.GboNavegador.TabIndex = 0;
            this.GboNavegador.TabStop = false;
            this.GboNavegador.Text = "NAVEGADOR";
            this.GboNavegador.Enter += new System.EventHandler(this.GboNavegador_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSalir.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(192, 175);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 43);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BtnEmpleado
            // 
            this.BtnEmpleado.BackColor = System.Drawing.Color.Teal;
            this.BtnEmpleado.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleado.ForeColor = System.Drawing.Color.White;
            this.BtnEmpleado.Location = new System.Drawing.Point(85, 111);
            this.BtnEmpleado.Name = "BtnEmpleado";
            this.BtnEmpleado.Size = new System.Drawing.Size(114, 43);
            this.BtnEmpleado.TabIndex = 1;
            this.BtnEmpleado.Text = "Empleado";
            this.BtnEmpleado.UseVisualStyleBackColor = false;
            this.BtnEmpleado.Click += new System.EventHandler(this.BtnEmpleado_Click);
            // 
            // btbCliente
            // 
            this.btbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btbCliente.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbCliente.ForeColor = System.Drawing.Color.White;
            this.btbCliente.Location = new System.Drawing.Point(85, 24);
            this.btbCliente.Name = "btbCliente";
            this.btbCliente.Size = new System.Drawing.Size(114, 43);
            this.btbCliente.TabIndex = 0;
            this.btbCliente.Text = "Cliente";
            this.btbCliente.UseVisualStyleBackColor = false;
            this.btbCliente.Click += new System.EventHandler(this.btbCliente_Click);
            // 
            // FrmPortada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(732, 406);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblExamen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GboNavegador);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPortada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portada";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GboNavegador.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GboNavegador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button BtnEmpleado;
        private System.Windows.Forms.Button btbCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExamen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}