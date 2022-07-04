using Microsoft.AspNetCore.Mvc.RazorPages;
using MyKitchen.DataAccess.Data;
using MyKitchen.Models;

namespace MyKitchen.Pages.Admin.FoodTypes
{
#pragma warning disable
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public IEnumerable<FoodType> FoodTypes { get; set; }
        public IndexModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public void OnGet()
        {
            FoodTypes = _dbContext.FoodType;
        }
    }
}
