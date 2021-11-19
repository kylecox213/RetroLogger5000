using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroLogger5000.Data.Models
{

	/// <summary>
	/// Define platform names to restrict selection to type PlatformType
	/// </summary>
	
	public enum PlatformType
	{
		None,
		NES,
		SNES,
		SNES_JV,
		Sega,
		N64,
		Playstation,
		XBox,
		Switch
	}
}
