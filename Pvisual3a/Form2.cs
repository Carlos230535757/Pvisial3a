using Factura;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Calculadora form3 = new Calculadora();

            // Mostrar el formulario sin bloquear el formulario actual
            form3.Show();


        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            // Mostrar el formulario sin bloquear el formulario actual
            form4.Show();


        }

        private void factureraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            // Mostrar el formulario sin bloquear el formulario actual
            form5.Show();


        }
    }
}
