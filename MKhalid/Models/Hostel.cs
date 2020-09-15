using System;
using System.Data.Entity;

namespace MKhalid.Models
{
    public class Hostel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string OwnerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public class HostelDBContext : DbContext
        {
            public DbSet<Hostel> Hostels { get; set; }
        }
    }
}