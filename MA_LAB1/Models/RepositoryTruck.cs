namespace MA_LAB1.Models
{
    public class RepositoryTruck : ITruckRepository
    {
      /*  private static List<Truck> Trucks = new List<Truck>();
        public static void AddData(Truck t)
        {
            Trucks.Add(t);
        }

        public static IEnumerable<Truck> getData => Trucks;*/

        private TruckRouteDBContext _dbContext;
        public RepositoryTruck(TruckRouteDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Truck> GetAllTrucks => _dbContext.Trucks;

		public void SaveTruck(Truck truck)
		{


			_dbContext.Trucks.Add(truck);


			_dbContext.SaveChanges();
		}
	}
}
