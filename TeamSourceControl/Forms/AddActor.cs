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
    public partial class AddActor : Form
    {
        public AddActor()
        {
            InitializeComponent();
        }

        private void BtnAddActor_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnAddActorClear_Click(object sender, EventArgs e)
        {
            // clears form
            Controls.Clear();
            InitializeComponent();
        }

        private void BtnAddActorBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
