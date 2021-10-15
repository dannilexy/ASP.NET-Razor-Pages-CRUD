using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public DeleteModel(ApplicationDbContext _db)
        {
            this._db = _db;
        }
        public Category Category { get; set; }
        public void OnGet(int id)
        {
            Category = _db.Category.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<IActionResult> OnPost()
        {
            _db.Remove(Category);
            await _db.SaveChangesAsync();
            TempData["success"] = "Category Deleted Successfully";
            return RedirectToPage("Index");

        }
    }
}
