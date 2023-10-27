using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PART1.Pages
{
    public class MONEYALLOINDEXModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public MONEYALLOINDEXModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
