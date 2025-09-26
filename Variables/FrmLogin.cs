using System;
using System.Windows.Forms;

namespace Variables
{
    public partial class FrmLogin : Form
    {
        int attempts = 0; 




        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            tbUser.Focus();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (Login(tbUser.Text, tbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                //new FrmPrincipal().Show();
                //this.Hide();
            }

            else
            {
                attempts++;
                MessageBox.Show("Contra invalida");

            }
            
            if (attempts == 3)
            {
              
             MessageBox.Show("Has superado el número de intentos permitidos.", "Error", MessageBoxButtons.OK);
             this.Close();
                
            }
        }

        private Boolean Login (string username, string password)
        {
            return username.Equals("admin") && password.Equals("admin");
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
