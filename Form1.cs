using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precioBase = 0;
            double descuento = 0;
            double precioFinal = 0;

            switch (cmbCombos.SelectedIndex)
            {
                case 0: // Combo Simple
                    precioBase = 5.0;
                    descuento = 0.05;
                    break;
                case 1: // Combo Doble
                    precioBase = 10.0;
                    descuento = 0.10;
                    break;
                case 2: // Combo Premium
                    precioBase = 20.0;
                    descuento = 0.15;
                    break;
                default:
                    MessageBox.Show("Seleccione un combo válido.");
                    return;
            }

            precioFinal = precioBase - (precioBase * descuento);

            txtPrecioBase.Text = "$" + precioBase.ToString();
            txtDescuento.Text = (descuento * 100).ToString() + "%";
            txtTotal.Text = "$" + precioFinal.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbCombos.SelectedIndex = -1; // Ninguna opción seleccionada

            txtPrecioBase.Clear();
            txtDescuento.Clear();
            txtTotal.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
