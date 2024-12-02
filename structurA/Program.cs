using System;

struct Product
{
    public int Quantity;
    public double Price;
    public int Year;
    public string Manufacturer;
    public void DisplayInfo()
    {
        Console.WriteLine($"Количество: {Quantity}, Цена: {Price:C}, Год изготовления: {Year}, Производитель: {Manufacturer}");
    }
}

class Program
{
    static void Main()
    {    
        Product[] products = new Product[]
        {
            new Product { Quantity = 10, Price = 29999, Year = 2005, Manufacturer = "Производитель A" },
            new Product { Quantity = 5, Price = 49999, Year = 2022, Manufacturer = "Производитель B" },
            new Product { Quantity = 3, Price = 19999, Year = 2015, Manufacturer = "Производитель C" },
            new Product { Quantity = 7, Price = 79999, Year = 2024, Manufacturer = "Производитель D" },
            new Product { Quantity = 2, Price = 59999, Year = 2017, Manufacturer = "Производитель E" }
        };
        Product mostExpensiveProduct = products[0];
        foreach (var product in products)
        {
            if (product.Price > mostExpensiveProduct.Price)
            {
                mostExpensiveProduct = product;
            }
        }
        Console.WriteLine("Самый дорогой товар на складе:");
        mostExpensiveProduct.DisplayInfo();
    }
}
