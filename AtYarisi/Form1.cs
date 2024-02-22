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
            label2.Text = "Se�iminiz 1 numaral� at";
        }

        private void btonAt2_Click(object sender, EventArgs e)
        {
            label2.Text = "Se�iminiz 2 numaral� at";
        }

        private void btonAt3_Click(object sender, EventArgs e)
        {
            label2.Text = "Se�iminiz 3 numaral� at";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IlkKonum()
        {
            btonAt1.Location = new Point(btn1x, btn1y);
            btonAt2.Location = new Point(btn2x, btn2y);
            btonAt3.Location = new Point(btn3x, btn3y);

            button1.Enabled = true;
            btonAt1.Enabled = true;
            btonAt2.Enabled = true;
            btonAt3.Enabled = true;

            label2.Text = "";
            
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

            
            if (btonAt1.Right > lbelBitis.Left ||
                btonAt2.Right > lbelBitis.Left ||
                btonAt3.Right > lbelBitis.Left)
            {
                // Biti� label�na ulast�ysa yani yar�s bittiyse
                // hangi at bitirdi
                if (btonAt1.Right > btonAt2.Right &&
                    btonAt1.Right > btonAt3.Right)
                {
                    // 1 ondeyse
                    if (label2.Text== "Se�iminiz 1 numaral� at")
                    {
                        timer1.Stop();
                        MessageBox.Show("Tebrikler bildiniz","Yar�� Bitti",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        IlkKonum();
                    }
                    else
                    {
                        timer1.Stop();
                        MessageBox.Show("Maalesef bilemediniz", "Yar�� Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        IlkKonum();
                    }
                }
                else if ()
            }


        }
    }
}
