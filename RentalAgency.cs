public class RentalAgency
{
    public Vehicle[] Fleet;
    public double TotalRevenue { get; private set; }

    public RentalAgency()
    {
        Fleet = new Vehicle[0];
        TotalRevenue = 0;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        Array.Resize(ref Fleet, Fleet.Length + 1);
        Fleet[Fleet.Length - 1] = vehicle;
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        int index = Array.IndexOf(Fleet, vehicle);
        if (index != -1)
        {
            TotalRevenue += vehicle.RentalPrice;
            Array.Copy(Fleet, index + 1, Fleet, index, Fleet.Length - index - 1);
            Array.Resize(ref Fleet, Fleet.Length - 1);
        }
    }

    public void RentVehicle(Vehicle vehicle)
    {
        int index = Array.IndexOf(Fleet, vehicle);
        if (index != -1)
        {
            TotalRevenue += vehicle.RentalPrice;
            Array.Copy(Fleet, index + 1, Fleet, index, Fleet.Length - index - 1);
            Array.Resize(ref Fleet, Fleet.Length - 1);
            Console.WriteLine($"Vehicle {vehicle.Model} rented successfully.");
        }
        else
        {
            Console.WriteLine($"Vehicle {vehicle.Model} is not available for rent.");
        }
    }
}
