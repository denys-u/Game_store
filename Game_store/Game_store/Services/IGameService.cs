using Game_store.Entyties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game_store.Services
{
    public interface IGameService
    {
        IReadOnlyCollection<Game> GetGames();

        void Add(Game game, SystemRequirements requirements);

        void Delete(Game game, SystemRequirements requirements);


    }
}
