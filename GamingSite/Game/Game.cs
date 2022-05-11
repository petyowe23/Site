using System.Text.Json;
using System.Text.Json.Serialization;

namespace Games
{
    public class Game
    {
      
        public string? Maker { get; set; }

        public List<string>? Images { get; set; }
        public string? Url { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int[]? Ratings { get; set; }
        


        public override string ToString() => JsonSerializer.Serialize<Game>(this);
        
    }
}
