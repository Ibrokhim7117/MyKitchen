using MyKitchen.Models;

namespace MyKitchen.DataAccess.Repositories.IRepositories
{
    public interface IFoodTypeRepository : IGenericRepository<FoodType>
    {
        void Update(FoodType category);

    }
}
