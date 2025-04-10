using BlazorCleanArchitecture.Domain.Models;
using BlazorCleanArchitecture.Domain.Interfaces;
using BlazorCleanArchitecture.Infrastructure.Data;

namespace BlazorCleanArchitecture.Infrastructure.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public void RemoveProduct(int id)
        {
            Product? entity = _context.Products.Find(id);
            if (entity != null)
            {
                _context.Products.Remove(entity);
                _context.SaveChanges();
            }
        }

        public void UpdateProduct(int id, Product updated)
        {
            var entity = _context.Products.Find(id);
            if (entity != null)
            {
                entity.Price = updated.Price;
                entity.Description = updated.Description;
                entity.Name = updated.Name;
                entity.ImageUrl = updated.ImageUrl;
                _context.SaveChanges();
            }
        }
    }
}
