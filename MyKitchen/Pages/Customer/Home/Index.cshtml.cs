using Microsoft.AspNetCore.Mvc.RazorPages;
using MyKitchen.DataAccess.Repositories.IRepositories;
using MyKitchen.Models;

namespace MyKitchen.Pages.Customer.Home
{
#pragma warning disable
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<MenuItem> MenuItemList { get; set; }
        public IEnumerable<Category> CategoryList { get; set; }

        public void OnGet()
        {
            MenuItemList = _unitOfWork.MenuItem.GetAll(includeProperties: "Category,FoodType");
            CategoryList = _unitOfWork.Category.GetAll(orderby: u => u.OrderBy(c => c.DisplayOrder));
        }
    }
}
