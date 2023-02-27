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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contador = 1;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
            if (usuario == "carlos" && clave == "123")
            {
                this.Hide();
                FrmPrincipal fr = new FrmPrincipal();
                fr.Show();

            }
            else
            {
                if (contador > 3)
                {
                    MessageBox.Show("Mumero de intentos excedido");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Datos ingresados incorrectos");
                    txtUsuario.Text = "";
                    txtClave.Text = "";
                }
                contador++;


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
