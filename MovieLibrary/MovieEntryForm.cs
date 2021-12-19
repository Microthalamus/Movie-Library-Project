//Movie Library Project: Initial design of application and setting up 5 different GUIs
//Estimated development time to complete project : 2 hours
//11/11/21 - Time Spent = 1 hr
//11/12/21 - Time Spent = 1 hr
//11/13/21 - Time Spent = 1 hr
//Total Time = 3 hours
//This process took me about 3 hours which is an hour over my estimate. I believe this is because I am still getting use to visual studio and how to add and edit GUIs.
//I was also unaware that there are certain things textboxes cannot do such as place holder text so I had to do some research to figure out how to do this on my own.
//One thing that I would go differently next time is think about what functions I to add and if I do not know how to property code them I will google the process beforehand to get a better idea on what to do.
//That was I am not fumbling around trying to get the code to do what I want.

//Goal for 11-21-21: Add function for submit and delete buttons
//Estimated development time to complete project : 2 hours
//11/19/21 - Time Spent = 1 hr
//11/20/21 - Time Spent = 1 hr
//11/21/21 - Time Spent = 1 hr
//Total Time = 3 hours
//This process took me another hour over my estimated time. I had to do some trouble shooting this the submit but because it was not working how I wanted to when I first tried to code it.
//The delete button was a little but easier to figure out after that and I was able to get this done quicker. One that I should go differently is go back and try to clean up my code as I go because I have noticed that things are looking a little bit cluttered.
//I would as do a little bit more research on different ways to code the same function to make things look cleaner. Finally, I found this program called Resharper. It helps with correcting error in my code so I will be using it in the future.

//Goal for 12-5-21: Clean up code, separate classes, add edit function
//Estimated development time to complete project : 4 hours
//11/30/21 - Time Spent = 3 hr
//12/2/21 - Time Spent = 5 hr
//12/3/21 - Time Spent = 2 hr
//12/4/21 - Time Spent = 2 hr
//12/52/21 - Time Spent = 1 hr
//Total Time = 13 hours
//This sprint took me the most amount of time. I had to ask a friend for advice on how to implement all that I had in mind. I also had to spend a long time google and looking at examples.
//I ended up creating 2 new classes on separate code file and now I will need to find some way to connect them all. I am thinking of trying to implement a data source in order to do this but I will have to research it more.
//What I would have done differently this time around would be to sketch how I want my application to look beforehand. Then I would as a friend how they would want it to look like and then implement those changes to make the application flow better.

//Goal for 12-12-21: Clean up UI, add datasource
//Estimated development time to complete project : 3 hours
//12/10/21 - Time Spent = 1 hr
//12/11/21 - Time Spent = 1 hr
//Total Time = 2 hours
//This sprint took me the least amount of time. It was maining just me dragged, dropping, and rearraging the GUIs to look nicer.
//With the datasource it was actully easy to implement. All I had to do is click the 'Project' tab and then hit 'Add a datasource'.
//This takes you to a wizard that set everything up.Then all you have to do is add a binding source from the tool box and connect it to the datasource.
//You do the same thing for the datagrid.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibrary
{
	public partial class MovieEntryForm : Form
	{
		BindingList<Movie> Movies = new BindingList<Movie>();
		public MovieEntryForm()
		{
			InitializeComponent();
		}

		public void ClearForm()
		{
			commentBox.Clear();
			movieTitle.Clear();
			addposter.Image = null;
		}
		//Method for clearing any entries in form

		private void AddPoster_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new()
			{
				Filter = "Image Files (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png"
			};

			if (open.ShowDialog() == DialogResult.OK)
			{
				addposter.Image = new Bitmap(open.FileName);
				addposter.Text = open.FileName;
			}
		}
		// Allows user to add an image from their files when pcituree box is clicked

		private void ClearButton_Click(object sender, EventArgs e)
		{
			ClearForm();
		}
		//Clears form when 'Clear' button is pressed


		private void SubmitButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(movieTitle.Text))
			{
				MessageBox.Show("A movie Title is required. Please add a title to your entry");
				
			}

			Movie movie = new Movie()
			{
				Title = movieTitle.Text,
				Comments = commentBox.Text,
				Image = addposter.Image
			};

			Movies.Add(movie);

			MessageBox.Show("Movie was added to your Library");

			ClearForm();
		}
		//Submit all data entered into the from to the datagrid. Error exception if there is not at least a title in the form.

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "Delete Entry", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				int index = MovieData.CurrentCell.RowIndex;
				Movies.RemoveAt(index);
			}
		}
		//Asks user if they want to delete the entry selected. If yes deletes if no closes window.

		private void EditButton_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit this entry?", "Edit Entry", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				int index = MovieData.CurrentCell.RowIndex;
				Movie movie = Movies.ElementAt(index);
				EditMovieForm form = new EditMovieForm(movie);
				if (form.ShowDialog() == DialogResult.OK)
				{
					Movies.RemoveAt(index);
					Movies.Add(form.movie);
				}
			}
			//Pulls up EditMovieForm. New infomation can be added and saved for the selected entry.
		}
        private void MovieEntryForm_Load(object sender, EventArgs e)
		{
			Movies = new BindingList<Movie>();
			movieBindingSource.DataSource = Movies;
		}
		//Adds entry into datagrid.
	

		

	}
}
