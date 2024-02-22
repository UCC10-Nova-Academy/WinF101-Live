namespace AtYarisi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        // bu deðisgenler hareket edecek olan buton koordinatlarýný tutacak
        int btn1x, btn1y; // 1.at butonu için
        int btn2x, btn2y; // 2.at butonu için
        int btn3x, btn3y; // 3.at butonu için




        public Form1()
        {
            InitializeComponent();
        }

        private void btonAt1_Click(object sender, EventArgs e)
        {
            label2.Text = " Seçiminiz 1 numaralý at";
        }

        private void btonAt2_Click(object sender, EventArgs e)
        {
            label2.Text = " Seçiminiz 2 numaralý at";
        }

        private void btonAt3_Click(object sender, EventArgs e)
        {
            label2.Text = " Seçiminiz 3 numaralý at";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Burada butonlarýn ilk konumlarýný ayarlýyorum.

            btn1x = btonAt1.Location.X;
            btn1y = btonAt1.Location.Y;

            btn2x = btonAt2.Location.X;
            btn2y = btonAt2.Location.Y;

            btn3x = btonAt3.Location.X;
            btn3y = btonAt3.Location.Y;

            // Olura kullanýcý bir at seçmemiþ olabilir.

            if (label2.Text == "Seçiminiz")
            {
                MessageBox.Show("Lütfen at seçiminizi yapýnýz..");
            }
            else
            {
                // Kullaýcýnýn yarýþ basladýktan sonra herhangi bþr butona tekrardan basmasýný engellemek için
                btonAt1.Enabled = false;
                btonAt2.Enabled = false;
                btonAt3.Enabled = false;
                button1.Enabled = false;

                timer1.Start();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // her bir at için rastgele bir sayý ureteceðim

            int konum1 = rnd.Next(2, 10);
            int konum2 = rnd.Next(2, 10);
            int konum3 = rnd.Next(2, 10);

            if (btonAt1.)


        }
    }
}
