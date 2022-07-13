using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            float num1 = 0;
            float num2 = 0;
            float.TryParse(txtN1.Text, out num1);
            float.TryParse(txtN2.Text, out num2);

            float res = num1 + num2;

            txtResultado.Text = res.ToString();
                 
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            float num1 = 0;
            float num2 = 0;
            float.TryParse(txtN1.Text, out num1);
            float.TryParse(txtN2.Text, out num2);

            float res = num1 - num2;

            txtResultado.Text = res.ToString();
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float num1 = 0;
            float num2 = 0;
            float.TryParse(txtN1.Text, out num1);
            float.TryParse(txtN2.Text, out num2);

            float res = num1 / num2;

            txtResultado.Text = res.ToString();
        }

        private void BtnPromedio_Click(object sender, EventArgs e)
        {
            float num1 = 0;
            float num2 = 0;
            float.TryParse(txtN1.Text, out num1);
            float.TryParse(txtN2.Text, out num2);

            float res = (num1 + num2)/2;

            txtResultado.Text = res.ToString();
        }

        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {

            float num1 = 0;
            float num2 = 0;
            float.TryParse(txtN1.Text, out num1);
            float.TryParse(txtN2.Text, out num2);

            float res = num1 * num2;

            txtResultado.Text = res.ToString();

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnMayor_Click(object sender, EventArgs e)
        {
            float num1 = 0;
            float num2 = 0;
            float mayor = 0;

            float.TryParse(txtN1.Text, out num1);
            float.TryParse(txtN2.Text, out num2);

            if (num1 > num2)
                mayor = num1;

            if  (num2 > num1)
                mayor = num2;

           txtResultado.Text = mayor.ToString();



        }

        private void BtnMenor_Click(object sender, EventArgs e)
        {
            float num1 = 0;
            float num2 = 0;
            float mayor = 0;

            float.TryParse(txtN1.Text, out num1);
            float.TryParse(txtN2.Text, out num2);

            if (num1 < num2)
                mayor = num1;

            if (num2 < num1)
                mayor = num2;

            txtResultado.Text = mayor.ToString();

        }

        private void BtnpromLiteral_Click(object sender, EventArgs e)
        {
            float num1 = 0;
            float num2 = 0;
            float promedio = 0;
            string literal;

            
            

           float.TryParse(txtN1.Text, out num1);
           float.TryParse(txtN2.Text, out num2);

            promedio = (num1 + num2) / 2;

            if (promedio <= 100 && promedio >= 90)
            {
                
                literal = "A";
                txtResultado.Text = literal.ToString();
            }


            else if (promedio <= 89 && promedio >= 80)
            {
                literal = "B";
                txtResultado.Text = literal.ToString();
            }


            else if (promedio <= 79 && promedio >= 70)
            {
                literal = "C";
                txtResultado.Text = literal.ToString();
            }
             
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
