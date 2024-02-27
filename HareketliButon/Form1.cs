namespace HareketliButon
{
    public partial class Form1 : Form
    {
        // her buton yada ilgili tuþa basýldýðýnda 5 er pixellik ilgili yöne gitsin

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
            if (btonKutu.Location.Y - 5 > 0) // 0 en üst lokasyon
            {
                // yukarý gitmeye devam
                btonKutu.Location = new Point(btonKutu.Location.X, btonKutu.Location.Y - 5);
            }
        }

        private void btonS_Click(object sender, EventArgs e)
        {
            if (btonKutu.Location.Y + 5 < this.Height - 2 * btonKutu.Height)
            {
                // asaðý gitmeye devam
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
            if (btonKutu.Location.X - 5 > 0) // hala en saða gelmedim
            {
                btonKutu.Location = new Point(btonKutu.Location.X - 5, btonKutu.Location.Y);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // form üzeründe bir tusa basýldýðýnda

            if (e.KeyCode == Keys.A) // sol
            {
                if (btonKutu.Location.X - 5 > 0) // hala en saða gelmedim
                {
                    btonKutu.Location = new Point(btonKutu.Location.X - 5, btonKutu.Location.Y);
                }
            }

            if (e.KeyCode == Keys.D) { }
        }
    }
}
