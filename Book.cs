using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
	// Class representing a Book, inheriting from MediaItem
	public class Book : MediaItem
	{
		// Properties
		public string Author { get; set; }
		public int Pages { get; set; }

		// Constructor
		public Book(string title, string author, int pages)
		{
			Title = title;
			Author = author;
			Pages = pages;
		}

		// Override method to display book details
		public override void DisplayDetails()
		{
			Console.WriteLine($"Title: {Title}");
			Console.WriteLine($"Author: {Author}");
			Console.WriteLine($"Pages: {Pages}");
		}
	}

}
