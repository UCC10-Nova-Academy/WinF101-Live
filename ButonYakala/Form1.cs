namespace ButonYakala
{
    public partial class Form1 : Form
    {
        int sayac; // Kac denemede yakalandý
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

            button1.Location = new Point(rand.Next(0, this.Width - button1.Width), rand.Next(0, this.Height - button1.Height));

            sayac++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sabit Form
            this.Width = 500;
            this.Height = 500;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Yakaladým seni...{sayac}. denemede...");
            sayac = 0;
        }
    }
}
