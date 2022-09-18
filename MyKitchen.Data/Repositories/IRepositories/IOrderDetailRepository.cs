using MyKitchen.Models;

namespace MyKitchen.DataAccess.Repositories.IRepositories
{
    public interface IOrderDetailRepository : IGenericRepository<OrderDetails>
    {
        void Update(OrderDetails order);
    }
}
