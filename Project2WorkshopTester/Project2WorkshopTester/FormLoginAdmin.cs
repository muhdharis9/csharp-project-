using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project2WorkshopTester
{
    
    public partial class FormLoginAdmin : Form
    {
        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FormClickMe formClickMe = new FormClickMe();
            formClickMe.Show();
            this.Hide();
        }

        private void FormLoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            AdminRegistrationForm adminRegistrationForm = new AdminRegistrationForm();
            adminRegistrationForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsernameLogin.Text == string.Empty)
            { MessageBox.Show($"Sila masukkan username anda"); }
            else if (maskedTextBoxpasswordlogin.Text == string.Empty)
            { MessageBox.Show($"Sila masukkan password anda"); }
            else
            {
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
                this.Hide();
            }
        }
    }
}
