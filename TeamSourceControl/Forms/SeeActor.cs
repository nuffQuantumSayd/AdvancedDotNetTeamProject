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
    public partial class SeeActor : Form
    {
        public SeeActor()
        {
            InitializeComponent();
            // populate list of movies actor is in here
        }

        private void BtnSeeActorBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
