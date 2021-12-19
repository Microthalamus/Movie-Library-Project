using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
	public class Movie : IMovie
	{
		public string Title { get; set; }
		public string Comments { get; set; }
		public Image Image { get; set; }

	}
}
