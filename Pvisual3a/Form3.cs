using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvisual3a
{
    public partial class Calculadora : Form
    {
        private double valor1;
        private double valor2;

        private double respuesta;

        private int operacion;
        public Calculadora()
        {
            InitializeComponent();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(txtResultado.Text);

            
            switch (operacion)
            {
                case 1:
                    respuesta = valor1 + valor2;
                    break;
                case 2:
                    respuesta = valor1 - valor2;
                    break;
                case 3:
                    respuesta = valor1 * valor2;
                    break;
                case 4:
                    respuesta = valor1 / valor2;
                    break;
                case 5:
                    respuesta = + Math.Sqrt(valor1);
                    break;



            }

            txtResultado.Text = respuesta.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            operacion = 1;
            valor1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operacion = 2;
            valor1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + ".";

        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            operacion = 5;
            valor1 = double.Parse(txtResultado.Text);
            respuesta = valor1;
            txtResultado.Text = Math.Sqrt(valor1).ToString();
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            
            double valor = double.Parse(txtResultado.Text);

            double resultado = valor / 100;

           
            txtResultado.Text = resultado.ToString();

        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double valor1 = double.Parse(txtResultado.Text);
            double respuesta = Math.Tan(valor1);
            txtResultado.Text = respuesta.ToString();


        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            double valor1 = double.Parse(txtResultado.Text); 
            double respuesta = Math.Sin(valor1); 
            txtResultado.Text = respuesta.ToString(); 
        }

        private void btnCoseno_Click(object sender, EventArgs e)
        {
            double valor1 = double.Parse(txtResultado.Text);
            double respuesta = Math.Cos(valor1);
            txtResultado.Text = respuesta.ToString();

        }
    }
}
