using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void btnSomar_Click(object sender, EventArgs e)
        {
            double val1 = System.Convert.ToDouble(txbValor1.Text);
            double val2 = System.Convert.ToDouble(txbValor2.Text);
            double val3 = val1 + val2;
            lblResultado.Text = "o resultado é: " + val3;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double val1 = System.Convert.ToDouble(txbValor1.Text);
            double val2 = System.Convert.ToDouble(txbValor2.Text);
            double val3 = val1 - val2;
            lblResultado.Text = "o resultado é: " + val3;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double val1 = System.Convert.ToDouble(txbValor1.Text);
            double val2 = System.Convert.ToDouble(txbValor2.Text);
            double val3 = val1 * val2;
            lblResultado.Text = "o resultado é: " + val3;

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double val1 = System.Convert.ToDouble(txbValor1.Text);
            double val2 = System.Convert.ToDouble(txbValor2.Text);
            if (val2 == 0)
            {
                lblResultado.Text = "Impossivel calcular";
            }
            else
            {
                double val3 = val1 * val2;
                lblResultado.Text = "o resultado é: " + val3;
            }


        }
    }
}
