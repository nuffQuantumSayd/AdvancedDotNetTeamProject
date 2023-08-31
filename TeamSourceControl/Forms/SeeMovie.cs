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
    public partial class SeeMovie : Form
    {
        public SeeMovie()
        {
            InitializeComponent();
            // populate list of actors in movie here
        }

        private void BtnSeeBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
