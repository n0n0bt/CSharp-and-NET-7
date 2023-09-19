using Microsoft.AspNetCore.Mvc.RazorPages;
using Ogani.Data;

namespace Ogani.Views.Shared
{
    public class _HeroSectionPartial : PageModel
    {
        private readonly ApplicationDbContext _context;
        public _HeroSectionPartial(ApplicationDbContext context)
        {

            _context = context;

        }
    }
}
