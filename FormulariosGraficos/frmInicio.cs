using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosGraficos
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void AbrirForm(Form formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            frmPrincipal Form_Principal = new frmPrincipal();
            AbrirForm(Form_Principal);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            frmEmpleado Form_Empleado = new frmEmpleado();
            AbrirForm(Form_Empleado);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcerca Form_Acerca = new frmAcerca();
            AbrirForm(Form_Acerca);
        }
    }
}
