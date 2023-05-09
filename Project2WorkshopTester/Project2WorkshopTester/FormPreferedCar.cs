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
    public partial class FormPreferedCar : Form
    {
        public FormPreferedCar()
        {
            InitializeComponent();
        }

        private void labelPreferedType_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormClickMe FormClickMe = new FormClickMe();
            FormClickMe.Show();
            this.Hide();//CloseForm
        }
    }
}
