using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyoyectoExamen
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void GpbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.Cliente clident1 =new Clases.Cliente ();
            clident1.Appaterno1 = txtAppaterno.Text;
            clident1.Apmaterno1 = txtApmaterno.Text;
            clident1.Nombre1 = txtNombre.Text;
            clident1.Sexo1 = cmbSexo.Text;
            clident1.NumeroSeguridadSocial1 = txtNumSegSocial.Text;
            clident1.Categoria1 = cmbCategoria.Text;
            clident1.Nombre1 = txtNombre.Text;
            clident1.CodigoPedido1 = txtCodPedido.Text;
            clident1.GenerarCodigoPedido();
            clident1.Cedulaa1 = txtCedula.Text;
            txtCodPedido.Text = clident1.CodigoPedido1;
            dgbClientes.Rows.Insert(0, clident1.Appaterno1, clident1.Apmaterno1, clident1.Nombre1, clident1.Sexo1, clident1.NumeroSeguridadSocial1, clident1.Cedulaa1, clident1.Categoria1, clident1.CodigoPedido1);
        }

       
    }
}
