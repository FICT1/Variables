using System;

using System.Windows.Forms;
using Variables.Modelos;

namespace Variables
{
    public partial class FrmPrincipal : Form
    {
        Facultad fac = new Facultad();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

