namespace MA_LAB1.Models
{
    public interface IRouteRepository
    {
        IQueryable<Route> GetAllRoutes { get; }
        void SaveRoute(Route route);

	}
}
