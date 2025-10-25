using WebApplication3.Ecommerce.Domain.Entities;

namespace WebApplication3.Ecommerce.Domain.Ports
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();
        Task<Product?> GetProductByIdAsync(int productId);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int productId);
    }
}
