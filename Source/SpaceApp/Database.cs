using System;

namespace SpacePark
{
    public class Database
    {
        public static void StoreInDatabase(dynamic results)
        {
            //Ser till att databasen är skapad
            var db = new SpaceParkContext();
            db.Database.EnsureCreated();

            //Lägger till ett skepp för testsyften
            AddMilleniumFalconToDatabase(db);
            var starship = db.StarShip.Find(1);

            //Add-Migration SpaceApp
            //Update-Database


            var person = new ParkEvent()
            {
                FirstName = results["name"],
                Price = 42m,
                StarShipId = 1,
                Time = "1h 32m"
            };

            db.Add(person);
            db.SaveChanges();

            Console.WriteLine($"{person.FirstName} har parkerat med {starship.StarShipName} i {person.Time} och får betala {person.Price} credits");
            PrintFromDatabase(db);
        }

        public static void InputCreationTestWithApi()
        {
            Rest starwars = new Rest();
            var results = starwars.Search("luke");

            StoreInDatabase(results);
        }

        public static void AddMilleniumFalconToDatabase(SpaceParkContext db)
        {
            if (db.StarShip.Find(1) == null)
            {
                StarShip starShip = new StarShip() { StarShipId = 1, StarShipName = "Millenium Falcon" };
                db.Add(starShip);
                db.SaveChanges();
            }
        }

        public static void PrintFromDatabase(SpaceParkContext db)
        {
            var noQueryList = db.ParkEvent.AsQueryable();
            Console.WriteLine("Parkeringar som gjorts hitills: ");
            foreach (var query in noQueryList)
            {
                query.StarShip = db.StarShip.Find(query.StarShipId);
                Console.WriteLine($"{query.FirstName} {query.LastName} parkerade i {query.Time} med skeppet \"{query.StarShip.StarShipName}\" och det kostade {query.Price} credits\n");
            }
        }
    }
}