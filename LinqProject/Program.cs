internal class Program
{
    private static void Main(string[] args)
    {
        // LINQ --> LANGUAGE INTEGRATED QUERY

        List<Category> categories = new List<Category>
        {
            new Category{ CategoryId = 1, CategoryName = "Bilgisayar"},
            new Category{ CategoryId = 2, CategoryName = "Telefon"}
        };

        List<Product> products = new List<Product>
        {
        new Product { ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitsInStock = 5},
        new Product { ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "16 GB Ram", UnitPrice = 8000, UnitsInStock = 3},
        new Product { ProductId = 3, CategoryId = 1, ProductName = "Monster Laptop", QuantityPerUnit = "8 GB Ram", UnitPrice = 6000, UnitsInStock = 2},
        new Product { ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 5000, UnitsInStock = 15},
        new Product { ProductId = 5, CategoryId = 2, ProductName = "Apple Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 8000, UnitsInStock = 0},

        };

        Console.WriteLine("Algoritmik-------------------------------");

        foreach (var product in products)
        {
            if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
            {
                Console.WriteLine(product.ProductName);
            }

        }

        Console.WriteLine("Linq---------------------------------------");

        var result = products.Where(p=> p.UnitPrice > 5000 && p.UnitsInStock > 3);

        foreach (var p in result)
        {
            Console.WriteLine(p.ProductName);
        }

        // buradaki p --> arka tarafta products 'ın içerisindeki her bir ürünü temsil eden bir iterasyon
        // tıpkı foreach'teki product in products derken kullandığımız "product" gibi.
        // p yerine istersek product da yazabiliriz kısaca, ama genelde temsil eden ilk harf yazılır.

        Console.WriteLine("METOTLA YAPTIĞIMIZDA ----------------------");

        
        foreach (var product in GetProductsLinq(products))
        {
            Console.WriteLine(product.ProductName);
        }
       

    }

    // linq olmasaydı aşağıdaki gibi kod yazacaktık

    static List<Product> GetProducts()
    {

        List<Product> filteredProducts = new List<Product>();

        foreach (var product in filteredProducts)
        {
            if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
            {
                filteredProducts.Add(product);
            }

        }

        return filteredProducts;
    }

    // Linq'le yazdığımız metot ise aşağıdaki gibidir
    static List<Product> GetProductsLinq (List<Product> products)
    {
        return  products.Where(p=>p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();

        // sonuç bir array getireceği için sonuna listeye çevirmesi için .ToList() yazıyoruz.
    }

}

class Product
{
    public int ProductId { get; set; }

    public int CategoryId { get; set; }

    public string ProductName { get; set; }

    public string QuantityPerUnit { get; set; }

    public int UnitPrice { get; set; }

    public int UnitsInStock { get; set; }
}

class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; }
}