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
    public partial class AdminRegistrationForm : Form
    {
        public AdminRegistrationForm()
        {
            InitializeComponent();
        }

        private void labelAdminRegistration_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBoxPASSWORD_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
     
        }

        private void buttonBACK_Click(object sender, EventArgs e)
        {
            FormLoginAdmin formLoginAdmin = new FormLoginAdmin();
            formLoginAdmin.ShowDialog();
            this.Hide();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if(textBoxNAME.Text == string.Empty)
            { MessageBox.Show($"Sila masukkan nama"); }
            else if(textBoxICNO.Text == string.Empty)
            {  MessageBox.Show($"Sila ic anda "); }
            else if (textBoxADRESS.Text == string.Empty)
            { MessageBox.Show($"Sila alamat anda"); }
            else if (textBoxEMAIL.Text == string.Empty)
            { MessageBox.Show($"Sila email anda"); }
            else if (textBoxPHONENO.Text == string.Empty)
            { MessageBox.Show($"Sila no telefon anda"); }
            else if (textBoxUSERNAME.Text == string.Empty)
            { MessageBox.Show($"Sila username anda"); }
            else if (maskedTextBoxPASSWORD.Text == string.Empty)
            { MessageBox.Show($"Sila masukkan password anda"); }
            else 
            {
                FormDisplayAdminRegistration formDisplayAdminRegistration = new FormDisplayAdminRegistration();
                formDisplayAdminRegistration.Show();

            }
        }
    }
}
