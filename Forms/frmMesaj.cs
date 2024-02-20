using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class frmMesaj : Form
    {
        public frmMesaj()
        {
            InitializeComponent();
        }



        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Girdiğiniz bilgi : " + tboxMesaj.Text); // Show a message box

            tboxMesaj.Text = "-- mesaj giriniz"; // Clear the textbox

            tboxMesaj.Focus(); // Focus the textbox
        }

        private void tboxMesaj_MouseClick(object sender, MouseEventArgs e)
        {
            tboxMesaj.Clear(); // Clear the textbox
        }

        private void frmMesaj_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Girdiğiniz bilgi : " + tboxMesaj.Text); // Show a message box

            tboxMesaj.Text = "-- mesaj giriniz"; // Clear the textbox

            tboxMesaj.Focus(); // Focus the textbox
        }

        private void tboxMesaj_TextChanged(object sender, EventArgs e)
        {

        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
