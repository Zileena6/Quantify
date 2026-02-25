using Quantify.Models;

namespace Quantify.Services;

public class ProductService
{
    private static List<Product> _products =
    [
        new Product { Id = 1, ProductName = "Unicorn", Price = "555 kr" },
        new Product { Id = 2, ProductName = "Starfish", Price = "222 kr" },
        new Product { Id = 3, ProductName = "Moonkin", Price = "333 kr" }
    ];

    public IEnumerable<Product> GetProducts()
    {
        return _products;
    }
}
