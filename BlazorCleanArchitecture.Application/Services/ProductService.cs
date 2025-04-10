using BlazorCleanArchitecture.Application.IServices;
using BlazorCleanArchitecture.Domain.Interfaces;
using BlazorCleanArchitecture.Domain.Models;

namespace BlazorCleanArchitecture.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public List<Product> GetProducts()
        {
            return _repo.GetAllProducts();
        }

        public void AddProduct(Product product) 
        {
            _repo.AddProduct(product);
        }

        public void RemoveProduct(int id)
        { _repo.RemoveProduct(id); }

        public void UpdateProduct(int id, Product product)
        {  _repo.UpdateProduct(id, product); }
    }
}
