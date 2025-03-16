// Input
Dictionary<string, double[]> products = new Dictionary<string, double[]>();
string[] input = new string[] { };
string productName = "";
double price = 0.0;
int quantity = 0;
// Logic
while (true)
{
    input = Console.ReadLine()
                        .Split()
                        .ToArray();
    productName = input[0];
    if (productName == "buy")
    {
        break;
    }
    price = double.Parse(input[1]);
    quantity = int.Parse(input[2]);
    if (products.ContainsKey(input[0]))
    {
        double newQuantity = products[productName][1] + quantity;
        products[productName] = new double[] { price, newQuantity };

    }
    else
    {
        products.Add(input[0], new double[] { price, quantity });
    }
}
// Calculation & Output 
foreach (var item in products)
{
    double totalPrice = item.Value[0] * item.Value[1];
    Console.WriteLine($"{item.Key} -> {totalPrice:F2}");
}
