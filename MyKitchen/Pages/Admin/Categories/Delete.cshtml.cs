using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using MyKitchen.DataAccess;
using MyKitchen.DataAccess.Repositories.IRepositories;
using MyKitchen.Models;

namespace MyKitchen.Pages.Admin.Categories;

#pragma warning disable

[BindProperties]
public class DeleteModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public Category Category { get; set; }

    public DeleteModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;

    }
    public void OnGet(int id)
    {
        Category = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == id);
        //Category = _dbContext.Categories.FirstOrDefault(i => i.Id == id);
        //Category = _dbContext.Categories.SingleOrDefault(i => i.Id == id);
        //Category = _dbContext.Categories.Where(i => i.Id == id).FirstOrDefault();
    }

    public async Task<IActionResult> OnPost()
    {


        var categoryFromDb = _unitOfWork.Category.GetFirstOrDefault(u => u.Id == Category.Id);
        if (categoryFromDb != null)
        {
            _unitOfWork.Category.Remove(categoryFromDb);
            _unitOfWork.Save();
            TempData["Success"] = "Category deleted successfully";

            return RedirectToPage("Index");

        }



        return Page();
    }
}
