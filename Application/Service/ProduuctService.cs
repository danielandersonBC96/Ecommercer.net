using WebApplication3.Ecommerce.Domain.Entities;
using WebApplication3.Ecommerce.Domain.Ports;

namespace WebApplication3.Ecommerce.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public Task<List<Product>> GetProducts() => _repository.GetProductsAsync();
        public Task<Product?> GetProductById(int id) => _repository.GetProductByIdAsync(id);
        public Task AddProduct(Product product) => _repository.AddAsync(product);
        public Task UpdateProduct(Product product) => _repository.UpdateAsync(product);
        public Task DeleteProduct(int id) => _repository.DeleteAsync(id);
    }
}
