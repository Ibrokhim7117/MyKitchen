using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyKitchen.DataAccess.Repositories.IRepositories;
using MyKitchen.Models;

namespace MyKitchen.Pages.Admin.FoodTypes;

#pragma warning disable

[BindProperties]
public class DeleteModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public FoodType FoodType { get; set; }

    public DeleteModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;

    }
    public void OnGet(int id)
    {
        FoodType = _unitOfWork.FoodType.GetFirstOrDefault(u => u.Id == id);
        //Category = _dbContext.Categories.FirstOrDefault(i => i.Id == id);
        //Category = _dbContext.Categories.SingleOrDefault(i => i.Id == id);
        //Category = _dbContext.Categories.Where(i => i.Id == id).FirstOrDefault();
    }

    public async Task<IActionResult> OnPost()
    {


        var foodTypeFromDb = _unitOfWork.FoodType.GetFirstOrDefault(u => u.Id == FoodType.Id);
        if (foodTypeFromDb != null)
        {
            _unitOfWork.FoodType.Remove(foodTypeFromDb);
            _unitOfWork.Save();
            TempData["Success"] = "FoodType deleted successfully";

            return RedirectToPage("Index");

        }



        return Page();
    }
}
