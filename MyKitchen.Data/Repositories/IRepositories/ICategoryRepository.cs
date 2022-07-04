using MyKitchen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKitchen.DataAccess.Repositories.IRepositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        void Update(Category category);
       
    }
}
