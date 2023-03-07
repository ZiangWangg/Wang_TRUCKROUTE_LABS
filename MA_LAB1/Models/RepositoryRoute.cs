namespace MA_LAB1.Models
{
    public class RepositoryRoute: IRouteRepository
    {
        /*private static List<Route> Routes = new List<Route>();
        public static void AddData(Route r)
        {
            Routes.Add(r);
        }


        public static IEnumerable<Route> getData => Routes; */


        private TruckRouteDBContext _dbContext;
        public RepositoryRoute(TruckRouteDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Route> GetAllRoutes => _dbContext.Routes;

		public void SaveRoute(Route route)
		{


			_dbContext.Routes.Add(route);


			_dbContext.SaveChanges();
		}
	}
}
