using MA_LAB1.Models;
using Route = MA_LAB1.Models.Route;

namespace MA_LAB1.Infrastructure
{
	public class DataOutput
	{
		public IEnumerable<Account> Users { get; set; }
		public IEnumerable<Truck> Trucks { get; set; }
		public IEnumerable<Route> Routes { get; set; }
		public Account Account { get; set; }
		public Truck Truck { get; set; }
		public Route Route { get; set; }

	}
}
