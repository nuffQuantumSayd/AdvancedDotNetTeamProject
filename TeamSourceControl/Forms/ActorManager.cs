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
    public partial class ActorManager : Form
    {
        public ActorManager()
        {
            InitializeComponent();
            // populate actor list here
        }

        private void BtnSeeActor_Click(object sender, EventArgs e)
        {
            SeeActor seeActor = new SeeActor();
            seeActor.ShowDialog();
        }

        private void BtnAddActor_Click(object sender, EventArgs e)
        {
            AddActor addActor = new AddActor();
            addActor.ShowDialog();
        }

        private void BtnUpdateActor_Click(object sender, EventArgs e)
        {
            UpdateActor updateActor = new UpdateActor();
            updateActor.ShowDialog();
        }

        private void BtnDeleteActor_Click(object sender, EventArgs e)
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

        private void BtnAddActorBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
