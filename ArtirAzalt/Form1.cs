namespace ArtirAzalt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                int miktar = Convert.ToInt32(numericUpDown1.Value);

                int deger = Convert.ToInt32(label3.Text);

                label3.Text = (deger + miktar).ToString();
            }

            if (radioButton2.Checked == true)
            {
                int miktar = Convert.ToInt32(numericUpDown1.Value);

                int deger = Convert.ToInt32(label3.Text);

                label3.Text = (deger - miktar).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 1000;
        }
    }
}
