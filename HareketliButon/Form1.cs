namespace HareketliButon
{
    public partial class Form1 : Form
    {
        // her buton yada ilgili tu�a bas�ld���nda 5 er pixellik ilgili y�ne gitsin

        public Form1()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btonW_Click(object sender, EventArgs e)
        {
            if (btonKutu.Location.Y - 5 > 0) // 0 en �st lokasyon
            {
                // yukar� gitmeye devam
                btonKutu.Location = new Point(btonKutu.Location.X, btonKutu.Location.Y - 5);
            }
        }

        private void btonS_Click(object sender, EventArgs e)
        {
            if (btonKutu.Location.Y + 5 < this.Height - 2 * btonKutu.Height)
            {
                // asa�� gitmeye devam
                btonKutu.Location = new Point(btonKutu.Location.X, btonKutu.Location.Y + 5);
            }
        }

        private void btonD_Click(object sender, EventArgs e)
        {
            if (btonKutu.Location.X + 5 < this.Width - btonKutu.Width)
            {
                btonKutu.Location = new Point(btonKutu.Location.X + 5, btonKutu.Location.Y);
            }
        }

        private void btonA_Click(object sender, EventArgs e)
        {
            if (btonKutu.Location.X - 5 > 0) // hala en sa�a gelmedim
            {
                btonKutu.Location = new Point(btonKutu.Location.X - 5, btonKutu.Location.Y);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // form �zer�nde bir tusa bas�ld���nda

            if (e.KeyCode == Keys.A) // sol
            {
                if (btonKutu.Location.X - 5 > 0) // hala en sa�a gelmedim
                {
                    btonKutu.Location = new Point(btonKutu.Location.X - 5, btonKutu.Location.Y);
                }
            }

            if (e.KeyCode == Keys.D) { }
        }
    }
}
