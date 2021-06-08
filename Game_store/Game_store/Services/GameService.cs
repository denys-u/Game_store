using Game_store.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game_store.Services
{
    public class GameService : IGameService
    {
        private readonly List<Game> _games = new List<Game>();
        private int _id = 1;

        public IReadOnlyCollection<Game> GetGames()
        {
            return _games;
        }

        public void Add (Game game, SystemRequirements requirements)
        {
            var entity = new Game
            {
                Id = _id++,
                Name = game.Name,
                Price = game.Price,
                Rating = game.Rating,
                Genre = game.Genre,
                Developer = game.Developer,
                Release = game.Release,

                MinSystemRequirements = new SystemRequirements()
                {
                   Processor = requirements.Processor,
                   Memory = requirements.Memory,
                   Graphics = requirements.Graphics
                },
                RecommendedSystemRequirements = new SystemRequirements()
                {
                    Processor = requirements.Processor,
                    Memory = requirements.Memory,
                    Graphics = requirements.Graphics
                }
            };
            _games.Add(game);
        }

        public void Delete (Game game, SystemRequirements requirements)
        {
            _games.Remove(game);
        }

        public Game Get(int id)
        {
            return _games.FirstOrDefault(x => x.Id == id);
        }
    }
}
