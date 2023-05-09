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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }



        private void buttonBACK_Click(object sender, EventArgs e)
        {
            FormClickMe formClickMe = new FormClickMe();
            formClickMe.ShowDialog();
            this.Hide();

        }

        private void buttonCreateBooking_Click(object sender, EventArgs e)
        {
            FormPreferedCar formPreferedCar = new FormPreferedCar();
            formPreferedCar.ShowDialog();
            this.Hide();
        }

        private void buttonCarRegistration_Click(object sender, EventArgs e)
        {
            CarRegistrationForm formCarRegistration = new CarRegistrationForm();
            formCarRegistration.ShowDialog();
            this.Hide();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            FormView formView = new FormView();
            formView.Show();
            this.Hide();
        }
    }
}

