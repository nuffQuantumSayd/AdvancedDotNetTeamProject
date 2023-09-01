using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamSourceControl.Models;

namespace TeamSourceControl.Forms
{
    public partial class UpdateMovie : Form
    {
        private Movie movieToUpdate;

        public UpdateMovie(Movie m)
        {
            InitializeComponent();
            PopulateControls(m);

        }

        private void PopulateControls(Movie m)
        {
            // setting controls to object's current property values
            TxtUpdateTitle.Text = m.Title;
            CbUpdateGenre.SelectedItem = m.Genre;
            CbUpdateStatus.SelectedItem = m.Status;
            DtpUpdateRelease.Value = m.ReleaseDate;
            NudUpdateHours.Value = m.RunTime.Hours;
            NudUpdateMinutes.Value = m.RunTime.Minutes;

            // store movie for later use
            movieToUpdate = m;
        }

        private void BtnUpdateMovie_Click(object sender, EventArgs e)
        {
            string title = TxtUpdateTitle.Text;
            string genre = CbUpdateGenre.Text;
            string status = CbUpdateStatus.Text;
            DateTime releaseDate = DtpUpdateRelease.Value.Date;
            TimeSpan runtime = new TimeSpan(Convert.ToInt32(NudUpdateHours.Value), Convert.ToInt32(NudUpdateMinutes.Value), 0);

            Movie modifiedMovie = new Movie(title, genre, status, releaseDate, runtime);
            modifiedMovie.MovieId = movieToUpdate.MovieId;

            MovieDb.Update(modifiedMovie);

            MessageBox.Show("Movie updated in database!");
            Close();
        }
    }
}
