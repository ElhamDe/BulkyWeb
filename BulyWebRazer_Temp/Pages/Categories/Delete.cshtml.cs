using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulyWebRazer_Temp.Data;
using BulyWebRazer_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulyWebRazer_Temp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Category = _db.Categorie.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            Category? obj = _db.Categorie.Find(Category.Id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categorie.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToPage("Index");
        }
    }
}
