using Microsoft.EntityFrameworkCore;
using System;

namespace SpacePark
{
    public class ParkEvent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ParkEventId { get; set; }
        public decimal Price { get; set; }
        public StarShip StarShip { get; set; }
        public int StarShipId { get; set; }
        public string Time { get; set; }
    }

    public class SpaceParkContext : DbContext
    {
        public DbSet<ParkEvent> ParkEvent { get; set; }
        public DbSet<StarShip> StarShip { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data source=./sql_lite_test.db");
    }

    public class StarShip
    {
        public int StarShipId { get; set; }
        public string StarShipName { get; set; }
    }
}