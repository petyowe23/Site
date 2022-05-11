using Games;
using JsonFileGamesService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamingSite.Pages
{
   
    
        public class IndexModel : PageModel
        {
            private readonly ILogger<IndexModel> _logger;
            public JsonFileGameService GameService;
            public IEnumerable<Game>? games { get; private set; }




            public IndexModel(ILogger<IndexModel> logger,
               JsonFileGameService gamesService)
            {
                _logger = logger;
                GameService = gamesService;
            }

            public void OnGet()
            {
                games = GameService.GetProducts();
            }
        }
    
}