using RetroLogger5000.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RetroLogger5000.Data.Services
{

	/// <summary>
	/// Create in-memory data of type Game; 
	/// </summary>
	public class InMemoryGameData : IGameData
	{
		List<Game> _games;

		//constructor 
		public InMemoryGameData()
		{
			_games = new List<Game>()
			{
				new Game { Id = 1, Title = "Star Soldier", ReleaseYear = 1986, Platform = PlatformType.NES, Publisher = "Hudson Soft", Developer = "Taxan", Rank = 9},
				new Game { Id = 2, Title = "Jackal", ReleaseYear = 1986, Platform = PlatformType.NES, Publisher = "Konami", Developer = "Konami", Rank = 10},
				new Game { Id = 3, Title = "ActRaiser", ReleaseYear = 1990, Platform = PlatformType.SNES, Publisher = "Enix", Developer = "Square Enix", Rank = 10}
			};
		}

		public void Add(Game game)
		{
			_games.Add(game);
			game.Id = _games.Max(g => g.Id) + 1;
		}


		public Game Get(int id)
		{
			return _games.FirstOrDefault(g => g.Id == id);
		}

		// implement GetAll() derived from IGameData
		public IEnumerable<Game> GetAll()
		{
			return _games.OrderBy(g => g.Title);
		}
	}
}
