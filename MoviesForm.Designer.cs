namespace MoviesApp
{
    partial class MoviesForm
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
            this.moviesListBox = new System.Windows.Forms.ListBox();
            this.movieName = new System.Windows.Forms.Label();
            this.movieGenre = new System.Windows.Forms.Label();
            this.movieLength = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.movieNameInput = new System.Windows.Forms.TextBox();
            this.movieLengthInput = new System.Windows.Forms.TextBox();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.movieGenreInput = new System.Windows.Forms.ComboBox();
            this.movieYear = new System.Windows.Forms.Label();
            this.movieYearsInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameWarning = new System.Windows.Forms.Label();
            this.LengthWarning = new System.Windows.Forms.Label();
            this.YearWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moviesListBox
            // 
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.Location = new System.Drawing.Point(12, 12);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(354, 134);
            this.moviesListBox.TabIndex = 0;
            this.moviesListBox.SelectedIndexChanged += new System.EventHandler(this.moviesListBox_SelectedIndexChanged);
            // 
            // movieName
            // 
            this.movieName.AutoSize = true;
            this.movieName.Location = new System.Drawing.Point(399, 32);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(35, 13);
            this.movieName.TabIndex = 1;
            this.movieName.Text = "label1";
            this.movieName.Visible = false;
            // 
            // movieGenre
            // 
            this.movieGenre.AutoSize = true;
            this.movieGenre.Location = new System.Drawing.Point(399, 89);
            this.movieGenre.Name = "movieGenre";
            this.movieGenre.Size = new System.Drawing.Size(35, 13);
            this.movieGenre.TabIndex = 2;
            this.movieGenre.Text = "label2";
            this.movieGenre.Visible = false;
            // 
            // movieLength
            // 
            this.movieLength.AutoSize = true;
            this.movieLength.Location = new System.Drawing.Point(540, 89);
            this.movieLength.Name = "movieLength";
            this.movieLength.Size = new System.Drawing.Size(35, 13);
            this.movieLength.TabIndex = 4;
            this.movieLength.Text = "label4";
            this.movieLength.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Novi film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Zanr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trajanje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Godina";
            // 
            // movieNameInput
            // 
            this.movieNameInput.Location = new System.Drawing.Point(140, 235);
            this.movieNameInput.Name = "movieNameInput";
            this.movieNameInput.Size = new System.Drawing.Size(142, 20);
            this.movieNameInput.TabIndex = 10;
            this.movieNameInput.TextChanged += new System.EventHandler(this.movieNameInput_TextChanged);
            // 
            // movieLengthInput
            // 
            this.movieLengthInput.Location = new System.Drawing.Point(140, 309);
            this.movieLengthInput.Name = "movieLengthInput";
            this.movieLengthInput.Size = new System.Drawing.Size(142, 20);
            this.movieLengthInput.TabIndex = 12;
            this.movieLengthInput.TextChanged += new System.EventHandler(this.movieLengthInput_TextChanged);
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.Location = new System.Drawing.Point(140, 401);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(142, 23);
            this.AddMovieButton.TabIndex = 14;
            this.AddMovieButton.Text = "Unesi";
            this.AddMovieButton.UseVisualStyleBackColor = true;
            this.AddMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // movieGenreInput
            // 
            this.movieGenreInput.AccessibleDescription = "";
            this.movieGenreInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.movieGenreInput.FormattingEnabled = true;
            this.movieGenreInput.Items.AddRange(new object[] {
            "Akcija",
            "Horor",
            "Romantika",
            "Drama",
            "Animacija"});
            this.movieGenreInput.Location = new System.Drawing.Point(140, 271);
            this.movieGenreInput.MaxDropDownItems = 5;
            this.movieGenreInput.Name = "movieGenreInput";
            this.movieGenreInput.Size = new System.Drawing.Size(142, 21);
            this.movieGenreInput.TabIndex = 11;
            // 
            // movieYear
            // 
            this.movieYear.AutoSize = true;
            this.movieYear.Location = new System.Drawing.Point(540, 32);
            this.movieYear.Name = "movieYear";
            this.movieYear.Size = new System.Drawing.Size(35, 13);
            this.movieYear.TabIndex = 16;
            this.movieYear.Text = "label6";
            this.movieYear.Visible = false;
            // 
            // movieYearsInput
            // 
            this.movieYearsInput.Location = new System.Drawing.Point(140, 348);
            this.movieYearsInput.Name = "movieYearsInput";
            this.movieYearsInput.Size = new System.Drawing.Size(142, 20);
            this.movieYearsInput.TabIndex = 13;
            this.movieYearsInput.TextChanged += new System.EventHandler(this.movieYearsInput_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "( min )";
            // 
            // NameWarning
            // 
            this.NameWarning.AutoSize = true;
            this.NameWarning.ForeColor = System.Drawing.Color.Red;
            this.NameWarning.Location = new System.Drawing.Point(137, 255);
            this.NameWarning.Name = "NameWarning";
            this.NameWarning.Size = new System.Drawing.Size(100, 13);
            this.NameWarning.TabIndex = 18;
            this.NameWarning.Text = "Ne moze biti prazno";
            this.NameWarning.Visible = false;
            // 
            // LengthWarning
            // 
            this.LengthWarning.AutoSize = true;
            this.LengthWarning.ForeColor = System.Drawing.Color.Red;
            this.LengthWarning.Location = new System.Drawing.Point(137, 332);
            this.LengthWarning.Name = "LengthWarning";
            this.LengthWarning.Size = new System.Drawing.Size(100, 13);
            this.LengthWarning.TabIndex = 19;
            this.LengthWarning.Text = "Ne moze biti prazno";
            this.LengthWarning.Visible = false;
            // 
            // YearWarning
            // 
            this.YearWarning.AutoSize = true;
            this.YearWarning.ForeColor = System.Drawing.Color.Red;
            this.YearWarning.Location = new System.Drawing.Point(137, 372);
            this.YearWarning.Name = "YearWarning";
            this.YearWarning.Size = new System.Drawing.Size(100, 13);
            this.YearWarning.TabIndex = 20;
            this.YearWarning.Text = "Ne moze biti prazno";
            this.YearWarning.Visible = false;
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.YearWarning);
            this.Controls.Add(this.LengthWarning);
            this.Controls.Add(this.NameWarning);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.movieYearsInput);
            this.Controls.Add(this.movieYear);
            this.Controls.Add(this.movieGenreInput);
            this.Controls.Add(this.AddMovieButton);
            this.Controls.Add(this.movieLengthInput);
            this.Controls.Add(this.movieNameInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieLength);
            this.Controls.Add(this.movieGenre);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.moviesListBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(636, 489);
            this.MinimumSize = new System.Drawing.Size(636, 489);
            this.Name = "MoviesForm";
            this.Text = "Filmovi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoviesForm_FormClosing);
            this.Load += new System.EventHandler(this.MoviesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox moviesListBox;
        private System.Windows.Forms.Label movieName;
        private System.Windows.Forms.Label movieGenre;
        private System.Windows.Forms.Label movieLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox movieNameInput;
        private System.Windows.Forms.TextBox movieLengthInput;
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.ComboBox movieGenreInput;
        private System.Windows.Forms.Label movieYear;
        private System.Windows.Forms.TextBox movieYearsInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label NameWarning;
        private System.Windows.Forms.Label LengthWarning;
        private System.Windows.Forms.Label YearWarning;
    }
}

