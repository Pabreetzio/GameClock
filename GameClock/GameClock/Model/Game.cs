using System.Collections.Generic;

namespace GameClock.Model
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPlayers { get; set; }
        public List<Player> Players { get; set; }
        public TimeControl TimeControl { get;set;}
    }
}
