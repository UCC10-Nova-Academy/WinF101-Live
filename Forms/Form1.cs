using System.DirectoryServices;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Girdiðiniz bilgi : " + tboxMesaj.Text); // Show a message box

            //tboxMesaj.Text = "-- mesaj giriniz"; // Clear the textbox

            //tboxMesaj.Focus(); // Focus the textbox
        }

        private void tboxMesaj_MouseClick(object sender, MouseEventArgs e)
        {
            //tboxMesaj.Clear(); // Clear the textbox
        }



        private void comboboxFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Acmak istediðim formu orneklemem lazým

            frmComboBox frmComboBox = new frmComboBox(); // yeni bir nesne ornekledim.

            frmComboBox.ShowDialog();
        }

        private void mesajFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMesaj frmMesaj = new frmMesaj();

            frmMesaj.ShowDialog();
        }

        private void programCikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
