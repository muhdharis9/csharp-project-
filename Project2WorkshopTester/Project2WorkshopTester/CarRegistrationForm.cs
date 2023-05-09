using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project2WorkshopTester
{
    public partial class CarRegistrationForm : Form
    {
        public CarRegistrationForm()
        {
            InitializeComponent();
        }

        private void panelCarRegistration_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           MenuForm menuform = new MenuForm();
           menuform.Show();
           this.Hide();
        }

        private void pictureBoxPHOTOCar_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPHOTOCar.Load(openFileDialog1.FileName);
                pictureBoxPHOTOCar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxNAME_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void textBoxPLATENO_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxMODEL_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (textBoxNAME.Text == string.Empty)
            { MessageBox.Show($"Sila masukkan nama"); }
            else if (textBoxPLATENO.Text == string.Empty)
            { MessageBox.Show($"Sila nombor plate kenderaan anda"); }
            else if (textBoxMODEL.Text == string.Empty)
            { MessageBox.Show($"Sila masukkan model kereta anda"); }
            else if (comboBoxTYPECar.Text == string.Empty)
            { MessageBox.Show($"Sila pilih jenis kenderaan anda"); }
            else if (comboBoxTYPECar.Text == string.Empty)
            { MessageBox.Show($"Sila pilih availability"); }
            //else if (pictureBoxPHOTOCar. == string.Empty)
            //{ MessageBox.Show($"Sila masukkan gambar kereta anda"); }
            else
            {
                FormDisplayCarRegistration formDisplayCarRegistration = new FormDisplayCarRegistration();
                formDisplayCarRegistration.ShowDialog();
                this.Hide();
            }

        }
    }
}
