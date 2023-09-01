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
    public partial class ActorManager : Form
    {
        public ActorManager()
        {
            InitializeComponent();
            PopulateActors();
        }
        private void PopulateActors()
        {
            LbActorList.Items.Clear();

            List<Actor> actors = ActorDb.GetAll();
            foreach (Actor a in actors)
            {
                LbActorList.Items.Add(a);
            }
        }

        private void BtnSeeActor_Click(object sender, EventArgs e)
        {
            // get selected actor
            Actor selectedActor = (Actor)LbActorList.SelectedItem;

            // pass it to read form
            SeeActor seeActor = new SeeActor(selectedActor);
            seeActor.ShowDialog();
        }

        private void BtnAddActor_Click(object sender, EventArgs e)
        {
            AddActor addActor = new AddActor();
            addActor.ShowDialog();

            // populate again
            PopulateActors();
        }

        private void BtnUpdateActor_Click(object sender, EventArgs e)
        {
            // get selected actor
            Actor selectedActor = (Actor)LbActorList.SelectedItem;

            // pass it to update form
            UpdateActor updateActor = new UpdateActor(selectedActor);
            updateActor.ShowDialog();

            // populate again
            PopulateActors();
        }

        private void BtnDeleteActor_Click(object sender, EventArgs e)
        {
            // get selected actor
            Actor selectedActor = (Actor)LbActorList.SelectedItem;

            // delete confirmation prompt
            var choice = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (choice == DialogResult.Yes)
            {
                // delete if yes
                ActorDb.Delete(selectedActor);
                MessageBox.Show("Actor deleted from database!");
            }
            else
            {
                // nothing if no
                return;
            }
        }
    }
}
