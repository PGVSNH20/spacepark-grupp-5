using System;
using System.Windows.Forms;

namespace SpaceApp
{
    public partial class ParkingTimerForm : Form
    {
        private DateTime StartTime { get; set; }
        private DateTime? SelectedTime { get; set; }
        private DateTime CurrentTime { get; set; }
        private int Price { get; set; }
        public dynamic Person { get; set; }
        public dynamic StarShip { get; set; }

        public ParkingTimerForm()
        {
            InitializeComponent();
            this.timePicker.CustomFormat = "HH:mm";
            CurrentTime = DateTime.Now;
            currentTimeTimer.Start();
        }

        //klickat på parkera knappen
        private void timeIsPicked(object sender, EventArgs e)
        {
            SelectedTime = timePicker.Value;
            StartTime = CurrentTime;
            listbox.Items.Add($"Started parking: {StartTime.ToShortTimeString()} Stopping: {SelectedTime.Value.ToShortTimeString()}");
        }

        //timer där 5 minuter passerar varje sekund
        private void currentTimeChange(object sender, EventArgs e)
        {
            var second = CurrentTime.AddMinutes(1);
            CurrentTime = second;
            currentTime.Text = CurrentTime.ToShortTimeString();
            if (SelectedTime != null)
            {
                CheckIfParkingIsOver();
            }
        }

        private void CalculatePrice(int time)
        {
            // kostar 5 credits i minuten
            Price = time * 5;
        }

        //kolla om valda tiden är samma som "nuvarande" tiden
        private void CheckIfParkingIsOver()
        {
            if (SelectedTime.Value.ToShortTimeString() == CurrentTime.ToShortTimeString())
            {
                int parkedTimeInMinutes = (CurrentTime - StartTime).Minutes;
                CalculatePrice(parkedTimeInMinutes);
                listbox.Items.Add($"You parked for: {parkedTimeInMinutes} Minutes and it cost:{Price} credits");
                SelectedTime = null;
            }
        }
    }
}
