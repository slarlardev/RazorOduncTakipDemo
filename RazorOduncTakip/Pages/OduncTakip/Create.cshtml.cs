using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorOduncTakip.Model;

namespace RazorOduncTakip.Pages.OduncTakip
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public OduncIslem OduncIslem { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("Index");
        }


    }
}
