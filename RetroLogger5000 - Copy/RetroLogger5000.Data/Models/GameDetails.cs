using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroLogger5000.Data.Models
{
	public abstract class GameDetails
	{
		public bool IsBeaten { get; set; }
		public bool IsClean { get; set; }
		public bool IsTested { get; set; }
		public bool IsComplete { get; set; }
		public bool IsDuplicate { get; set; }
		public bool OnWishList { get; set; }
		public bool IsVirtual { get; set; }
	}
}
