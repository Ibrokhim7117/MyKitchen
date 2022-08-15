namespace MyKitchen.DataAccess.Repositories.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        ICategoryRepository Category { get; }
        IFoodTypeRepository FoodType { get; }
        IMenuItemRepository MenuItem { get; }
        IApplicationUserRepository ApplicationUser { get; }
    }
}
