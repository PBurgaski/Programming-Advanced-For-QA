namespace _03.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            string[] input;
            List<Box> boxes = new List<Box>();
            int serialNumber;
            string itemName;
            int itemQuantity;
            double itemPrice;
            // Logic
            while (true)
            {
                input = Console.ReadLine()
                               .Split()
                               .ToArray();
                if (input[0] == "end")
                {
                    break;
                }
                serialNumber = int.Parse(input[0]);
                itemName = input[1];
                itemQuantity = int.Parse(input[2]);
                itemPrice = double.Parse(input[3]);
                Item curretItem = new Item(itemName, itemPrice);
                Box curretBox = new Box(serialNumber, curretItem, itemQuantity);
                boxes.Add(curretBox);
            }
            // Output
            foreach (var box in boxes.OrderByDescending(b => b.PriceForBox))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
        }
    }
}
public class Item
{
    public Item(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }
    public double Price { get; set; }
}

public class Box
{
    public Box(int serialNumber, Item item, int itemQuantity)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = itemQuantity;
        PriceForBox = item.Price * itemQuantity; 
    }

    public int SerialNumber { get; set; }
    public Item Item { get; set; }  
    public int ItemQuantity { get; set; }
    public double PriceForBox { get; set; }
}
