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
    public partial class FrmPortada : Form
    {
        public FrmPortada()
        {
            InitializeComponent();
        }
        public static void Main ()
        {
            PyoyectoExamen.FrmPortada Portada = new PyoyectoExamen.FrmPortada();
            Portada.ShowDialog();
        }

        private void btbCliente_Click(object sender, EventArgs e)
        {
            PyoyectoExamen.FrmCliente cliente = new PyoyectoExamen.FrmCliente();
            cliente.Show();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            PyoyectoExamen.FrmEmpleados empleados = new PyoyectoExamen.FrmEmpleados();
            empleados.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GboNavegador_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
