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
    public partial class AddActor : Form
    {
        public AddActor()
        {
            InitializeComponent();
        }

        private void BtnAddActor_Click(object sender, EventArgs e)
        {
            string fname = TxtAddFName.Text;
            string lname = TxtAddLName.Text;
            bool followed;
            if (ChkAddFollow.Checked == true)
            {
                followed = true;
            }
            else
            {
                followed = false;
            }

            Actor a = new Actor(fname, lname, followed);
            ActorDb.Add(a);

            MessageBox.Show("Actor added to database!");
        }

        private void BtnAddActorClear_Click(object sender, EventArgs e)
        {
            // clears form
            Controls.Clear();
            InitializeComponent();
        }
    }
}
