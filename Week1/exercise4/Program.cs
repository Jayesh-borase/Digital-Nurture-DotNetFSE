using System;

class Product
{
    public int productId;
    public string productName;
    public string category;

    public Product(int id, string name, string category)
    {
        this.productId = id;
        this.productName = name;
        this.category = category;
    }
}

class Program
{
    static Product LinearSearch(Product[] products, int id)
    {
        foreach (Product p in products)
        {
            if (p.productId == id)
                return p;
        }

        return null;
    }

    static Product BinarySearch(Product[] products, int id)
    {
        int low = 0;
        int high = products.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (products[mid].productId == id)
                return products[mid];

            if (products[mid].productId < id)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Product[] products =
        {
            new Product(101,"Laptop","Electronics"),
            new Product(102,"Phone","Electronics"),
            new Product(103,"Shoes","Fashion"),
            new Product(104,"Watch","Accessories"),
            new Product(105,"Bag","Fashion")
        };

        Console.WriteLine("Linear Search:");

        Product result1 = LinearSearch(products, 104);

        if (result1 != null)
            Console.WriteLine(result1.productName);

        Console.WriteLine();

        Console.WriteLine("Binary Search:");

        Product result2 = BinarySearch(products, 104);

        if (result2 != null)
            Console.WriteLine(result2.productName);
    }
}
