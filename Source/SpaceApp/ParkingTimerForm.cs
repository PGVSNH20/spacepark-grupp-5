using System;
using System.Windows.Forms;

namespace SpaceApp
{
    public partial class ParkingTimerForm : Form
    {
        private DateTime StartTime { get; set; }
        private DateTime SelectedTime { get; set; }
        private DateTime CurrentTimeStart { get; set; }

        public ParkingTimerForm()
        {
            InitializeComponent();
            this.timePicker.CustomFormat = "dd/MM hh:mm";
            CurrentTimeStart = DateTime.Now;
            currentTimeTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int seconds = (int)(DateTime.Now - StartTime).TotalSeconds;
            timerLabel.Text = seconds.ToString();
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
            { 
                timer.Stop();
                timer.Enabled = false;
                timerButton.Text = "Start";
                timerLabel.Visible = false;
                listbox.Items.Add(timerLabel.Text);
            }
            else if (timer.Enabled == false)
            {
                timer.Enabled = true;
                timer.Start();
                StartTime = DateTime.Now;
                timerButton.Text = "Stop";
                timerLabel.Visible = true;
            }
        }

        private void timeIsPicked(object sender, EventArgs e)
        {
            SelectedTime = timePicker.Value;
        }

        //Körs efter 10ms
        private void currentTimeChange(object sender, EventArgs e)
        {
            var second = CurrentTimeStart.AddSeconds(1);
            CurrentTimeStart = second;
            currentTime.Text = CurrentTimeStart.ToShortTimeString();
        }
    }
}
