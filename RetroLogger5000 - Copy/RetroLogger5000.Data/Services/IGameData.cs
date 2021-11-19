using RetroLogger5000.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroLogger5000.Data.Services
{
	/// <summary>
	/// interface that will return all of type Game
	/// </summary>
	
	public interface IGameData
	{
		IEnumerable<Game> GetAll();
	}
}
