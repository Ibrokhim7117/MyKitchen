using MyKitchen.DataAccess.Data;
using MyKitchen.DataAccess.Repositories.IRepositories;
using MyKitchen.Models;

namespace MyKitchen.DataAccess.Repositories
{
    public class OrderHeaderRepository : GenericRepository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.OrderHeader.Update(obj);
        }

        public void UpdateStatus(int id, string status)
        {
            var orderFromDb = _db.OrderHeader.FirstOrDefault(u => u.Id == id);
            if (orderFromDb != null)
            {
                orderFromDb.Status = status;
            }
        }
    }
}
