using System.Runtime.InteropServices;

namespace _04.VehicleCatalogue
{
    public class Cars
    {
        public Cars(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Trucks
    {
        public Trucks(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    public class Catalogue
    {
        public Catalogue()
        {
            Cars = new List<Cars>();
            Trucks = new List<Trucks>();
        }

        public List<Cars> Cars { get; set; }
        public List<Trucks> Trucks { get; set; }

        public void AddCar(Cars car)
        {
            Cars.Add(car);
        }

        public void AddTruck(Trucks truck)
        {
            Trucks.Add(truck);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Catalogue catalogue = new Catalogue();

            // Logic
            while (true)
            {
                string[] input = Console.ReadLine().Split('/');
                if (input[0] == "end")
                {
                    break;
                }
                string type = input[0];
                string brand = input[1];
                string model = input[2];
                int hpOrWeight = int.Parse(input[3]);
                if (type == "Car")
                {
                    Cars currentCar = new Cars(brand, model, hpOrWeight);
                    catalogue.AddCar(currentCar);
                }
                else
                {
                    Trucks currentTruck = new Trucks(brand, model, hpOrWeight);
                    catalogue.AddTruck(currentTruck);
                }
            }
            // Output
            if (catalogue.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var cars in catalogue.Cars.OrderBy(c => c.Brand).ToList())
                {
                    Console.WriteLine($"{cars.Brand}: {cars.Model} - {cars.HorsePower}hp");
                }
            }
            if (catalogue.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var trucks in catalogue.Trucks.OrderBy(c => c.Brand).ToList())
                {
                    Console.WriteLine($"{trucks.Brand}: {trucks.Model} - {trucks.Weight}kg");
                }
            }
        }
    }
}
