using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.Models
{
    public class Market
    {
        private Game[] _allGames;

        private Market()
        {
            _allGames = new Game[0];
        }
        public void AddGame(Game game)
        {
            Array.Resize(ref _allGames, _allGames.Length + 1);
            _allGames[^1] = game;
        }
    }
}
