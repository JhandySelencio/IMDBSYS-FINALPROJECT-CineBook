namespace IMDBSYS_CineBook
{
    partial class MovieDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDetailForm));
            this.showMovieDetailPNL = new System.Windows.Forms.Panel();
            this.genreSignLBL = new System.Windows.Forms.Label();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.buyTicketBTN = new System.Windows.Forms.Button();
            this.durationSignLBL = new System.Windows.Forms.Label();
            this.insertDurationLBL = new System.Windows.Forms.Label();
            this.insertGenreLBL = new System.Windows.Forms.Label();
            this.insertMovieScoreLBL = new System.Windows.Forms.Label();
            this.insertRatingLBL = new System.Windows.Forms.Label();
            this.descriptionLBL = new System.Windows.Forms.Label();
            this.movieScoreSignLBL = new System.Windows.Forms.Label();
            this.ratingSignLBL = new System.Windows.Forms.Label();
            this.movieNameLBL = new System.Windows.Forms.Label();
            this.moviePosterIMGBOX = new System.Windows.Forms.PictureBox();
            this.showMovieDetailPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePosterIMGBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // showMovieDetailPNL
            // 
            this.showMovieDetailPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.showMovieDetailPNL.Controls.Add(this.genreSignLBL);
            this.showMovieDetailPNL.Controls.Add(this.cancelBTN);
            this.showMovieDetailPNL.Controls.Add(this.buyTicketBTN);
            this.showMovieDetailPNL.Controls.Add(this.durationSignLBL);
            this.showMovieDetailPNL.Controls.Add(this.insertDurationLBL);
            this.showMovieDetailPNL.Controls.Add(this.insertGenreLBL);
            this.showMovieDetailPNL.Controls.Add(this.insertMovieScoreLBL);
            this.showMovieDetailPNL.Controls.Add(this.insertRatingLBL);
            this.showMovieDetailPNL.Controls.Add(this.descriptionLBL);
            this.showMovieDetailPNL.Controls.Add(this.movieScoreSignLBL);
            this.showMovieDetailPNL.Controls.Add(this.ratingSignLBL);
            this.showMovieDetailPNL.Controls.Add(this.movieNameLBL);
            this.showMovieDetailPNL.Controls.Add(this.moviePosterIMGBOX);
            this.showMovieDetailPNL.Location = new System.Drawing.Point(12, 12);
            this.showMovieDetailPNL.Name = "showMovieDetailPNL";
            this.showMovieDetailPNL.Size = new System.Drawing.Size(790, 436);
            this.showMovieDetailPNL.TabIndex = 1;
            // 
            // genreSignLBL
            // 
            this.genreSignLBL.AutoSize = true;
            this.genreSignLBL.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreSignLBL.ForeColor = System.Drawing.Color.White;
            this.genreSignLBL.Location = new System.Drawing.Point(312, 90);
            this.genreSignLBL.Name = "genreSignLBL";
            this.genreSignLBL.Size = new System.Drawing.Size(59, 21);
            this.genreSignLBL.TabIndex = 42;
            this.genreSignLBL.Text = "Genre:";
            // 
            // cancelBTN
            // 
            this.cancelBTN.BackColor = System.Drawing.Color.Red;
            this.cancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBTN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBTN.ForeColor = System.Drawing.Color.White;
            this.cancelBTN.Location = new System.Drawing.Point(547, 377);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(225, 42);
            this.cancelBTN.TabIndex = 41;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = false;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // buyTicketBTN
            // 
            this.buyTicketBTN.BackColor = System.Drawing.Color.Red;
            this.buyTicketBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buyTicketBTN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicketBTN.ForeColor = System.Drawing.Color.White;
            this.buyTicketBTN.Location = new System.Drawing.Point(303, 377);
            this.buyTicketBTN.Name = "buyTicketBTN";
            this.buyTicketBTN.Size = new System.Drawing.Size(225, 42);
            this.buyTicketBTN.TabIndex = 40;
            this.buyTicketBTN.Text = "Buy Ticket";
            this.buyTicketBTN.UseVisualStyleBackColor = false;
            this.buyTicketBTN.Click += new System.EventHandler(this.buyTicketBTN_Click);
            // 
            // durationSignLBL
            // 
            this.durationSignLBL.AutoSize = true;
            this.durationSignLBL.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationSignLBL.ForeColor = System.Drawing.Color.White;
            this.durationSignLBL.Location = new System.Drawing.Point(312, 121);
            this.durationSignLBL.Name = "durationSignLBL";
            this.durationSignLBL.Size = new System.Drawing.Size(86, 21);
            this.durationSignLBL.TabIndex = 39;
            this.durationSignLBL.Text = "Duration: ";
            // 
            // insertDurationLBL
            // 
            this.insertDurationLBL.AutoSize = true;
            this.insertDurationLBL.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertDurationLBL.ForeColor = System.Drawing.Color.White;
            this.insertDurationLBL.Location = new System.Drawing.Point(404, 121);
            this.insertDurationLBL.Name = "insertDurationLBL";
            this.insertDurationLBL.Size = new System.Drawing.Size(124, 21);
            this.insertDurationLBL.TabIndex = 38;
            this.insertDurationLBL.Text = "[Insert Duration]";
            this.insertDurationLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertGenreLBL
            // 
            this.insertGenreLBL.AutoSize = true;
            this.insertGenreLBL.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertGenreLBL.ForeColor = System.Drawing.Color.White;
            this.insertGenreLBL.Location = new System.Drawing.Point(377, 90);
            this.insertGenreLBL.Name = "insertGenreLBL";
            this.insertGenreLBL.Size = new System.Drawing.Size(105, 21);
            this.insertGenreLBL.TabIndex = 37;
            this.insertGenreLBL.Text = "[Insert Genre]";
            this.insertGenreLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertMovieScoreLBL
            // 
            this.insertMovieScoreLBL.AutoSize = true;
            this.insertMovieScoreLBL.BackColor = System.Drawing.Color.Yellow;
            this.insertMovieScoreLBL.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertMovieScoreLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.insertMovieScoreLBL.Location = new System.Drawing.Point(426, 186);
            this.insertMovieScoreLBL.Name = "insertMovieScoreLBL";
            this.insertMovieScoreLBL.Size = new System.Drawing.Size(163, 21);
            this.insertMovieScoreLBL.TabIndex = 35;
            this.insertMovieScoreLBL.Text = "[Insert Movie Score]";
            this.insertMovieScoreLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insertRatingLBL
            // 
            this.insertRatingLBL.AutoSize = true;
            this.insertRatingLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.insertRatingLBL.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertRatingLBL.ForeColor = System.Drawing.Color.White;
            this.insertRatingLBL.Location = new System.Drawing.Point(440, 153);
            this.insertRatingLBL.Name = "insertRatingLBL";
            this.insertRatingLBL.Size = new System.Drawing.Size(119, 21);
            this.insertRatingLBL.TabIndex = 34;
            this.insertRatingLBL.Text = "[Insert Rating]";
            this.insertRatingLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLBL
            // 
            this.descriptionLBL.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.descriptionLBL.ForeColor = System.Drawing.Color.White;
            this.descriptionLBL.Location = new System.Drawing.Point(312, 224);
            this.descriptionLBL.Name = "descriptionLBL";
            this.descriptionLBL.Size = new System.Drawing.Size(456, 139);
            this.descriptionLBL.TabIndex = 31;
            this.descriptionLBL.Text = "[Insert Desciption]";
            this.descriptionLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieScoreSignLBL
            // 
            this.movieScoreSignLBL.AutoSize = true;
            this.movieScoreSignLBL.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieScoreSignLBL.ForeColor = System.Drawing.Color.White;
            this.movieScoreSignLBL.Location = new System.Drawing.Point(312, 186);
            this.movieScoreSignLBL.Name = "movieScoreSignLBL";
            this.movieScoreSignLBL.Size = new System.Drawing.Size(108, 21);
            this.movieScoreSignLBL.TabIndex = 30;
            this.movieScoreSignLBL.Text = "Movie Score:";
            // 
            // ratingSignLBL
            // 
            this.ratingSignLBL.AutoSize = true;
            this.ratingSignLBL.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingSignLBL.ForeColor = System.Drawing.Color.White;
            this.ratingSignLBL.Location = new System.Drawing.Point(312, 153);
            this.ratingSignLBL.Name = "ratingSignLBL";
            this.ratingSignLBL.Size = new System.Drawing.Size(122, 21);
            this.ratingSignLBL.TabIndex = 29;
            this.ratingSignLBL.Text = "MTRCB Rating:";
            // 
            // movieNameLBL
            // 
            this.movieNameLBL.AutoSize = true;
            this.movieNameLBL.Font = new System.Drawing.Font("Microsoft New Tai Lue", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameLBL.ForeColor = System.Drawing.Color.White;
            this.movieNameLBL.Location = new System.Drawing.Point(311, 16);
            this.movieNameLBL.Name = "movieNameLBL";
            this.movieNameLBL.Size = new System.Drawing.Size(217, 30);
            this.movieNameLBL.TabIndex = 1;
            this.movieNameLBL.Text = "[Insert Movie Title]";
            // 
            // moviePosterIMGBOX
            // 
            this.moviePosterIMGBOX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.moviePosterIMGBOX.ImageLocation = "https://www.movieposters.com/cdn/shop/files/scan_77bc93d2-a1cb-4d8c-826f-87e8add6" +
    "f9ff.jpg?v=1761837463&width=1680";
            this.moviePosterIMGBOX.Location = new System.Drawing.Point(18, 16);
            this.moviePosterIMGBOX.Name = "moviePosterIMGBOX";
            this.moviePosterIMGBOX.Size = new System.Drawing.Size(270, 403);
            this.moviePosterIMGBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moviePosterIMGBOX.TabIndex = 0;
            this.moviePosterIMGBOX.TabStop = false;
            // 
            // MovieDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(814, 460);
            this.ControlBox = false;
            this.Controls.Add(this.showMovieDetailPNL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovieDetailForm";
            this.Text = "Movie Detail";
            this.showMovieDetailPNL.ResumeLayout(false);
            this.showMovieDetailPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePosterIMGBOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox moviePosterIMGBOX;
        private System.Windows.Forms.Panel showMovieDetailPNL;
        private System.Windows.Forms.Label movieNameLBL;
        private System.Windows.Forms.Label descriptionLBL;
        private System.Windows.Forms.Label movieScoreSignLBL;
        private System.Windows.Forms.Label ratingSignLBL;
        private System.Windows.Forms.Label insertMovieScoreLBL;
        private System.Windows.Forms.Label insertRatingLBL;
        private System.Windows.Forms.Label durationSignLBL;
        private System.Windows.Forms.Label insertDurationLBL;
        private System.Windows.Forms.Label insertGenreLBL;
        private System.Windows.Forms.Button buyTicketBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Label genreSignLBL;
    }
}