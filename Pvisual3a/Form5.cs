using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cod;
            string nom;
            float precio;

            cod = cmbProducto.SelectedIndex;
            nom = cmbProducto.SelectedItem.ToString();
            precio = cmbProducto.SelectedIndex;

            switch (cod)
            {
                case 0: 
                    lblCodigo.Text = "0001";
                    break;
                case 1: 
                    lblCodigo.Text = "0002";
                    break;
               case 2: 
                    lblCodigo.Text = "0003";
                    break;
            }

            switch (nom)
            {
                case "Camiseta": 
                    lblNombre.Text = "Camiseta"; 
                    break;
                case "Gorra": 
                    lblNombre.Text = "Gorra";
                    break;
                default: 
                    lblNombre.Text = "Camisa";
                    break;
            }

            switch (precio)
            {
                case 0: lblPrecio.Text = "10";
                    break;
                case 1: lblPrecio.Text = "5";
                    break;
                default: lblPrecio.Text = "7";
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvLista);

            file.Cells[0].Value = lblCodigo.Text;
            file.Cells[1].Value = lblNombre.Text;
            file.Cells[2].Value = lblPrecio.Text;
            file.Cells[3].Value = txtCantidad.Text;
            file.Cells[4].Value = (float.Parse(lblPrecio.Text) * float.Parse(txtCantidad.Text)).ToString();

            dgvLista.Rows.Add(file);

            lblCodigo.Text = lblNombre.Text = lblPrecio.Text = txtCantidad.Text = "";

            obtenerTotal();


        }

        public void obtenerTotal()
        {
            float costo = 0;
            int contador = 0;

            contador = dgvLista.RowCount;

            for (int i = 0; i < contador; i++)
           {
                costo += float.Parse(dgvLista.Rows[i].Cells[4].Value.ToString());
            }

            lblTotatlPagar.Text = costo.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try {
                DialogResult abc = MessageBox.Show("¿Desea eliminar este producto?",
                    "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (abc == DialogResult.Yes)
                {
                    dgvLista.Rows.Remove(dgvLista.CurrentRow);
                }
            }
            catch { }
            obtenerTotal();
        }


        private void btnVender_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Venta realizada con exito ");
               
        }
    }
    }
