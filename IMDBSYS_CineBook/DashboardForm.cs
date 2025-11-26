using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDBSYS_CineBook
{
    public partial class DashboardForm : Form
    {
        private string fullName;
        private int userId;
        int count;
        private bool isEdit;

        public DashboardForm(string name, int userId)
        {
            InitializeComponent();
            fullName = name;
            isEdit = false;
            this.userId = userId;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {           

            HomePNL.Visible = false;
            MoviePNL.Visible = false;
            ShowtimePNL.Visible = false;
            MyBookingPNL.Visible = false;
            profilePNL.Visible = false;

            LoadHomePanel();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        // -==========- | Main Function Method | -==========-


        // Main method for Home Panel
        private void LoadTopMovies()
        {
            featMovieDisplayFLWLYT.Controls.Clear();

            using (var db = new CineBookDBEntities())
            {
                var topMovies = db.Movies
                                  .Where(m => m.StatusID == 1)
                                  .Include(m => m.MovieRating)
                                  .OrderByDescending(m => m.MovieScore)
                                  .Take(3)
                                  .ToList();

                foreach (var movie in topMovies)
                {
                    PictureBox moviePoster = new PictureBox();
                    moviePoster.Width = 191;
                    moviePoster.Height = 261;
                    moviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
                    moviePoster.Cursor = Cursors.Hand;
                    moviePoster.Margin = new Padding(3);

                    try
                    {
                        moviePoster.Load(movie.Poster);
                    }
                    catch 
                    {
                        moviePoster.LoadAsync();
                    }
                    //  Click function when poster is clicked
                    moviePoster.Click += (s, e) => ShowMovieDetail(movie, true);
                    featMovieDisplayFLWLYT.Controls.Add(moviePoster);
                }
                //  Display the Movie title of the Top 3
                if (topMovies.Count > 0) top1MovieLBL.Text = topMovies[0].Title;
                if (topMovies.Count > 1) top2MovieLBL.Text = topMovies[1].Title;
                if (topMovies.Count > 2) top3MovieLBL.Text = topMovies[2].Title;
            }
        }

        // Main methods for Movies Panel
        private void LoadNowShowMovies()
        {
            displayMoviesFLWPNL.Controls.Clear();

            using (var db = new CineBookDBEntities())
            {
                var movies = db.Movies
                               .Where(m => m.StatusID == 1)
                               .Include(m => m.MovieRating)
                               .ToList();

                foreach (var movie in movies)
                {
                    PictureBox moviePoster = new PictureBox();
                    moviePoster.Width = 186;
                    moviePoster.Height = 256;
                    moviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
                    moviePoster.Cursor = Cursors.Hand;
                    moviePoster.Margin = new Padding(3);

                    try
                    {
                        moviePoster.Load(movie.Poster);
                    }
                    catch
                    {
                        moviePoster.LoadAsync();
                    }

                    //  Click function when poster is clicked
                    moviePoster.Click += (s, e) => ShowMovieDetail(movie, true);
                    displayMoviesFLWPNL.Controls.Add(moviePoster);
                }
            }
        }

        private void LoadComingSoonMovies()
        {
            displayMoviesFLWPNL.Controls.Clear();

            using (var db = new CineBookDBEntities())
            {
                var movies = db.Movies
                               .Include(m => m.MovieRating)
                               .Where(m => m.StatusID == 2)
                               .ToList();

                foreach (var movie in movies)
                {
                    PictureBox moviePoster = new PictureBox();
                    moviePoster.Width = 186;
                    moviePoster.Height = 256;
                    moviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
                    moviePoster.Margin = new Padding(3);

                    try
                    {
                        moviePoster.Load(movie.Poster);
                    }
                    catch
                    {
                        moviePoster.LoadAsync();
                    }
                    //  Click function when poster is clicked
                    moviePoster.Click += (s, e) => ShowMovieDetail(movie, false);
                    displayMoviesFLWPNL.Controls.Add(moviePoster);
                }
            }
        }

        //  Main method for Showtime Panel
        private void LoadShowtime()
        { 
            showtimeFLWPNL.Controls.Clear();

            using (var db = new CineBookDBEntities())
            {
                var movies = db.Movies
                               .Where(m => m.StatusID == 1)
                               .ToList();

                foreach (var movie in movies)
                {
                    PictureBox moviePoster = new PictureBox();
                    moviePoster.Width = 222;
                    moviePoster.Height = 308;
                    moviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
                    moviePoster.Margin = new Padding(3);

                    try
                    {
                        moviePoster.Load(movie.Poster);
                    }
                    catch
                    {
                        moviePoster.LoadAsync();
                    }

                    DataGridView showtimeDisplay = new DataGridView();
                    showtimeDisplay.Width = 343;
                    showtimeDisplay.Height = 308;
                    showtimeDisplay.AutoGenerateColumns = true;
                    showtimeDisplay.ReadOnly = true;
                    showtimeDisplay.AllowUserToAddRows = false;
                    showtimeDisplay.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    showtimeDisplay.MultiSelect = false;
                    showtimeDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    showtimeDisplay.AllowUserToResizeColumns = false;
                    showtimeDisplay.AllowUserToResizeRows = false;
                    showtimeDisplay.RowHeadersVisible = false;
                    showtimeDisplay.ForeColor = Color.Black;

                    var showtimes = db.Showtimes
                                      .Where(s => s.MovieID == movie.MovieID)
                                      .Select(s => new
                                      {
                                            s.ShowDate,
                                            s.StartTime,
                                            s.EndTime,
                                            s.TicketPrice
                                      })
                                      .ToList();

                    showtimeDisplay.DataSource = showtimes;

                    showtimeFLWPNL.Controls.Add(moviePoster);
                    showtimeFLWPNL.Controls.Add(showtimeDisplay);
                }
            }
        }

        private void LoadBookingHistory() {
            using (var db = new CineBookDBEntities()) 
            {
                var booking = db.Bookings.Where(b => b.StatusID == 6)
                                         .Select(b => new
                                         {
                                            b.TicketID,
                                            b.ShowtimeID,
                                            b.BookingDate,
                                            b.SeatID,                               
                                         })
                                         .ToList();

                bookingDataGridView.DataSource = booking;
            }
        }

        private void LoadProfile() 
        {
            if (isEdit == true)
            {
                editProfileBTN.Text = "Confirm";
                returnBTN.Visible = true;
            }
            else 
            {
                editProfileBTN.Text = "Edit Profile";
                returnBTN.Visible = false;
            }

                using (var db = new CineBookDBEntities())
                {
                    var userProfile = db.Users.FirstOrDefault();

                    usernameTXTBOX.Text = userProfile.Username;
                    passwordTXTBOX.Text = userProfile.Password;
                    fullNameTXTBOX.Text = userProfile.Fullname;
                    emailTXTBOX.Text = userProfile.Email;
                    contactTXTBOX.Text = userProfile.PhoneNumber;
                }
        }

        // -==========- | Methods That Loads The Panels | -==========-

        private void LoadHomePanel() 
        {
            //  Disable all the Panels
            MoviePNL.Visible = false;
            ShowtimePNL.Visible = false;
            MyBookingPNL.Visible = false;

            HomePNL.Visible = true;
            welcomeSignLBL.Text = $"Welcome, {fullName}!";

            LoadTopMovies();
        }

        private void LoadMoviesPanel()
        {
            //  Disable all the Panels
            HomePNL.Visible = false;
            ShowtimePNL.Visible = false;
            MyBookingPNL.Visible = false;
            profilePNL.Visible = false;

            MoviePNL.Visible = true;

            LoadNowShowMovies();         
        }

        private void LoadShowtimePanel()
        {
            //  Disable all the Panels
            HomePNL.Visible = false;
            MoviePNL.Visible = false;
            MyBookingPNL.Visible = false;
            profilePNL.Visible = false;

            ShowtimePNL.Visible = true;

            LoadShowtime();
        }

        private void LoadMyHistoryPanel()
        {
            count = 0;

            //  Disable all the Panels
            HomePNL.Visible = false;
            MoviePNL.Visible = false;
            ShowtimePNL.Visible = false;
            profilePNL.Visible = false;

            MyBookingPNL.Visible = true;

            LoadBookingHistory();
        }

        private void LoadProfilePanel()
        {
            //  Disable all the Panels
            HomePNL.Visible = false;
            MoviePNL.Visible = false;
            ShowtimePNL.Visible = false;
            MyBookingPNL.Visible = false;

            profilePNL.Visible = true;

            //  Change text box properties
            fullNameTXTBOX.BorderStyle = BorderStyle.None;
            emailTXTBOX.BorderStyle = BorderStyle.None;
            contactTXTBOX.BorderStyle = BorderStyle.None;
            contactTXTBOX.Clear();

            fullNameTXTBOX.ForeColor = Color.Red;
            emailTXTBOX.ForeColor = Color.Red;
            contactTXTBOX.ForeColor = Color.Red;

            fullNameTXTBOX.BackColor = Color.FromArgb(40, 44, 56);
            emailTXTBOX.BackColor = Color.FromArgb(40, 44, 56);
            contactTXTBOX.BackColor = Color.FromArgb(40, 44, 56);

            fullNameTXTBOX.ReadOnly = true;
            emailTXTBOX.ReadOnly = true;
            contactTXTBOX.ReadOnly = true;

            LoadProfile();
        }

        private void ShowMovieDetail(Movie movie, Boolean showMovie)
        {
            MovieDetailForm bookingForm = new MovieDetailForm(movie, showMovie, userId);
            bookingForm.ShowDialog();

        }

        // -==========- | Methods That Loads When Button Clicked | -==========-

        private void homeBTN_Click(object sender, EventArgs e)
        {
            LoadHomePanel();
        }

        private void moviesBTN_Click(object sender, EventArgs e)
        {
            LoadMoviesPanel();
            
        }
        private void myBookingsBTN_Click(object sender, EventArgs e)
        {
            LoadMyHistoryPanel();
        }

        private void nowShowingBTN_Click(object sender, EventArgs e)
        {
            comingSoonBTN.ForeColor = Color.White;
            comingSoonBTN.FlatAppearance.BorderSize = 0;

            nowShowingBTN.ForeColor = Color.Red;
            nowShowingBTN.FlatAppearance.BorderSize = 1;
            LoadNowShowMovies();
        }

        private void comingSoonBTN_Click(object sender, EventArgs e)
        {
            nowShowingBTN.ForeColor = Color.White;
            nowShowingBTN.FlatAppearance.BorderSize = 0;

            comingSoonBTN.ForeColor = Color.Red;
            comingSoonBTN.FlatAppearance.BorderSize = 1;
            LoadComingSoonMovies();
        }

        private void showtimesBTN_Click(object sender, EventArgs e)
        {
            LoadShowtimePanel();
        }

        private void profileBTN_Click(object sender, EventArgs e)
        {
            LoadProfilePanel();
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            isEdit = true;
            count++;

            //  Change text box properties
            fullNameTXTBOX.BorderStyle = BorderStyle.FixedSingle;
            emailTXTBOX.BorderStyle = BorderStyle.FixedSingle;
            contactTXTBOX.BorderStyle = BorderStyle.FixedSingle;

            fullNameTXTBOX.ForeColor = Color.Black;
            emailTXTBOX.ForeColor = Color.Black;
            contactTXTBOX.ForeColor = Color.Black;

            fullNameTXTBOX.BackColor = Color.White;
            emailTXTBOX.BackColor = Color.White;
            contactTXTBOX.BackColor = Color.White;

            fullNameTXTBOX.ReadOnly = false;
            emailTXTBOX.ReadOnly = false;
            contactTXTBOX.ReadOnly = false;

            editProfileBTN.Text = "Confirm";
            returnBTN.Visible = true;

            using (var db = new CineBookDBEntities())
            {
                User userProfile = db.Users.Find(userId);
                var userProfileContactInfo = db.Users.FirstOrDefault();

                string newEmail = emailTXTBOX.Text;
                string newFullName = fullNameTXTBOX.Text;
                string newContactInfo = contactTXTBOX.Text;

                if (newContactInfo.Length != 11) {
                    MessageBox.Show("Please enter up to 10 digit numbers", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contactTXTBOX.Text = userProfileContactInfo.PhoneNumber;
                    return;
                }

                try
                {
                    long contactInfo = Convert.ToInt64(newContactInfo);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter numbers only", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contactTXTBOX.Text = userProfileContactInfo.PhoneNumber;
                    return;
                }

                if (isEdit == true && count == 2)
                {
                    if (userProfile != null)
                    {
                        userProfile.Fullname = newFullName;
                        userProfile.Email = newEmail;
                        userProfile.PhoneNumber = newContactInfo;
                    }
                    db.SaveChanges();
                    MessageBox.Show("Successfully changed profile details", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    count = 1;
                }
            }
            if (isEdit == false)
            {
                returnBTN.Visible = false;
                editProfileBTN.Text = "Edit Profile";
            }
        }

        private void returnBTN_Click(object sender, EventArgs e)
        {
            isEdit = false;
            LoadProfilePanel();
        }
    }
}
