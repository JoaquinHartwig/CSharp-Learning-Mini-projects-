using LibreriaSeminario;
using LibreriaSeminarioG2_Hartwig_Joaquin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace TRABAJO_SEMINARIO_G2
{
    public partial class B : Form
    {
        public B()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
              
                double n1 = Convert.ToDouble(txtNum1.Text);
                double n2 = Convert.ToDouble(txtNum2.Text);

               
                double resultado = matematica.Multiplicar(n1, n2);

               
                lblResultado.MostrarResultado("El resultado es: " + resultado.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
             
                double n1 = Convert.ToDouble(txtNum1.Text);
                double n2 = Convert.ToDouble(txtNum2.Text);

               
                double resultado = matematica.Dividir(n1, n2);

                
                lblResultado.MostrarResultado("División: " + resultado.ToString());
            }
            catch (DivideByZeroException ex)
            {
               
                MessageBox.Show(ex.Message, "Error matemático", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
               
                MessageBox.Show("Por favor, ingrese números válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
