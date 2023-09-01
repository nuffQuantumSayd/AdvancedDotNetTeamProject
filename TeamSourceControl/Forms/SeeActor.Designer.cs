namespace TeamSourceControl.Forms
{
    partial class SeeActor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LbActorMovies = new ListBox();
            TxtSeeName = new TextBox();
            label1 = new Label();
            ChkSeeFollow = new CheckBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // LbActorMovies
            // 
            LbActorMovies.FormattingEnabled = true;
            LbActorMovies.ItemHeight = 20;
            LbActorMovies.Location = new Point(38, 99);
            LbActorMovies.Name = "LbActorMovies";
            LbActorMovies.Size = new Size(341, 184);
            LbActorMovies.TabIndex = 43;
            // 
            // TxtSeeName
            // 
            TxtSeeName.Enabled = false;
            TxtSeeName.Location = new Point(94, 26);
            TxtSeeName.Name = "TxtSeeName";
            TxtSeeName.Size = new Size(183, 27);
            TxtSeeName.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 29);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 32;
            label1.Text = "Name:";
            // 
            // ChkSeeFollow
            // 
            ChkSeeFollow.AutoSize = true;
            ChkSeeFollow.Enabled = false;
            ChkSeeFollow.Location = new Point(283, 29);
            ChkSeeFollow.Name = "ChkSeeFollow";
            ChkSeeFollow.Size = new Size(96, 24);
            ChkSeeFollow.TabIndex = 44;
            ChkSeeFollow.Text = "Following";
            ChkSeeFollow.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 76);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 45;
            label2.Text = "Seen in:";
            // 
            // SeeActor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 309);
            Controls.Add(label2);
            Controls.Add(ChkSeeFollow);
            Controls.Add(LbActorMovies);
            Controls.Add(TxtSeeName);
            Controls.Add(label1);
            Name = "SeeActor";
            Text = "SeeActor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LbActorMovies;
        private TextBox TxtSeeName;
        private Label label1;
        private CheckBox ChkSeeFollow;
        private Label label2;
    }
}