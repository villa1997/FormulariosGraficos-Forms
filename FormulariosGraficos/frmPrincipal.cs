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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int val1 = 0, val2 = 0, suma=0;
            if (txtValor1.Text != "" && txtValor2.Text != "")
            {
                if (int.TryParse(txtValor1.Text, out val1) && int.TryParse(txtValor2.Text, out val2))
                {
                    suma = val1 + val2;
                    lblRespuesta.Text = Convert.ToString(suma);
                    
                }
                else
                {
                    MessageBox.Show("Solo son permitidos valores numericos");
                }
                
            }
            else
            {
                MessageBox.Show("Debe ingresar valores");
            }
            

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            double val1 = 0, val2 = 0, restar = 0;

            try
            {
                val1 = double.Parse(txtValor1.Text);
                val2 = double.Parse(txtValor2.Text);

                restar = val1 - val2;

                lblRespuesta.Text = restar.ToString();
            }
            catch (FormatException ex)
            {

                MessageBox.Show($"Error {ex.Message}");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            lblRespuesta.Text = ".....";
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            double val1 = 0, val2 = 0, Multiplicar = 0;
            try
            {
                val1 = double.Parse(txtValor1.Text);
                val2 = double.Parse(txtValor2.Text);

                Multiplicar = val1 * val2;

                lblRespuesta.Text = Multiplicar.ToString();
            }
            catch (FormatException ex)
            {

                MessageBox.Show($"Error {ex.Message}");
            }

        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            double val1 = 0, val2 = 0, Dividir = 0;
            try
            {
                val1 = double.Parse(txtValor1.Text);
                val2 = double.Parse(txtValor2.Text);
                try
                {
                    Dividir = val1 / val2;

                    lblRespuesta.Text = Dividir.ToString();
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show($"Error {ex.Message}");
                }
               
            }
            catch (FormatException ex)
            {

                MessageBox.Show($"Error {ex.Message}");
            }

        }
    }
}
