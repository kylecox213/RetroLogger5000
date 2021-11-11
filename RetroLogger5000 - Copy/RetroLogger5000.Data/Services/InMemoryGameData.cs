using RetroLogger5000.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RetroLogger5000.Data.Services
{
	public class InMemoryGameData : IGameData
	{
		List<Game> _games;

		public InMemoryGameData()
		{
			_games = new List<Game>()
			{
				new Game { Id = 1, Title = "Star Soldier", ReleaseYear = 1986, Platform = PlatformType.NES, Publisher = "Hudson Soft", Developer = "Taxan", Rank = 9},
				new Game { Id = 2, Title = "Jackal", ReleaseYear = 1986, Platform = PlatformType.NES, Publisher = "Konami", Developer = "Konami", Rank = 10},
				new Game { Id = 3, Title = "ActRaiser", ReleaseYear = 1990, Platform = PlatformType.SNES, Publisher = "Enix", Developer = "Square Enix", Rank = 10}
			};
		}

		public IEnumerable<Game> GetAll()
		{
			return _games.OrderBy(g => g.Title);
		}
	}
}
