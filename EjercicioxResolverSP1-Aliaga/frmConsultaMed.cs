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
    public partial class frmConsultaMed : Form
    {
        public frmConsultaMed( )
        {
            InitializeComponent();
        }

        private void frmConsultaMed_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dgvConsultaMed.Rows.Clear();
        }
        private void CargarDatos()
        {
            string[] lineas = File.ReadAllLines("Especialidades.txt");
            foreach (string linea in lineas)
            {
                string[] especialidades = linea.Split(',');
                int indice = int.Parse(especialidades[0]);
                string esp = especialidades[1];
                cmbEspecialidades.Items.Add(esp);
            }
            cmbEspecialidades.SelectedIndex = 0;
        }

    }
}
