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
    public class IndexModel : PageModel
    {
       public IEnumerable<Category> Categories { get; set; }

        private readonly ApplicationDbContext _dbContext;

       
        public IndexModel(ApplicationDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        public void OnGet()
        {
            Categories = _dbContext.Category;
        }
    }
}
