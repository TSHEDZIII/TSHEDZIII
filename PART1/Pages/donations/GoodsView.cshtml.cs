using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PART1.DATA;
using PART1.MODELS;

namespace PART1.Pages.donations
{
    public class GoodsViewModel : PageModel
    {
        private readonly PART1.DATA.PART1Context _context;

        public GoodsViewModel(PART1.DATA.PART1Context context)
        {
            _context = context;
        }

        public IList<GoodsClass> GoodsClass { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.GoodsClass != null)
            {
                GoodsClass = await _context.GoodsClass.ToListAsync();
            }
        }
    }
}
