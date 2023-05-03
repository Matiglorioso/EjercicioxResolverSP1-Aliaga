using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EjercicioxResolverSP1_Aliaga
{
    public partial class frmRegEsp : Form
    {
        public frmRegEsp()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            btnRegistrar.Enabled = false;
        }
        private bool ValidarDatos()
        {
            // devuelve falso si no se cumplen todas las condiciones
            bool resultado = false;
            if (txtID.Text != "") // controla el valor del código
            {
                if (txtNombre.Text != "") // controla el nombre
                {
                    Especialidad esp = new Especialidad();
                    esp.NombreArchivo = "Especialidades.txt";
                    // controla que no se repita el codigo del repuesto
                    if (esp.BuscarIDEspecialidad(txtID.Text) == false)
                    {
                        resultado = true; // devuelve verdadero sólo si todas
                                          // las condiciones se cumplieron
                    }
                    else
                    {
                        MessageBox.Show("El ID de la especialidad ya existe", "ATENCIÓN", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Focus();
                        txtID.SelectAll();
                    }
                }
            }

            return resultado;
        }
        private Especialidad CrearEspecialidad()
        {
            Especialidad nuevaEsp = new Especialidad();
            nuevaEsp.Id = int.Parse(txtID.Text);
            nuevaEsp.Nombre = txtNombre.Text;
            return nuevaEsp;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Especialidad nuevaEsp = CrearEspecialidad();
                Especialidad especialidad = new Especialidad();
                especialidad.NombreArchivo = "Especialidades.txt";
                especialidad.GrabarEspecialidad(nuevaEsp);
                txtID.Text = "";
                txtNombre.Text = "";
                btnRegistrar.Enabled = false;

            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtNombre.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtNombre.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }      

}


     