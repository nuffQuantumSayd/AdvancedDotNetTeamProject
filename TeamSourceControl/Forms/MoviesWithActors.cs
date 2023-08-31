using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSourceControl.Forms
{
    public partial class MoviesWithActors : Form
    {
        public MoviesWithActors()
        {
            InitializeComponent();
            // populate movie combobox here
            // populate actor combobox here
        }

        private void BtnPair_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnMovieActorBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
