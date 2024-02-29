using System.Collections;

namespace ListboxTransfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // listbox a eleman ekleme ...program yoluyla

            lboxSehirler.Items.Add(tboxSehir.Text);

            tboxSehir.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lboxSehirler.Items.Remove(lboxSehirler.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gonder(ListBox lbox1, ListBox lbox2)
        {
            ArrayList secilenler = new ArrayList();

            secilenler.AddRange(lbox1.SelectedItems);

            foreach (var sehir in secilenler)
            {
                lbox2.Items.Add(sehir);

                lbox1.Items.Remove(sehir);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // soldan saga tasýma tekli

            gonder(lboxSehirler, lboxOburu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gonder(lboxOburu, lboxSehirler);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var sehir in lboxSehirler.Items)
            {
                lboxOburu.Items.Add(sehir);
            }

            lboxSehirler.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var oburu in lboxOburu.Items)
            {
                lboxSehirler.Items.Add(oburu);
            }

            lboxOburu.Items.Clear();
        }
    }
}
