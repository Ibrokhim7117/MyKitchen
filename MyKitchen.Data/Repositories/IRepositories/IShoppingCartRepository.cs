using MyKitchen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKitchen.DataAccess.Repositories.IRepositories
{
    public interface IShoppingCartRepository : IGenericRepository<ShoppingCart> 
    {
        int IncrementCount(ShoppingCart  shoppingCart, int count);
        int DecrementCount(ShoppingCart shoppingCart, int count);
       
    }
}
