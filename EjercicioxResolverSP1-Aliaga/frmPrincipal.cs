using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioxResolverSP1_Aliaga
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegEsp_Click(object sender, EventArgs e)
        {
            frmRegEsp x = new frmRegEsp();
            x.ShowDialog();
        }

        private void btnRegMed_Click(object sender, EventArgs e)
        {
            frmRegMed x = new frmRegMed();  
            x.ShowDialog(); 
        }

        private void btnConsultarMed_Click(object sender, EventArgs e)
        {
            frmConsultaMed x = new frmConsultaMed();    
            x.ShowDialog();
        }
    }
}
