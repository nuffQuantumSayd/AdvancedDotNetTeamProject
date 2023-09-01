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
    public partial class SeeMovie : Form
    {
        public SeeMovie(Movie m)
        {
            InitializeComponent();
            PopulateControls(m);
            // populate list of actors in movie here
        }

        private void PopulateControls(Movie m)
        {
            // setting controls to object's current property values
            TxtSeeTitle.Text = m.Title;
            TxtSeeGenre.Text = m.Genre;
            TxtSeeStatus.Text = m.Status;
            TxtSeeRelease.Text = m.ReleaseDate.ToString("MMMM d, yyyy");
            TxtSeeRuntime.Text = $"{m.RunTime.Hours} hours, {m.RunTime.Minutes} minutes";
        }
    }
}
