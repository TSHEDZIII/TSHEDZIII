using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PART1.Pages
{
    public class GoodsINDEXModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public GoodsINDEXModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
