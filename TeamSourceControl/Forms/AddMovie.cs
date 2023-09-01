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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            string name = TxtAddTitle.Text;
            string genre = CbAddGenre.Text;
            string status = CbAddStatus.Text;
            DateTime releaseDate = DtpAddRelease.Value.Date;
            TimeSpan runtime = new TimeSpan(Convert.ToInt32(NudAddHours.Value), Convert.ToInt32(NudAddMinutes.Value), 0);

            Movie m = new Movie(name, genre, status, releaseDate, runtime);
            MovieDb.Add(m);

            MessageBox.Show("Movie added to database!");
        }

        private void BtnAddClear_Click(object sender, EventArgs e)
        {
            // clears form
            Controls.Clear();
            InitializeComponent();
        }
    }
}
