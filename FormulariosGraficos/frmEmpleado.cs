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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool strError = false;

            if (txtNombre.Text == ""|| txtDocumento.Text == ""|| txtApellido.Text == ""|| txtCorreo.Text == "")
            {
                MessageBox.Show("Los campos con * son obligatorios");
                strError = true;
            }
            else
            {
                if (!(int.TryParse(txtDocumento.Text, out int Doc)))
                {
                    MessageBox.Show("Documento de identidad debe ser numerico");
                    strError = true;
                }

                if(cBoxCiudad.Text == "")
                {
                    MessageBox.Show("Debe seleccionar la ciudad");
                }
                
            }
           
            if (!strError)
            {
                string strValores = $"Nombre: {txtNombre.Text} \n";
                strValores += $"Documento: {txtDocumento.Text} \n";
                strValores += $"Correo: {txtCorreo.Text}";
                strValores += $"Ciudad: {cBoxCiudad.Text}";


                if (rdbMasculino.Checked)
                {
                    strValores += $"Sexo: {rdbMasculino.Text}";
                }
                else
                {
                    strValores += $"Sexo: {rdbFemenino.Text}";
                }

                if (chkBailar.Checked)
                {
                    strValores += $"Hobbie: {chkBailar.Text}";
                }
                if (chkCine.Checked)
                {
                    strValores += $"Hobbie: {chkCine.Text}";
                }
                if (chkDormir.Checked)
                {
                    strValores += $"Hobbie: {chkDormir.Text}";
                }
                if (chkEstudiar.Checked)
                {
                    strValores += $"Hobbie: {chkEstudiar.Text}";
                }

                MessageBox.Show($"Datos almacenados\n Nombre: {strValores}");
            }
        }
    }
}
