using RetroLogger5000.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroLogger5000.Data.Services
{
	public interface IGameData
	{
		IEnumerable<Game> GetAll();
	}
}
