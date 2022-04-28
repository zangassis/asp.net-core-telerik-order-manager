using OrderManager.Data;
using OrderManager.Models;

namespace OrderManager.Services
{
    public class OrderService
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<OrderViewModel> Read() => GetAll();

        public IList<OrderViewModel> GetAll() => _dbContext.Orders.ToList();
    }
}
