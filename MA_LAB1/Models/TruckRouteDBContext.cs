using Microsoft.EntityFrameworkCore;

namespace MA_LAB1.Models
{
    public class TruckRouteDBContext: DbContext
    {
        public TruckRouteDBContext(DbContextOptions<TruckRouteDBContext> dbContextOptions)
           : base(dbContextOptions) { }

        //entity --> table name too
        public DbSet<Account> Users { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Route> Routes { get; set; }
    }
}
