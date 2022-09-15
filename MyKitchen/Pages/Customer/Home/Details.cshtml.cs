using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyKitchen.DataAccess.Repositories.IRepositories;
using MyKitchen.Models;
using System.ComponentModel.DataAnnotations;

namespace MyKitchen.Pages.Customer.Home
{
#pragma warning disable
    public class DetailsModel : PageModel
    {
        public readonly IUnitOfWork _unitOfWork;

        public DetailsModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        [BindProperty]
        public ShoppingCart ShoppingCart { get; set; }

        public void OnGet(int id)
        {
            ShoppingCart = new()
            {

                MenuItem = _unitOfWork.MenuItem.GetFirstOrDefault(u => u.Id == id, includeProperties: "Category,FoodType")
            };
        }

    }
}

