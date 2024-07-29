using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
	// Class representing a Library
	public class Library
	{
		// Property
		private MediaItem[] items;

		// Indexer
		public MediaItem this[int index]
		{
			get { return items[index]; }
			set { items[index] = value; }
		}

		// Constructor
		public Library(int size)
		{
			items = new MediaItem[size];
		}

		// Method to display all items in the library
		public void DisplayItems()
		{
			Console.WriteLine("Library Items:");
			foreach (var item in items)
			{
				item.DisplayDetails();
				Console.WriteLine();
			}
		}
	}
}
