using Timer = System.Windows.Forms.Timer;

namespace BakuLondonTask
{
    public partial class Form1 : Form
    {
        DateTime dt = DateTime.Now;
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.baku;
            dt = DateTime.Now;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dt = dt.AddSeconds(1);
            hourLabel.Text = dt.ToLongTimeString();
        }

        private void bakuButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.baku;
            dt = DateTime.Now;
        }

        private void londonButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.london;
            dt = DateTime.Now.AddHours(-4);
        }
    }
}
