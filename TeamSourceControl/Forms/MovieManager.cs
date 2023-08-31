using TeamSourceControl.Forms;

namespace TeamSourceControl
{
    public partial class MovieManager : Form
    {
        public MovieManager()
        {
            InitializeComponent();
            // populate movie list here
        }

        private void BtnSee_Click(object sender, EventArgs e)
        {
            SeeMovie seeMovie = new SeeMovie();
            seeMovie.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.ShowDialog();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateMovie updateMovie = new UpdateMovie();
            updateMovie.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choice == DialogResult.Yes)
            {
                // delete if yes
                throw new NotImplementedException();
            }
            else
            {
                // nothing if no
                return;
            }
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