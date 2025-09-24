using System;

using System.Windows.Forms;
using Variables.Modelos;

namespace Variables
{
    public partial class Form1 : Form
    {
        Facultad fac = new Facultad();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            Facultad fia = new Facultad();
            fia.Codigo = tbCodigo.Text;
            fia.Nombre = tbNombre.Text;

            lblVariableLocal.Text = fia.MostrarDatos();
            fac = fia;
        }

        private void btnVerificarG_Click(object sender, EventArgs e)
        {
            lblVariableGlobal.Text = fac.MostrarDatos();
        }
    }
}
