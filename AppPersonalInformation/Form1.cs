using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPersonalInformation
{
    public partial class AppInformation : Form
    {
        public AppInformation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
           string apellido = txtApellido.Text;
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void txtDirreccion_TextChanged(object sender, EventArgs e)
        {
            string direccion = txtDirreccion.Text;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            string edad = txtEdad.Text;
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAcceptar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            string direccion = txtDirreccion.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(edad))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Sale del método sin procesar la información
            }

            txtResultado.Text = "Nombre: " + nombre + Environment.NewLine +
                                  "Apelldio: " + apellido + Environment.NewLine +
                                  "Edad: " + edad + Environment.NewLine +
                                  "Direccion: " + direccion + Environment.NewLine;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, FormClosingEventArgs e)
        {

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Suprime la tecla si no es un número o retroceso
            }
        }
    }
}
