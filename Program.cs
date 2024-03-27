public class Assignment03
{
    static void Main(string[] args)
    {
        Car car1 = new Car("GLS", "Mercedes", 2019, 150, 4, "Petrol", "Automatic", true);
        Truck truck1 = new Truck("Canyon", "GMC", 2017, 250, 2, "Pickup", false);
        Motorcycle bike1 = new Motorcycle("ZX-4R", "Kawasaki", 2021, 100, 2000, "Petrol", false);

        Console.WriteLine("Details of car:");
        car1.DisplayDetails();

        Console.WriteLine("\nDetails of Truck:");
        truck1.DisplayDetails();

        Console.WriteLine("\nDetails of motorcycle:");
        bike1.DisplayDetails();

        // displaying total revenue
        double totalRevenue = car1.RentalPrice + truck1.RentalPrice + bike1.RentalPrice;
        Console.WriteLine($"\nTotal Revenue of vehicle is: ${totalRevenue:f2}");
    }
}
