namespace MovieLibrary
{
	partial class EditMovieForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SaveButton2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddPoster = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CommentBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MovieTitle = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPoster)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton2
            // 
            this.SaveButton2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton2.Location = new System.Drawing.Point(527, 281);
            this.SaveButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.Size = new System.Drawing.Size(118, 49);
            this.SaveButton2.TabIndex = 23;
            this.SaveButton2.Text = "Save";
            this.SaveButton2.UseVisualStyleBackColor = true;
            this.SaveButton2.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddPoster);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(362, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(211, 235);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Poster Image";
            // 
            // AddPoster
            // 
            this.AddPoster.BackColor = System.Drawing.Color.Lavender;
            this.AddPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddPoster.Location = new System.Drawing.Point(18, 40);
            this.AddPoster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddPoster.Name = "AddPoster";
            this.AddPoster.Size = new System.Drawing.Size(176, 179);
            this.AddPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddPoster.TabIndex = 0;
            this.AddPoster.TabStop = false;
            this.AddPoster.Click += new System.EventHandler(this.AddPoster_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CommentBox);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(581, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(263, 235);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comments";
            // 
            // CommentBox
            // 
            this.CommentBox.BackColor = System.Drawing.SystemColors.Control;
            this.CommentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommentBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CommentBox.Location = new System.Drawing.Point(18, 33);
            this.CommentBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CommentBox.Multiline = false;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(227, 181);
            this.CommentBox.TabIndex = 2;
            this.CommentBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MovieTitle);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(342, 92);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Title";
            // 
            // MovieTitle
            // 
            this.MovieTitle.Location = new System.Drawing.Point(19, 40);
            this.MovieTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(303, 31);
            this.MovieTitle.TabIndex = 0;
            // 
            // EditMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(857, 343);
            this.Controls.Add(this.SaveButton2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Movie";
            this.Load += new System.EventHandler(this.EditMovieForm_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddPoster)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button SaveButton2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox AddPoster;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RichTextBox CommentBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox MovieTitle;
    }
}