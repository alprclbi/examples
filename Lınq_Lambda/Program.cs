using Lınq_Lambda;

var products = new List<Products> 
{
    new Products { Id = 1, Name = "Nike Air Zoom Pegasus", Price = 4200.00m },
    new Products { Id = 2, Name = "Adidas Ultraboost Light", Price = 6500.00m },
    new Products { Id = 3, Name = "UA Tech 2.0 Tişört", Price = 950.00m },
    new Products { Id = 4, Name = "Columbia Newton Ridge", Price = 3800.00m },
    new Products { Id = 5, Name = "TNF Stormbreak 2", Price = 7500.00m }
};


// LINQ
var product = from q in products where (q.Price > 3000m) select q;
foreach (var p in products)
{
    Console.WriteLine($"Linq >>>> {p.Name} - {p.Price}");
}

//LAMBDA
var lambdaproduct = products.Where(p => p.Price > 3000m).ToList();
lambdaproduct.ForEach(p => Console.WriteLine($"Lambda >>>> {p.Name} - {p.Price}"));
