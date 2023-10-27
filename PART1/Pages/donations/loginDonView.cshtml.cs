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
    public class loginDonViewModel : PageModel
    {
        private readonly PART1.DATA.PART1Context _context;

        public loginDonViewModel(PART1.DATA.PART1Context context)
        {
            _context = context;
        }

        public IList<LOGIN> LOGIN { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.LOGIN != null)
            {
                LOGIN = await _context.LOGIN.ToListAsync();
            }
        }
    }
}
