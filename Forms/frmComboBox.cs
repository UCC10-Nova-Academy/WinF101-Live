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
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboxSayilar.Items.Clear();

            int adet = Convert.ToInt32(tboxAdet.Text); // Get the number of items

            for (int i = 1; i <= adet; i++)
            {
                string sayitext = i.ToString() + ".sayı";

                cboxSayilar.Items.Add(sayitext);
            }

            cboxSayilar.SelectedIndex = 0; // ilk combobox elemanını göster

            tboxAdet.Clear();



        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmComboBox_Load(object sender, EventArgs e)
        {
            // form ekrana ilk geldiğinde

            tboxAdet.Focus();
        }
    }
}
