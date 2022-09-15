using MyKitchen.DataAccess.Data;
using MyKitchen.DataAccess.Repositories.IRepositories;

namespace MyKitchen.DataAccess.Repositories
{
#pragma warning disable
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Category = new CategoryRepository(_dbContext);
            FoodType = new FoodTypeRepository(_dbContext);
            MenuItem = new MenuItemRepository(_dbContext);
            ApplicationUser = new ApplicationUserRepository(_dbContext);
            ShoppingCart = new ShoppingCartRepository(_dbContext);  
        }
        public ICategoryRepository Category { get; private set; }
        public IFoodTypeRepository FoodType { get; private set; }
        public IMenuItemRepository MenuItem { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; private set; } 
        public void Dispose()
        {
            _dbContext.Dispose();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
