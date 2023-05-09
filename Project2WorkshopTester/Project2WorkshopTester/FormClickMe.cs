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
    public partial class FormClickMe : Form
    {
        public FormClickMe()
        {
            InitializeComponent();
        }

        private void pictureBoxBackground_Click(object sender, EventArgs e)
        {
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            FormPreferedCar FormPreferedCar = new FormPreferedCar();
            FormPreferedCar.Show();
            this.Hide();//CloseForm
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminCM_Click(object sender, EventArgs e)
        {
            FormLoginAdmin formLoginAdmin = new FormLoginAdmin();
            formLoginAdmin.Show();
            this.Hide();
        }
    }
}
