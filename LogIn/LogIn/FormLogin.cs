using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if(txtName.Text=="BTS"&&txtPassword.Text=="13062013")
            {
                Formshow fs = new Formshow();
                fs.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("The User name or password you entered is incorrect,try again");
                txtName.Clear();
                txtPassword.Clear();
                txtName.Focus();
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
