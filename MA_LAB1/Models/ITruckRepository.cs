namespace MA_LAB1.Models
{
    public interface ITruckRepository
    {
        IQueryable<Truck> GetAllTrucks { get; }
        void SaveTruck(Truck truck);

	}
}
