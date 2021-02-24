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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void gobEmpleado_Enter(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Clases.Emplado Empleado1 = new Clases.Emplado();
            Empleado1.Appaterno1 = txtappaterno.Text;
            Empleado1.Apmaterno1 = txtapmaterna.Text;
            Empleado1.Nombre1 = txtnombre.Text;
            Empleado1.Sexo1 = cmbsexo.Text;
            Empleado1.NumeroSeguridadSocial1 = txtnumerosocial.Text;
            Empleado1.TipoContrato1 = cmbcontrato.Text;
            Empleado1.calcularSueldo(1250);
            Empleado1.Cedula1 = txtCedula.Text;
            dgvempleados.Rows.Insert(0, Empleado1.Appaterno1, Empleado1.Apmaterno1, Empleado1.Nombre1, Empleado1.Sexo1, Empleado1.NumeroSeguridadSocial1, Empleado1.Cedula1, Empleado1.TipoContrato1, Empleado1.Sueldo1);
        }
    }
}
