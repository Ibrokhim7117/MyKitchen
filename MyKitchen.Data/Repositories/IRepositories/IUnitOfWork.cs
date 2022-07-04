using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKitchen.DataAccess.Repositories.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        ICategoryRepository Category { get; }   
        IFoodTypeRepository FoodType { get; }
        IMenuItemRepository MenuItem { get; }
    }
}
