namespace DateDiffer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dtpStart.Text);
            DateTime endDate = Convert.ToDateTime(dtpEnd.Text);

            TimeSpan sonuc = endDate.Subtract(startDate); // enddate - startdate

            string Year = Convert.ToString(Math.Round(sonuc.TotalDays / 365, 2)) + " Yýl cinsinden veya";
            string Month = Convert.ToString(Math.Round(sonuc.TotalDays / 30, 2)) + " Ay cinsinden  veya";
            string Day = Math.Round(sonuc.TotalDays, 2).ToString() + " Gün cinsinden  veya";
            string Hour = Math.Round(sonuc.TotalHours, 2).ToString() + " Saat cinsinden  veya";
            string Minute = Math.Round(sonuc.TotalMinutes, 2).ToString() + " Dakika cinsinden  veya";
            string Second = Math.Round(sonuc.TotalSeconds, 2).ToString() + " Saniye cinsinden  veya";
            string MSecond = Math.Round(sonuc.TotalMilliseconds, 2).ToString() + " Salise cinsinden";

            lbSonuc.Items.Clear();

            lbSonuc.Items.Add(Year);
            lbSonuc.Items.Add(Month);
            lbSonuc.Items.Add(Day);
            lbSonuc.Items.Add(Hour);
            lbSonuc.Items.Add(Minute);
            lbSonuc.Items.Add(Second);
            lbSonuc.Items.Add(MSecond);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
