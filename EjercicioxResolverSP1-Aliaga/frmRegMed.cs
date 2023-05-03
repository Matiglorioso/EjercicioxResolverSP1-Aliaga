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
    public partial class frmRegMed : Form
    {
        public frmRegMed()
        {
            InitializeComponent();
        }

        private void frmRegMed_Load(object sender, EventArgs e)
        {
            CargarDatos();
            txtMatricula.Text = "";
            txtNombreMed.Text = "";
            btnRegMed.Enabled = false;
        }
        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
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
        private bool ValidarDatos2()
        {
            // devuelve falso si no se cumplen todas las condiciones
            bool resultado = false;
            if (txtMatricula.Text != "") // controla el valor del código
            {
                if (txtNombreMed.Text != "") // controla el nombre
                {
                    Medico MED = new Medico();
                    MED.NombreArchivo2 = "Medicos.txt";
                    // controla que no se repita el codigo del repuesto
                    if (MED.BuscarMatricula(txtMatricula.Text) == false)
                    {
                        resultado = true; // devuelve verdadero sólo si todas
                                          // las condiciones se cumplieron
                    }
                    else
                    {
                        MessageBox.Show("La matrícula ingresada ya existe", "ATENCIÓN", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMatricula.Focus();
                        txtMatricula.SelectAll();
                    }
                }
            }
            return resultado;
        }
        private Medico CrearMedico()
        {
            Medico newMed = new Medico();
            newMed.Matricula = int.Parse(txtMatricula.Text);
            newMed.Nombre = txtNombreMed.Text;
            newMed.EspecialidadId = cmbEspecialidad.SelectedIndex.ToString();
            return newMed;
        }
        
        private void CargarDatos()
        {
            string[] lineas = File.ReadAllLines("Especialidades.txt");
            foreach (string linea in lineas)
            {
                string[] especialidades = linea.Split(',');
                int indice = int.Parse(especialidades[0]);
                string esp = especialidades[1];
                cmbEspecialidad.Items.Add(esp);
            }
            cmbEspecialidad.SelectedIndex = 0;
        }

        private void btnRegMed_Click(object sender, EventArgs e)
        {
            if (ValidarDatos2())
            {
                Medico nuevoMed = CrearMedico();
                Medico medico = new Medico();
                medico.NombreArchivo2 = "Medicos.txt";
                medico.GrabarMedico(nuevoMed);
                txtNombreMed.Text = "";
                txtMatricula.Text = "";
                cmbEspecialidad.SelectedIndex = 0;
                btnRegMed.Enabled = false;
            }
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
            if (txtMatricula.Text != "" && txtNombreMed.Text != "")
            {
                btnRegMed.Enabled = true;
            }
            else
            {
                btnRegMed.Enabled = false;
            }
        }

        private void txtNombreMed_TextChanged(object sender, EventArgs e)
        {
            if (txtMatricula.Text != "" && txtNombreMed.Text != "")
            {
                btnRegMed.Enabled = true;
            }
            else
            {
                btnRegMed.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
