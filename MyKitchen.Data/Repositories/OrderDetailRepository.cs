using MyKitchen.DataAccess.Data;
using MyKitchen.DataAccess.Repositories.IRepositories;
using MyKitchen.Models;

namespace MyKitchen.DataAccess.Repositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetails>, IOrderDetailRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public OrderDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;

        }


        public void Update(OrderDetails orderDetails)
        {
            _dbContext.OrderDetails.Update(orderDetails);

        }
    }
}
