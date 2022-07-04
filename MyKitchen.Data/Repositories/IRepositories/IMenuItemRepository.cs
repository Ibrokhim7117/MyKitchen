using MyKitchen.Models;

namespace MyKitchen.DataAccess.Repositories.IRepositories
{
    public interface IMenuItemRepository : IGenericRepository<MenuItem>
    {
        void Update(MenuItem obj);
    }
}
