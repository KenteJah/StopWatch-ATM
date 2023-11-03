namespace StopWatch
{
    public partial class StopWatch : Form
    {
        private DateTime startTime;

        public StopWatch()
        {
            InitializeComponent();
        }

        private void StopWatch_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // set a value to start time
            startTime = DateTime.Now;

            //start the timer
            formTimer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            formTimer.Stop();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            formTimer.Stop();
            watchLabel.Text = "00:00.00";
        }

        private void formTimer_Tick(object sender, EventArgs e)
        {
            // Calculate how long its been since start
            TimeSpan span = DateTime.Now - startTime;
            watchLabel.Text = span.ToString(@"mm\:ss\.ff");
        }
    }
}