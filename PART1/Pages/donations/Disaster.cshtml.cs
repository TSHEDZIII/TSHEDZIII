using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PART1.DATA;
using PART1.MODELS;

namespace PART1.Pages.donations
{
    public class DisasterModel : PageModel
    {
        private readonly PART1.DATA.PART1Context _context;

        public DisasterModel(PART1.DATA.PART1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DISASTER DISASTER { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.DISASTER == null || DISASTER == null)
            {
                return Page();
            }

            _context.DISASTER.Add(DISASTER);
            await _context.SaveChangesAsync();

            return RedirectToPage("./DisasterIndex");
        }
    }
}
