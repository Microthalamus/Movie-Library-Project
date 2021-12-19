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
	public partial class EditMovieForm : Form
	{
		public Movie movie;
		public EditMovieForm(Movie movie)
		{
			InitializeComponent();

			this.movie = movie;
		}

		private void EditMovieForm_Load(object sender, EventArgs e)
		{
			MovieTitle.Text = movie.Title;
			CommentBox.Text = movie.Comments;
			AddPoster.Image = movie.Image;

			
		}

		private void SubmitButton_Click(object sender, EventArgs e)
		{
			movie.Title = MovieTitle.Text;
			movie.Image = AddPoster.Image;
			movie.Comments = CommentBox.Text;
			
			MessageBox.Show("Movie was successfully updated.");
			this.DialogResult = DialogResult.OK;
		}

		private void AddPoster_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new()
			{
				Filter = "Image Files (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png"
			};

			if (open.ShowDialog() == DialogResult.OK)
			{
				AddPoster.Image = new Bitmap(open.FileName);
				AddPoster.Text = open.FileName;
			}
		}
	}
}
