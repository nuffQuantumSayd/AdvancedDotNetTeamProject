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
    public partial class SeeActor : Form
    {
        public SeeActor(Actor a)
        {
            InitializeComponent();
            PopulateControls(a);
            // populate list of movies actor is in here
        }

        private void PopulateControls(Actor a)
        {
            // setting controls to object's current property values
            TxtSeeName.Text = $"{a.FirstName} {a.LastName}";
            if (a.Followed == true)
            {
                ChkSeeFollow.Checked = true;
            }
            else
            {
                ChkSeeFollow.Checked = false;
            }
        }
    }
}
