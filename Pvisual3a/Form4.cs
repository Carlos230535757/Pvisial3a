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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Boolean actualizar = false;
        private void listBoxContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string contacto = "";

            contacto = listBoxContactos.GetItemText(listBoxContactos.SelectedItem);
            if (actualizar)
            {

            }
            else
            {
                DatosContacto(contacto);

                //messageBox
            }


        }

        private void DatosContacto(string contacto)
        {
            string nombre, ciudad, telefono, correo = "";
            string[] valores = contacto.Split(' ');
            nombre = valores[0];
            ciudad = valores[1];
            telefono = valores[2];
            correo = valores[3];
            txtNombre.Text = nombre;
            txtCiudad.Text = ciudad;
            txtTelefono.Text = telefono;
            txtCorreo.Text = correo;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizar = true;
            int index = listBoxContactos.SelectedIndex;
            string contacto = "";
            contacto = txtNombre.Text;
            contacto += ' ' + txtCiudad.Text;
            contacto += ' ' + txtTelefono.Text;
            contacto += ' ' + txtCorreo.Text;
            listBoxContactos.Items.RemoveAt(index);
            listBoxContactos.Items.Insert(index, contacto);
            actualizar = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            actualizar = true;
            int index = listBoxContactos.SelectedIndex;
            listBoxContactos.Items.RemoveAt(index);
            actualizar = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGrardar_Click(object sender, EventArgs e)
        {
            string contacto = "";
            contacto = txtNombre.Text;
            contacto += ' ' + txtCiudad.Text;
            contacto += ' ' + txtTelefono.Text;
            contacto += ' ' + txtCorreo.Text;
            listBoxContactos.Items.Add(contacto);
            txtNombre.Text = "";
            txtCiudad.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtNombre.Focus();
        }
    }
    }

