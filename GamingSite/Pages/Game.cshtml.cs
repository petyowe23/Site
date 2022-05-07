using Games;
using JsonFileGamesService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamingSite.Pages
{
    public class GameModel : PageModel
    {
        public JsonFileGameService GameService;
        public Game? game { get; private set; }
        public GameModel(
           JsonFileGameService gamesService)
        {
           
            GameService = gamesService;
        }
        public void OnGet(string title)
        {
            game = GameService.GetProductByTitle(title);
        }
    }
}
