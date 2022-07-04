using MyKitchen.DataAccess.Data;
using MyKitchen.DataAccess.Repositories.IRepositories;
using MyKitchen.Models;

namespace MyKitchen.DataAccess.Repositories
{
#pragma warning disable
    public class FoodTypeRepository : GenericRepository<FoodType>, IFoodTypeRepository
    {
        private readonly ApplicationDbContext _dbContext; 
        public FoodTypeRepository(ApplicationDbContext dbContext) : base(dbContext) 
        {
            _dbContext = dbContext;

        }
      

        public void Update(FoodType category)
        {
           var objFromDb = _dbContext.FoodType.FirstOrDefault(c => c.Id == category.Id);      
           objFromDb.Name = category.Name;
         

        }
    }
}
