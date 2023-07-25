using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Packt.Shared;

 
namespace Northwind.Web.Pages
{
    public class SupplierModel : PageModel
    {
        [BindProperty]
        public Supplier? Suppliers { get; set; }

        private NorthwindContext db;

        public SupplierModel(NorthwindContext injectedContext)
        {
            this.db = injectedContext;
        }

        public IEnumerable<Supplier>? Supplier { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind B2B - Suppliers";

            Supplier = db.Suppliers.OrderBy(s => s.Country).ThenBy(c => c.SupplierName);
        }

        public IActionResult OnPost()
        {
            if ((Suppliers is not null) && ModelState.IsValid) 
            {
                db.Suppliers.Add(Suppliers);
                db.SaveChanges();
                return RedirectToPage("/Supplier");
            }
            else
            {
                return Page();
            }
        }
    }
}
