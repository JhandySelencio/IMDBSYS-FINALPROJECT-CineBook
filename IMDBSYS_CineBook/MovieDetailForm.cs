using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBSYS_CineBook
{
    public partial class MovieDetailForm : Form
    {
        private Movie movieData;
        private int userID;
        public MovieDetailForm(Movie movie, Boolean showMovie, int userID)
        {
            InitializeComponent();
            movieData = movie;
            this.userID = userID;
            LoadMovieDetail();

            if (showMovie == false) 
            { 
                buyTicketBTN.Visible = false;
                cancelBTN.Text = "Close";
            }
        }

        private string LoadMovieDuration()
        { 
            int duration = Convert.ToInt32(movieData.Duration);

            int hours = duration / 60;
            int minutes = duration % 60;

            string convert = hours + " hours " + minutes + " minutes";

            return convert;
        }

        private void LoadMovieDetail()
        {
            movieNameLBL.Text = movieData.Title;
            insertDurationLBL.Text = LoadMovieDuration();
            insertGenreLBL.Text = movieData.Genre;
            insertRatingLBL.Text = movieData.MovieRating.RatedName;
            insertMovieScoreLBL.Text = movieData.MovieScore?.ToString() ?? "N/A"; //    converts nullable decimal
            descriptionLBL.Text = movieData.Description;

            try //  Try catch if Image fails to load
            {
                moviePosterIMGBOX.Load(movieData.Poster);
            }
            catch
            {
                moviePosterIMGBOX.LoadAsync();
            }

            switch (movieData.MovieRating.RatedName)
            {
                case "G":
                    insertRatingLBL.BackColor = Color.Green;
                    break;
                case "PG":
                    insertRatingLBL.BackColor = Color.Blue;
                    break;
                case "PG-13":
                    insertRatingLBL.BackColor = Color.Yellow;
                    insertRatingLBL.ForeColor = Color.Black;
                    break;
                case "R":
                    insertRatingLBL.BackColor = Color.Red;
                    break;
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buyTicketBTN_Click(object sender, EventArgs e)
        {
            BookMovieForm bookform = new BookMovieForm(movieData, userID);
            bookform.ShowDialog();
            this.Hide();
        }
    }
}
