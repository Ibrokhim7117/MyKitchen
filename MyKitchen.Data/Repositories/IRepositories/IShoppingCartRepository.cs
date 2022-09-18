using MyKitchen.Models;

namespace MyKitchen.DataAccess.Repositories.IRepositories
{
    public interface IShoppingCartRepository : IGenericRepository<ShoppingCart>
    {
        int IncrementCount(ShoppingCart shoppingCart, int count);
        int DecrementCount(ShoppingCart shoppingCart, int count);

    }
}
