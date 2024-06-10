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
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if(id != null && id !=0)
            {
                Category = _db.Categorie.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Categorie.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category edited successfully!";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
