using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorOduncTakip.Data;
using RazorOduncTakip.Model;


namespace RazorOduncTakip.Pages.OduncTakip
{
    public class ReturnModel : PageModel
    {
        //[BindProperty(SupportsGet = true)]
        //public int Id { get; set; }

        [BindProperty]
        public OduncIslem OduncIslem { get; set; }

        private readonly OduncDbContext db;
        public ReturnModel(OduncDbContext db)
        {
            this.db = db;
        }
        public void OnGet(int id)
        {
            OduncIslem = db.OduncIslemler.Find(id);
        }

        public IActionResult OnPost()
        {
            // iþ kuralý iade tarihi veriliþ tarihinden önce olamaz
            if (OduncIslem.DateReturn is not null  &&
                DateTime.Compare(OduncIslem.DateGive, (DateTime)OduncIslem.DateReturn) > 0)
            {
                ModelState.AddModelError("@OduncIslem.DateReturn", "iade tarihi veriliþ tarihinden önce olamaz");
            }
            // model valid?
            if (ModelState.IsValid)
            {
                db.OduncIslemler.Update(OduncIslem);
                db.SaveChanges();
                return RedirectToPage("index");
            }

            return Page();

        }

    }
}
