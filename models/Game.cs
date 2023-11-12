//Purpose to hold the Game class
using System;

namespace models
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string BackgroundImage { get; set; } 

        public Game (int gameId, string gameName, string backgroundImage)
        {
            GameId = gameId;
            GameName = gameName;
            BackgroundImage = backgroundImage;
        }
    }
}