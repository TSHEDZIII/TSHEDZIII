using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PART1.Pages
{
    public class REGIndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public REGIndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
