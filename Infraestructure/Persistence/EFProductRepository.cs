using Microsoft.EntityFrameworkCore;
using WebApplication3.Ecommerce.Domain.Entities;
using WebApplication3.Ecommerce.Domain.Ports;

namespace WebApplication3.Ecommerce.Infrastructure.Persistence
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ECommerceDbContext _context = null!;

        public EFProductRepository(ECommerceDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<Product>> GetProductsAsync() =>
            await _context.Products.ToListAsync();

        public async Task<Product?> GetProductByIdAsync(int productId) =>
            await _context.Products.FindAsync(productId);

        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
    }
}
