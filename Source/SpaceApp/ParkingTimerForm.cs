using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpacePark;

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
        public Form2 form2 { get; set; }

        public ParkingTimerForm(Form2 parent)
        {
            InitializeComponent();
            form2 = parent;
        }

        public void ShowForm(dynamic person, dynamic starShip)
        {
            Person = person;
            StarShip = starShip;
            this.timePicker.CustomFormat = "HH:mm";
            CurrentTime = DateTime.Now;
            nameLabel.Text = $"name: {person["name"]}";
            shipLabel.Text = $"starship: {starShip["name"]}";
            currentTimeTimer.Start();
            this.Show();
        }

        //klickat på parkera knappen
        private void timeIsPicked(object sender, EventArgs e)
        {
            SelectedTime = timePicker.Value;
            StartTime = CurrentTime;
            listbox.Items.Clear();
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
                int parkedTime = (CurrentTime - StartTime).Minutes;
                CalculatePrice(parkedTime);
                listbox.Items.Add($"");
                listbox.Items.Add($"{Person["name"]} parked with {StarShip["name"]} for: {parkedTime} min and it cost:{Price} credits");
                Database.StoreParking(Person, StarShip, parkedTime, Price);
                SelectedTime = null;
            }
        }

        //kolla historik från databas
        private void dbButton_Click(object sender, EventArgs e)
        {
            SpaceParkContext db = new SpaceParkContext();
            var queryList = db.ParkEvent.AsQueryable();
            listbox.Items.Clear();
            listbox.Items.Add("History: ");
            foreach (var query in queryList)
            {
                query.Person = db.Person.Find(query.PersonId);
                query.StarShip = db.StarShip.Find(query.StarShipId);
                listbox.Items.Add($"{query.Person.Name} parked for {query.TimeParked} min with the ship \"{query.StarShip.StarShipName}\", it cost {query.Price} credits");
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }
    }
}
