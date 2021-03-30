using System;
using System.Threading.Tasks;

namespace SpacePark
{
    public class Database
    {
        private static async Task StorePersonInDatabase(dynamic person, int personId)
        {
            //lägg till om den inte finns
            await Task.Run(() => {
                SpaceParkContext db = new SpaceParkContext();
                var personQuery = db.Person.Find(personId);
                if (personQuery == null)
                {
                    var Person = new Person() { Name = person["name"], PersonId = personId };
                    db.Person.Add(Person);
                    db.SaveChanges();
                }
            });
        }

        private static async Task StoreStarShipInDatabase(dynamic starship, int starshipId)
        {
            //lägg till om den inte finns
            await Task.Run(() => {
                SpaceParkContext db = new SpaceParkContext();
                var starShipQuery = db.StarShip.Find(starshipId);
                if (starShipQuery == null)
                {
                    StarShip starShip = new StarShip() { StarShipName = starship["name"], StarShipId = starshipId };
                    db.StarShip.Add(starShip);
                    db.SaveChanges();
                }
            });
        }

        public static async void StoreParking(dynamic person, dynamic starship, int time, int price)
        {
            SpaceParkContext db = new SpaceParkContext();
            db.Database.EnsureCreated();

            //primary key blir till siffran från swapi url
            var starshipId = Int32.Parse(starship["url"].Remove(0, 31).Trim('/'));
            var personId = Int32.Parse(person["url"].Remove(0, 28).Trim('/'));

            Task persontask = StorePersonInDatabase(person, personId);
            Task starshiptask = StoreStarShipInDatabase(starship, starshipId);

            var park = new ParkEvent() {
                StarShipId = starshipId,
                PersonId = personId,
                TimeParked = time.ToString(),
                Price = price
            };
            db.ParkEvent.Add(park);

            await Task.WhenAll(persontask, starshiptask);
            db.SaveChanges();
        }
    }
}