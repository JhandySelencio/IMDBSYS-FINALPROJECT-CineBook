using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMDBSYS_CineBook.Properties;

namespace IMDBSYS_CineBook
{
    public partial class BookMovieForm : Form
    {
        private Movie movieData;
        private int userID;
        private string scheduleSelected;
        private int ticketqty;
        private int seatqty;
        private int subtotal;
        private List<int> pickedSeats = new List<int>(); // List that stores multiple seats
        private List<int> clonePickedSeats;

        public BookMovieForm(Movie movie, int userID)
        {
            InitializeComponent();
            movieData = movie;
            this.userID = userID;
            schedulePNL.Visible = true;
            ticketsPNL.Visible = false;
            posterPNL.Visible = true;
            seatsPNL.Visible = false;
            confirmPNL.Visible = false;
            paymentLBL.Visible = false;
            confirmBTN.Enabled = true;
            LoadSchedule();
            LoadMovieDetail();
            ticketqty = 1;
        }

        private void LoadMovieDetail() // Loads the movie Poster
        {
            try
            {
                moviePosterIMGBOX.Load(movieData.Poster);
            }
            catch
            {
                moviePosterIMGBOX.LoadAsync();
            }
        }

        private void LoadSchedule() // Loads the function for Schedule Panel
        {
            using (var db = new CineBookDBEntities())
            {
                //  Displays the schedule of the movie
                var showtimes = db.Showtimes
                                      .Where(s => s.MovieID == movieData.MovieID)
                                      .Where(s => s.StatusID == 1)
                                      .Select(s => new
                                      {
                                          s.ShowTimeID,
                                          s.ShowDate,
                                          s.StartTime,
                                          s.EndTime,
                                          s.TicketPrice
                                      })
                                      .ToList();

                scheduleDataGridView.DataSource = showtimes;
            }
        }

        private void closeBTN_Click(object sender, EventArgs e) 
        {
            this.Hide();
        }

        private void LoadTicket()   // Loads the function for Ticket Panel
        {   
            //  Gets the ShowtimeID
            int scheduleNo = Convert.ToInt32(scheduleSelected);

            using (var db = new CineBookDBEntities())
            {
                var showtime = db.Showtimes.FirstOrDefault(t => t.ShowTimeID == scheduleNo);
                costOutputLBL.Text = showtime.TicketPrice.ToString();

                int ticketPrice = (int)showtime.TicketPrice;

                qtyTicketDisplayTXTBOX.Text = Convert.ToString(ticketqty);
                subtotal = ticketPrice * ticketqty; // Saves the calculated Ticket Price * Quantity

                insertSubTotalLBL.Text = Convert.ToString(subtotal + ".00");     
            }
        }

        private void LoadSeats()    // Loads the function for Seats Panel
        {
            //  Gets the ShowtimeID
            int scheduleNo = Convert.ToInt32(scheduleSelected);
            // Value of "ticketqty" will be the same as "seatqty"
            seatqty = ticketqty;

            //  Manages the controls of the Flow Panel
            seatDisplayFLWPNL.Controls.Clear();
            seatDisplayFLWPNL.FlowDirection = FlowDirection.LeftToRight;

            //  Condition to change the tickets desc to be single or plural 
            if (ticketqty > 1)
            {
                seatDescLBL.Text = "Select " + ticketqty + " seats that you wish to reserve of your most comfortable spot.";
            }
            else 
            {
                seatDescLBL.Text = "Select a seats that you wish to reserve of your most comfortable spot.";
            }


            using (var db = new CineBookDBEntities())
            {
                //  Gets the StartTime value of the same ShowTimeID
                var startTime = db.Showtimes
                                  .Where(s => s.ShowTimeID == scheduleNo)
                                  .Select(s => s.StartTime)
                                  .FirstOrDefault();

                //  Gets the screenName value using Inner Join between Showtimes and Screen
                var screenName = (from sh in db.Showtimes
                                  join sc in db.Screens
                                          on sh.ScreenID equals sc.ScreenID
                                  where sh.ShowTimeID == scheduleNo
                                  select sc.ScreenName)
                                  .FirstOrDefault();

                //  Gets the screenID value of the same ShowtimeID
                var screenID = db.Showtimes
                                 .Where(sh => sh.ShowTimeID == scheduleNo)
                                 .Select(sh => sh.ScreenID)
                                 .FirstOrDefault();

                //  Converts the Date data field to string
                string formatStartTime = DateTime.Today
                                                 .Add(startTime.Value)
                                                 .ToString("hh:mm:tt");

                //  Converts the screenID to INT
                int formatScreenID = Convert.ToInt32(screenID);

                // Instantiate a Label that displays the Movie details inside the Flow Panel
                Label movieScreen = new Label();
                movieScreen.AutoSize = false;
                movieScreen.Height = 29;
                movieScreen.Width = 673;
                movieScreen.Font = new Font("Arial", 12, FontStyle.Bold);
                movieScreen.ForeColor = Color.Black;
                movieScreen.Margin = new Padding(10);
                movieScreen.BackColor = Color.FromArgb(204, 204, 204);
                movieScreen.TextAlign = ContentAlignment.MiddleCenter;
                movieScreen.Text = "MOVIE SCREEN - " + formatStartTime + " @ " + screenName;
                seatDisplayFLWPNL.Controls.Add(movieScreen);

                //  Gets the value of Seat Table
                var seat = db.Seats
                             .Where(s => s.ScreenID == formatScreenID)
                             .ToList();

                // Displays all the seatNumber of the same ScreenID value
                foreach (var seats in seat) {
                    PictureBox seatIcon = new PictureBox();
                    seatIcon.Height = 27;
                    seatIcon.Width = 22;
                    seatIcon.SizeMode = PictureBoxSizeMode.Normal;
                    seatIcon.Cursor = Cursors.Hand;
                    try
                    {
                        if (seats.StatusID == 9)
                        {
                            seatIcon.Image = Properties.Resources.AvailableSeat;
                        }
                        if (seats.StatusID == 10)
                        {
                            seatIcon.Image = Properties.Resources.ReservedSeat;
                        }

                        seatIcon.Click += new EventHandler(SeatIcon_Click);
                        seatIcon.Tag = new
                        {
                            SeatID = seats.SeatID,
                            StatusID = seats.StatusID
                        };
                    }
                    catch
                    {
                        seatIcon.LoadAsync();
                    }
                    seatDisplayFLWPNL.Controls.Add(seatIcon);
                }   
            }
        }

