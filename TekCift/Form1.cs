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
            // ekrandan bir textbox ýcerýgýný nasýl okur ve bir deðiþgene atarým.

            int sayi = Convert.ToInt32(textBox1.Text);

            if (sayi % 2 == 0) // ikiye bolumunden kalan 
            {
                MessageBox.Show("Girmiþ olduðunuz " + sayi + " çiftdir..");
            }
            else
            {
                MessageBox.Show("Girmiþ olduðunuz " + sayi + " tekdir..");
            }

            textBox1.Clear();
        }
    }
}
