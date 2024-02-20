namespace ButonArttir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label1.Text);

            sayi++;

            label1.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label1.Text);

            sayi--;

            if (sayi < 0) 
            {
                label1.Text = "0";
                MessageBox.Show("Daha asaðý gýdemez..");
            }
            else
            {
                label1.Text = sayi.ToString();
            }

            
        }
    }
}
