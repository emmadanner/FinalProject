using ProductWebMVC.Models;

namespace ProductWebMVC.Data
{
    public interface IProductService
    {
        int? AddProduct(Product p);
        List<Product> GetAllProducts(Product p);
        List<Product> GetAllProducts();
        object GetAllProductsById(int id);
        Product GetProductById(int Id);
        int? RemoveProductsById(int id);
        int? UpdateProduct(Product p);
    }
}
