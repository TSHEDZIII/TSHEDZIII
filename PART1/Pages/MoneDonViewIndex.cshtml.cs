using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PART1.Pages
{
    public class MoneDonViewIndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;

        public MoneDonViewIndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
