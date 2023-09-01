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
    public partial class UpdateActor : Form
    {
        private Actor actorToUpdate;
        public UpdateActor(Actor a)
        {
            InitializeComponent();
            PopulateControls(a);
        }

        private void PopulateControls(Actor a)
        {
            TxtUpdateFName.Text = a.FirstName;
            TxtUpdateLName.Text = a.LastName;
            if (a.Followed == true)
            {
                ChkUpdateFollow.Checked = true;
            }
            else
            {
                ChkUpdateFollow.Checked = false;
            }

            actorToUpdate = a;

        }

        private void BtnUpdateActor_Click(object sender, EventArgs e)
        {
            string fname = TxtUpdateFName.Text;
            string lname = TxtUpdateLName.Text;
            bool followed;
            if (ChkUpdateFollow.Checked == true)
            {
                followed = true;
            }
            else
            {
                followed = false;
            }

            Actor modifiedActor = new Actor(fname, lname, followed);
            modifiedActor.ActorId = actorToUpdate.ActorId;

            ActorDb.Update(modifiedActor);

            MessageBox.Show("Actor updated in database!");
            Close();
        }
    }
}
