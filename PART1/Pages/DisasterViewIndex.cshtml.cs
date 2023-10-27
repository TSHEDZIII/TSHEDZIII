using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PART1.Pages
{
    public class DisasterViewIndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;

        public DisasterViewIndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
