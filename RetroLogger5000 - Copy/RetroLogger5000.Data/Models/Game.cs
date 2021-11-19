using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroLogger5000.Data.Models
{

	/// <summary>
	/// Define game object properties 
	/// </summary>

	public class Game
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public int ReleaseYear { get; set; }
		public PlatformType Platform { get; set; }
		public string Publisher { get; set; }
		public string Developer { get; set; }
		public int Rank { get; set; }
	}
}
