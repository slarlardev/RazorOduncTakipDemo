using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorOduncTakip.Data;
using RazorOduncTakip.Model;

namespace RazorOduncTakip.Pages.OduncTakip
{
    public class IndexModel : PageModel
    {
        public IEnumerable<OduncIslem> OduncIslemler { get; set; }
        private readonly OduncDbContext _db;
        public IndexModel(OduncDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            OduncIslemler = _db.OduncIslemler;
        }
    }
}
