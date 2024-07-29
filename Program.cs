using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Polymorphism
			MediaItem[] mediaItems = new MediaItem[2];
			mediaItems[0] = new Movie("Inception", Genre.SciFi, 2010);
			mediaItems[1] = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);

			// Displaying all items in the library
			foreach (var item in mediaItems)
			{
				item.DisplayDetails();
				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}
