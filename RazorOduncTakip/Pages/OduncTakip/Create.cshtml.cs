using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorOduncTakip.Model;
using RazorOduncTakip.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorOduncTakip.Pages.OduncTakip
{
    public class CreateModel : PageModel
    {
        public List<SelectListItem> Items { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value= "Bilgisayar", Text="Bilgisayar" },
            new SelectListItem { Value= "Video Kamera", Text="Video Kamera" },
            new SelectListItem { Value= "Kitap 101", Text="Kitap 101" }
        };

        private readonly OduncDbContext db;

        [BindProperty]
        public OduncIslem OduncIslem { get; set; }

        public CreateModel(OduncDbContext db)
        {
            this.db = db;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            // Ýþ mantýðý olarak uygun olmasý için 
            //if(!string.IsNullOrEmpty(OduncIslem.Name) && OduncIslem.Name.Contains("a"))
            //{
            //    ModelState.AddModelError("OduncIslem.Name", "a harfi kabul edilmez");
            //}

            // validation
            if (ModelState.IsValid)
            {
                db.OduncIslemler.Add(OduncIslem);
                db.SaveChanges();
                return RedirectToPage("Index");
            }

            return Page();
        }


    }
}
