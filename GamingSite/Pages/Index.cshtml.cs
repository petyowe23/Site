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
        public IEnumerable<Game> games { get; private set; }



#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public IndexModel(ILogger<IndexModel> logger,
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
           JsonFileGameService gamesService)
        {
            _logger = logger;
            GameService = gamesService;
        }

        public void OnGet()
        {
            games = (IEnumerable<Game>)GameService.GetProducts();
        }
    }
}