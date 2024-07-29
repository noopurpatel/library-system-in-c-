using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
	// Abstract class representing a MediaItem
	public abstract class MediaItem
	{
		// Property
		public string Title { get; set; }

		// Abstract method to display details
		public abstract void DisplayDetails();
	}

}
