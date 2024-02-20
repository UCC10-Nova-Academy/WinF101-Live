namespace HesapMakinasi
{
    public partial class Form1 : Form
    {
        string islem; // islem kodu
        double sonuc; // iþlem sonucu
        bool kontrol = false; // kontrol iþlemlerinde kullanýlacak


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayi_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // Öðrendim ..Örnekledim.. hangi butona basýlmýþsa

            //SayiAl(button);
            SayiAl((Button)sender); // Butonun hangi buton olduğunu öğrendim

        }

        private void SayiAl(Button btn)
        {
            // Hangi butona basýldýðýný anlamalýyým ki yukrdakþ textbox a onu gösterebileyim
            if (kontrol)
            {
                kontrol = false;
                tboxSayi.Text = "";
            }

            tboxSayi.Text = tboxSayi.Text + btn.Text; // basýlmýþ olan butonun üzerinde yazan rakamý alýyorum.
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tboxSayi.Clear();
        }

        private void btonTopla_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            islem = Convert.ToString(b.Text); // iþlemin + iþlemi olduðunu ogreniyorum.

            sonuc = Convert.ToDouble(tboxSayi.Text);

            tboxSayi.Text = "";
        }

        private void btonCikart_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            islem = Convert.ToString(b.Text); // iþlemin - iþlemi olduðunu ogreniyorum.

            sonuc = Convert.ToDouble(tboxSayi.Text);

            tboxSayi.Text = "";
        }

        private void btonCarp_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            islem = Convert.ToString(b.Text); // iþlemin * iþlemi olduðunu ogreniyorum.

            sonuc = Convert.ToDouble(tboxSayi.Text);

            tboxSayi.Text = "";
        }

        private void btonBol_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            islem = Convert.ToString(b.Text); // iþlemin / iþlemi olduðunu ogreniyorum.

            sonuc = Convert.ToDouble(tboxSayi.Text);

            tboxSayi.Text = "";
        }

        private void btonSonuc_Click(object sender, EventArgs e)
        {
            switch (islem)
            {
                case "+":
                    tboxSayi.Text = (sonuc + Convert.ToDouble(tboxSayi.Text)).ToString();
                    break;
                case "-":
                    tboxSayi.Text = (sonuc - Convert.ToDouble(tboxSayi.Text)).ToString();
                    break;
                case "*":
                    tboxSayi.Text = (sonuc * Convert.ToDouble(tboxSayi.Text)).ToString();
                    break;
                case "/":
                    tboxSayi.Text = (sonuc / Convert.ToDouble(tboxSayi.Text)).ToString();
                    break;
            }

            kontrol = true;
            sonuc = 0;
        }
    }
}
