using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MoviesApp
{
    public partial class MoviesForm : Form
    {
        private List<Movie> movies;
        private const string FILE_PATH = @".\movies.txt";
        private bool isDataChanged;

        public MoviesForm()
        {
            InitializeComponent();

            movies = new List<Movie>();
            isDataChanged = false;
            CenterToParent();
        }

        public void LoadMovies()
        {
           string[] serializedMovies = File.ReadAllLines(FILE_PATH);

            Movie[] deserializedMovies = new Movie[serializedMovies.Length];

            for (int i = 0; i < serializedMovies.Length; i++)
            {
                deserializedMovies[i] = Movie.Deserialize(serializedMovies[i]);
            }
            movies.AddRange(deserializedMovies); 
        }
        private void saveMovies()
        {
            string[] serializedMovies = new string[movies.Count];

            for (int i = 0; i < movies.Count; i++)
            {
                serializedMovies[i] = movies[i].Serialize();
            }
            File.WriteAllLines(FILE_PATH, serializedMovies);
        }

        private void moviesListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                Movie current = selectedMovie();
                fillMoviesLabels(current);
                showMoviesComponents();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showMoviesComponents()
        {
            movieName.Visible = true;
            movieGenre.Visible = true;
            movieLength.Visible = true;
            movieYear.Visible = true;
        }
        private void fillMoviesLabels(Movie movie)
        {
            movieName.Text = movie.Name;
            movieGenre.Text = movie.Genre;
            movieLength.Text = movie.Length.ToString() + " min";
            movieYear.Text = movie.YearOfPremiere.ToString();
        }
        private void clearMoviesBoxInputs()
        {
            movieNameInput.Text = "";
            movieLengthInput.Text = "";
            movieYearsInput.Text = "";
            NameWarning.Visible = false; 
            LengthWarning.Visible = false;
            YearWarning.Visible = false;
        }

        private Movie selectedMovie()
        {
            return movies[moviesListBox.SelectedIndex];
        }
     

        private void AddMovieButton_Click(object sender, System.EventArgs e)
        {

            if (movieNameInput.Text.Length == 0) { NameWarning.Visible = true; } else NameWarning.Visible = false;
            if (movieLengthInput.Text.Length == 0) { LengthWarning.Visible = true; } else LengthWarning.Visible = false;
            if ( movieYearsInput.Text.Length == 0) { YearWarning.Visible = true; } else YearWarning.Visible = false;


            try
            {
                string Name = movieNameInput.Text;
                string Genre = movieGenreInput.Text;
                int Length = Int16.Parse(movieLengthInput.Text);
                int YearOfPremiere = Int16.Parse(movieYearsInput.Text);

                Movie newMovie = new Movie(Name, Genre, Length, YearOfPremiere);
      
                moviesListBox.Items.Add(newMovie);
                movies.Add(newMovie);
                MessageBox.Show("Uspjesno dodat film !");

                clearMoviesBoxInputs();
                isDataChanged = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            LoadMovies();
            moviesListBox.Items.AddRange(movies.ToArray());
            movieGenreInput.SelectedIndex = 0;
        }

        private void MoviesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isDataChanged)
            {
                DialogResult result = MessageBox.Show("Da li zelite da sacuvate promene", "Upozorenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    saveMovies();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
        }

        private void movieNameInput_TextChanged(object sender, EventArgs e)
        {
            if (movieNameInput.Text.Length == 0) { NameWarning.Visible = true; } else NameWarning.Visible = false;
           
        }

        private void movieLengthInput_TextChanged(object sender, EventArgs e)
        {
            if (movieLengthInput.Text.Length == 0) { LengthWarning.Visible = true; } else LengthWarning.Visible = false;
        }

        private void movieYearsInput_TextChanged(object sender, EventArgs e)
        {
            if (movieYearsInput.Text.Length == 0) { YearWarning.Visible = true; } else YearWarning.Visible = false;
        }
    }
}
