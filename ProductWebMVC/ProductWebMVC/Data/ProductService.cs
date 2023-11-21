using ProductWebMVC.Models;

namespace ProductWebMVC.Data
{
    public class ProductService : IProductService
    {
        ProductContext ctx;
        public ProductService(ProductContext context)
        {
            ctx = context;
        }

        public int? AddProduct(Product p)
        {
            var product = this.GetProductById(p.Id);
            if (product != null)
            {
                return null;
            }
            ctx.Products.Add(p);
            return ctx.SaveChanges();
        }

        private object GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        List<Product> IProductService.GetAllProducts()
        {
            return ctx.Products.ToList();
        }

        Product IProductService.GetProductById(int Id)
        {
            return ctx.Products.FirstOrDefault(x => x.Id == Id);
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public int? UpdateProduct(Product p)
        {
            ctx.Products.Update(p);
            return ctx.SaveChanges();
        }

        public object GetAllProductsById(int id)
        {
            throw new NotImplementedException();
        }

        public int? RemoveProductsById(int id)
        {
            var product = this.GetProductById(id);
            if (product == null)
            {
                return null;
            }
            ctx.Products.Remove(product);
            return ctx.SaveChanges();
        }
    }
}
