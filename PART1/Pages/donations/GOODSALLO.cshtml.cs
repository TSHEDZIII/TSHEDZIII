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
    public class GOODSALLOModel : PageModel
    {
        private readonly PART1.DATA.PART1Context _context;

        public GOODSALLOModel(PART1.DATA.PART1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public GOODSALLOCATION GOODSALLOCATION { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.GOODSALLOCATION == null || GOODSALLOCATION == null)
            {
                return Page();
            }

            _context.GOODSALLOCATION.Add(GOODSALLOCATION);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
