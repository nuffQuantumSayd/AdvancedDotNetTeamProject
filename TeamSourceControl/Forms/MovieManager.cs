using TeamSourceControl.Forms;
using TeamSourceControl.Models;

namespace TeamSourceControl
{
    public partial class MovieManager : Form
    {
        public MovieManager()
        {
            InitializeComponent();
            PopulateMovies();
        }
        private void PopulateMovies()
        {
            LbMovieList.Items.Clear();
            LbMovieList.DisplayMember = "Title";

            List<Movie> movies = MovieDb.GetAll();
            foreach (Movie m in movies)
            {
                LbMovieList.Items.Add(m);
            }
        }


        private void BtnSee_Click(object sender, EventArgs e)
        {
            // get selected movie
            Movie selectedMovie = (Movie)LbMovieList.SelectedItem;

            // pass it to read form
            SeeMovie seeMovie = new SeeMovie(selectedMovie);
            seeMovie.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.ShowDialog();

            // re-populate movies
            PopulateMovies();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // get selected movie
            Movie selectedMovie = (Movie)LbMovieList.SelectedItem;

            // pass it to update form
            UpdateMovie updateMovie = new UpdateMovie(selectedMovie);
            updateMovie.ShowDialog();

            // populate movies again
            PopulateMovies();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // get selected movie
            Movie selectedMovie = (Movie)LbMovieList.SelectedItem;

            // delete confirmation prompt
            var choice = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choice == DialogResult.Yes)
            {
                // delete if yes:
                MovieDb.Delete(selectedMovie);
                MessageBox.Show("Movie deleted from database!");
            }
            else
            {
                // nothing if no
                return;
            }

            // populate movies again
            PopulateMovies();
        }

        private void BtnMovieWithActor_Click(object sender, EventArgs e)
        {
            MoviesWithActors moviesWithActors = new MoviesWithActors();
            moviesWithActors.ShowDialog();
        }

        private void BtnActor_Click(object sender, EventArgs e)
        {
            ActorManager actorManager = new ActorManager();
            actorManager.ShowDialog();
        }
    }
}