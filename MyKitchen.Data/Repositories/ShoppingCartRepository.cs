using MyKitchen.DataAccess.Data;
using MyKitchen.DataAccess.Repositories.IRepositories;
using MyKitchen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKitchen.DataAccess.Repositories
{
    public class ShoppingCartRepository : GenericRepository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }

      
    }
}