        private void LoadSummary()  // Loads the function for Summary Panel
        {
            int scheduleNo = Convert.ToInt32(scheduleSelected);
            List<string> convertSeatType = new List<string>();
            clonePickedSeats = new List<int>(pickedSeats);

            using (var db = new CineBookDBEntities())
            {
                // This part sets the text to movie details
                var showDate = db.Showtimes
                                  .Where(s => s.ShowTimeID == scheduleNo)
                                  .Select(s => s.ShowDate)
                                  .FirstOrDefault();
                
                var screenName = (from sh in db.Showtimes
                                  join sc in db.Screens
                                          on sh.ScreenID equals sc.ScreenID
                                  where sh.ShowTimeID == scheduleNo
                                  select sc.ScreenName)
                                  .FirstOrDefault();

                var startTime = db.Showtimes
                                  .Where(s => s.ShowTimeID == scheduleNo)
                                  .Select(s => s.StartTime)
                                  .FirstOrDefault();

                string dateString = showDate.Value.ToString("MMMM d, yyyy");
                string formatStartTime = DateTime.Today
                                                 .Add(startTime.Value)
                                                 .ToString("h:mm:tt");

                movieDetailLBL.Text = "(2D)" + movieData.Title + "\r\n" +
                                               dateString + "\r\n" +
                                               screenName + "\r\n" + 
                                               formatStartTime + " Reserved Seating";
                
                //  This part sets the text to display tickets
                var showtime = db.Showtimes.FirstOrDefault(t => t.ShowTimeID == scheduleNo);
                ticketDetailLBL.Text = ticketqty + "x   " + showtime.TicketPrice.ToString() + " php";

                // This part sets the text to display the total tickets
                totalPriceLBL.Text = "Total Price: " + subtotal + ".00 php";

                // This part displays the list of seats
                convertSeatType.Clear();
                var screenID = db.Showtimes
                                 .Where(sh => sh.ShowTimeID == scheduleNo)
                                 .Select(sh => sh.ScreenID)
                                 .FirstOrDefault();

                int formatScreenID = screenID.HasValue ? screenID.Value : 0;

                var seats = db.Seats
                              .Where(s => s.ScreenID == formatScreenID)
                              .ToList();


                foreach (var seatId in pickedSeats) {

                    var seatName = seats.FirstOrDefault(s => s.SeatID == seatId)?.SeatName;

                    if (!string.IsNullOrEmpty(seatName))
                    {
                        convertSeatType.Add(seatName);
                    }
                }

                string displaySeats = string.Join(", ", convertSeatType);
                displayPickedSeatLBL.Text = displaySeats;
            }   
        }

