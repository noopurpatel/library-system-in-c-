using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
	// Class representing a Movie, inheriting from MediaItem
	public class Movie : MediaItem
	{
		// Properties
		public Genre Genre { get; set; }
		public int ReleaseYear { get; set; }

		// Constructor
		public Movie(string title, Genre genre, int releaseYear)
		{
			Title = title;
			Genre = genre;
			ReleaseYear = releaseYear;
		}

		// Override method to display movie details
		public override void DisplayDetails()
		{
			Console.WriteLine($"Title: {Title}");
			Console.WriteLine($"Genre: {Genre}");
			Console.WriteLine($"Release Year: {ReleaseYear}");
		}
	}
}
