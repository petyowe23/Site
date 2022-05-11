using Games;
using System.Text.Json;

namespace JsonFileGamesService
{

    public class JsonFileGameService
    {
        public JsonFileGameService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "game.json"); }
        }

        public IEnumerable<Game>? GetProducts()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {

                return JsonSerializer.Deserialize<Game[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

            }

        }
        public Game? GetProductByTitle(string title)
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {

                var games = JsonSerializer.Deserialize<List<Game>>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                foreach (var game in games)
                {
                    if (game.Title == title)
                    {
                        return game;
                    }

                }
                return null;
            }

        }
        public Game? GetProductByDescription(string description)
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                var games = JsonSerializer.Deserialize<List<Game>>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                foreach (var game in games)
                {
                    if (game.Description == description)
                    {
                        return game;
                    }

                }
                return null;

            }

        }
        public Game? GetProductByMaker(string maker)
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                var games = JsonSerializer.Deserialize<List<Game>>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                foreach (var game in games)
                {
                    if (game.Maker == maker)
                    {
                        return game;
                    }

                }
                return null;

            }

        }
        

    }
}
    