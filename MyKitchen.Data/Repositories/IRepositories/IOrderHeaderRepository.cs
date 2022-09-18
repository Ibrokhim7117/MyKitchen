using MyKitchen.Models;

namespace MyKitchen.DataAccess.Repositories.IRepositories
{
    public interface IOrderHeaderRepository : IGenericRepository<OrderHeader>
    {
        void Update(OrderHeader orderHeader);
    }
}
