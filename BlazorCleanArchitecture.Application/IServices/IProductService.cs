using BlazorCleanArchitecture.Domain.Models;

namespace BlazorCleanArchitecture.Application.IServices
{
    public interface IProductService
    {
        public List<Product> GetProducts();
        public void AddProduct(Product product);
        public void RemoveProduct(int id);
        public void UpdateProduct(int id, Product product);
    }
}
