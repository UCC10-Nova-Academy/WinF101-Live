namespace AtYarisi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        // bu de�isgenler hareket edecek olan buton koordinatlar�n� tutacak
        int btn1x, btn1y; // 1.at butonu i�in
        int btn2x, btn2y; // 2.at butonu i�in
        int btn3x, btn3y; // 3.at butonu i�in




        public Form1()
        {
            InitializeComponent();
        }

        private void btonAt1_Click(object sender, EventArgs e)
        {
            label2.Text = " Se�iminiz 1 numaral� at";
        }

        private void btonAt2_Click(object sender, EventArgs e)
        {
            label2.Text = " Se�iminiz 2 numaral� at";
        }

        private void btonAt3_Click(object sender, EventArgs e)
        {
            label2.Text = " Se�iminiz 3 numaral� at";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Burada butonlar�n ilk konumlar�n� ayarl�yorum.

            btn1x = btonAt1.Location.X;
            btn1y = btonAt1.Location.Y;

            btn2x = btonAt2.Location.X;
            btn2y = btonAt2.Location.Y;

            btn3x = btonAt3.Location.X;
            btn3y = btonAt3.Location.Y;

            // Olura kullan�c� bir at se�memi� olabilir.

            if (label2.Text == "Se�iminiz")
            {
                MessageBox.Show("L�tfen at se�iminizi yap�n�z..");
            }
            else
            {
                // Kulla�c�n�n yar�� baslad�ktan sonra herhangi b�r butona tekrardan basmas�n� engellemek i�in
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
            // her bir at i�in rastgele bir say� uretece�im

            int konum1 = rnd.Next(2, 10);
            int konum2 = rnd.Next(2, 10);
            int konum3 = rnd.Next(2, 10);

            if (btonAt1.)


        }
    }
}
