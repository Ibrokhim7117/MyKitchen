using MyKitchen.Models;

namespace MyKitchen.DataAccess.Repositories.IRepositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        void Update(Category category);

    }
}
