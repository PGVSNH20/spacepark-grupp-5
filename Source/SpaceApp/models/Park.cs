using Microsoft.EntityFrameworkCore;
using System;

namespace SpacePark
{
    public class ParkEvent
    {
        public int ParkEventId { get; set; }
        public decimal Price { get; set; }
        public string TimeParked { get; set; }
        public StarShip StarShip { get; set; }
        public int StarShipId { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
    }

    public class SpaceParkContext : DbContext
    {
        public DbSet<ParkEvent> ParkEvent { get; set; }
        public DbSet<StarShip> StarShip { get; set; }
        public DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data source=./sql_lite_test.db");
    }

    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
    }

    public class StarShip
    {
        public int StarShipId { get; set; }
        public string StarShipName { get; set; }
    }
}