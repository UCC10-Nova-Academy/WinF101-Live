namespace TekCift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ekrandan bir textbox �cer�g�n� nas�l okur ve bir de�i�gene atar�m.

            int sayi = Convert.ToInt32(textBox1.Text);

            if (sayi % 2 == 0) // ikiye bolumunden kalan 
            {
                MessageBox.Show("Girmi� oldu�unuz " + sayi + " �iftdir..");
            }
            else
            {
                MessageBox.Show("Girmi� oldu�unuz " + sayi + " tekdir..");
            }

            textBox1.Clear();
        }
    }
}