        private void LoadPayment() // Loads the function for Payment Panel
        {
            using (var db = new CineBookDBEntities())
            {
                //  Populates the Payment Method Combo Box
                var paymentMethod = db.PaymentMethods.ToList();

                paymentMethodCMBBOX.DataSource = paymentMethod;
                paymentMethodCMBBOX.DisplayMember = "PaymentMethodName";
                paymentMethodCMBBOX.ValueMember = "PaymentMethodID";

                //  Displays current date today
                insertTransactionDateLBL.Text = DateTime.Today.ToString("MMMM d, yyyy");

                //  Displays total amount of your booking
                insertTotalAmountLBL.Text = subtotal + ".00 php";
            }
        }

        private void scheduleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //  Displays the Showtime ID of the selected cell in the data grid view
            if (e.RowIndex >= 0)
            {
                scheduleSelected = scheduleDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                schedulePickTXTBOX.Text = scheduleSelected;
            }
        }

        private void SeatIcon_Click(object sender, EventArgs e)
        {
            //  Instantiate to connect the "Instantiate PictureBox" in the Tickets Panel
            PictureBox clickedSeat = (PictureBox)sender;

            //  Converts the datas of the variable above
            dynamic seatData = clickedSeat.Tag;

            int seatStatus = seatData.StatusID;
            int seatID = seatData.SeatID;
            
            //  Condition to switch the image and save the SeatID of the generated Seats in Tickets Panel
            if (seatStatus == 9 & seatqty != 0)
            {
                clickedSeat.Image = Properties.Resources.SelectedSeat;
                clickedSeat.Tag = new
                {
                    SeatID = seatID,
                    StatusID = 11
                };
                pickedSeats.Add(seatID);
                seatqty--;
            }
            else if (seatStatus == 11)
            {
                clickedSeat.Image = Properties.Resources.AvailableSeat;
                clickedSeat.Tag = new
                {
                    SeatID = seatID,
                    StatusID = 9
                };
                pickedSeats.Remove(seatID);
                seatqty++;
            }
            else if (seatStatus == 10)
            {
                MessageBox.Show("Please choose another seat that isnt occupied.",
                                "Seat Already Occupied", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void proceedBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(schedulePickTXTBOX.Text))
            {
                MessageBox.Show("Please select a schedule before proceeding.",
                                "Warning No Schedule Found", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            //Switch PNL
            ticketsPNL.Visible = true;
            schedulePNL.Visible = false;
            //Change Steps Design
            selectScheduleSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectTicketSignLBL.BackColor = Color.Red;
            selectSeatsSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectSummarySignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectPaymentSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            //Method
            LoadTicket();
        }

        private void addTicketQtyBTN_Click(object sender, EventArgs e)
        {
            if (ticketqty < 10)
            {
                ticketqty++;
                LoadTicket();
            }
            else 
            {
                MessageBox.Show("Maxium tickets has  been reached. You can only buy 10 tickets per transaction.",
                                    "Maximum Limit Reached", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void subTicketQtyBTN_Click(object sender, EventArgs e)
        {
            if (ticketqty > 1)
            {
                ticketqty--;
                LoadTicket();
            }
            else
            {
                MessageBox.Show("Cannot select lesser than zero tickets. Please add more than one to continue.",
                                "Minimum Limit Reached", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void ticketReturnBTN_Click(object sender, EventArgs e)
        {
            //Switch PNL
            schedulePNL.Visible = true;
            ticketsPNL.Visible = false;
            //Change Steps Design
            selectScheduleSignLBL.BackColor = Color.Red;
            selectTicketSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectSeatsSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectSummarySignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectPaymentSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            //Method
            LoadMovieDetail();
            LoadSchedule();
        }

        private void ticketProceedBTN_Click(object sender, EventArgs e)
        {
            //Switch PNL
            ticketsPNL.Visible = false;
            posterPNL.Visible = false;
            seatsPNL.Visible = true;
            //Change Steps Design
            selectScheduleSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectTicketSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectSeatsSignLBL.BackColor = Color.Red;
            selectSummarySignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectPaymentSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            //Method
            LoadSeats();
        }

        private void seatReturnBTN_Click(object sender, EventArgs e)
        {
            //Switch PNL
            ticketsPNL.Visible = true;
            posterPNL.Visible = true;
            seatsPNL.Visible = false;
            //Change Steps Design
            selectScheduleSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectTicketSignLBL.BackColor = Color.Red;
            selectSeatsSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectSummarySignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectPaymentSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            //Method
            LoadTicket();
        }

        private void seatProceedBTN_Click(object sender, EventArgs e)
        {
            if (seatqty == 0)
            {
                //Switch PNL
                seatsPNL.Visible = false;
                posterPNL.Visible = true;
                confirmPNL.Visible = true;
                //Change Steps Design
                selectScheduleSignLBL.BackColor = Color.FromArgb(33, 36, 45);
                selectTicketSignLBL.BackColor = Color.FromArgb(33, 36, 45); 
                selectSeatsSignLBL.BackColor = Color.FromArgb(33, 36, 45);
                selectSummarySignLBL.BackColor = Color.Red;
                selectPaymentSignLBL.BackColor = Color.FromArgb(33, 36, 45);
                //Method
                LoadSummary();
            }
            else 
            {
                MessageBox.Show("Please select the seats that you want to reserve before proceeding.",
                                "Empty Seats", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void summaryReturnBTN_Click(object sender, EventArgs e)
        {
            //Switch PNL
            seatsPNL.Visible = true;
            posterPNL.Visible = false;
            confirmPNL.Visible = false;
            //Change Steps Design
            selectScheduleSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectTicketSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectSeatsSignLBL.BackColor = Color.Red;
            selectSummarySignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectPaymentSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            //Method
            pickedSeats.Clear();
            LoadSeats();
        }
        private void summaryProceedBTN_Click(object sender, EventArgs e)
        {
            //Switch PNL
            confirmPNL.Visible = false;
            paymentLBL.Visible = true;
            //Change Steps Design
            selectScheduleSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectTicketSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectSeatsSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectSummarySignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectPaymentSignLBL.BackColor = Color.Red;
            //Method
            LoadPayment();
        }

        private void paymentReturnBTN_Click(object sender, EventArgs e)
        {
            //Switch PNL
            confirmPNL.Visible = true;
            paymentLBL.Visible = false;
            //Change Steps Design
            selectScheduleSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectTicketSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectSeatsSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            selectSummarySignLBL.BackColor = Color.Red;
            selectPaymentSignLBL.BackColor = Color.FromArgb(33, 36, 45);
            //Method
            LoadSummary();
        }

        private int generateTicketID() //   Method that generates a 6 digit number for the Ticket ID
        {
            Random random = new Random();

            int minValue = 100000;
            int maxValue = 1000000;

            int ticketId = random.Next(minValue, maxValue);

            return ticketId;
        }

        //  When clicked, adds values to Booking Table and Payment Table
        private void confirmBTN_Click(object sender, EventArgs e)
        {
            int showtimeID = Convert.ToInt32(scheduleSelected);
            confirmBTN.Enabled = false;
            
            using (var db = new CineBookDBEntities())
            {
                // -=- Booking Table -=-

                // Get the value of ShowtimeID
                DateTime datetoday = DateTime.Now;
                int seatCount = pickedSeats.Count;

                Booking firstBooking = null;

                // This upload all the movie details on the Booking Table
                for (int i = 0; i < seatCount; i++)
                {
                    int seatNo = pickedSeats[0];

                    Booking newBooking = new Booking()
                    {
                        UserID = userID,
                        ShowtimeID = showtimeID,
                        BookingDate = datetoday,
                        StatusID = 6,
                        SeatID = seatNo,
                        TicketID = generateTicketID()
                    };
                    db.Bookings.Add(newBooking);

                    if (i == 0) { 
                        firstBooking = newBooking;
                    }

                    clonePickedSeats.Add(seatNo);
                    pickedSeats.RemoveAt(0);
                }

                //  Checks if the first book is null
                if (firstBooking == null) {
                    MessageBox.Show("Booking list was empty",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    confirmBTN.Enabled = true;
                    return;
                }

                // -=- Payment Table -=-

                int paymentMethodSelect = paymentMethodCMBBOX.SelectedIndex + 1;

                // Uploads the payment details to Payment Table
                Payment newPayment = new Payment()
                {
                    Booking = firstBooking,
                    PaymentMethodID = paymentMethodSelect,
                    PaymentDate = datetoday,
                    AmountPaid = subtotal
                };
                db.Payments.Add(newPayment);

                //  -=- Updates the Status of the picked Seat(s) -=-

                foreach (int seatID in clonePickedSeats)
                {
                    Seat updateSeatStatus = db.Seats.Find(seatID);

                    if (updateSeatStatus != null && updateSeatStatus.StatusID != 10) {
                        updateSeatStatus.StatusID = 10;
                    }
                }

                db.SaveChanges();

                MessageBox.Show("Success! Your movie ticket has been successfully booked. You will receive an email confirmation shortly.",
                                "Booking Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        // -=-=- /|\ "DUMP PILE" /|\ -=-=-

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
