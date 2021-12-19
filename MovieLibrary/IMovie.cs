using System.Drawing;

namespace MovieLibrary
{
	internal interface IMovie
	{
		string Title { get; set; }
		string Comments { get; set; }
		Image Image { get; set; }
	
	}
}