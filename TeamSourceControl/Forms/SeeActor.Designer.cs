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
            TxtSeeFollowing = new TextBox();
            BtnSeeActorBack = new Button();
            TxtSeeName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // LbActorMovies
            // 
            LbActorMovies.FormattingEnabled = true;
            LbActorMovies.ItemHeight = 20;
            LbActorMovies.Location = new Point(55, 114);
            LbActorMovies.Name = "LbActorMovies";
            LbActorMovies.Size = new Size(239, 184);
            LbActorMovies.TabIndex = 43;
            // 
            // TxtSeeFollowing
            // 
            TxtSeeFollowing.Enabled = false;
            TxtSeeFollowing.Location = new Point(111, 62);
            TxtSeeFollowing.Name = "TxtSeeFollowing";
            TxtSeeFollowing.Size = new Size(183, 27);
            TxtSeeFollowing.TabIndex = 39;
            // 
            // BtnSeeActorBack
            // 
            BtnSeeActorBack.Location = new Point(219, 323);
            BtnSeeActorBack.Name = "BtnSeeActorBack";
            BtnSeeActorBack.Size = new Size(75, 37);
            BtnSeeActorBack.TabIndex = 38;
            BtnSeeActorBack.Text = "Back";
            BtnSeeActorBack.UseVisualStyleBackColor = true;
            // 
            // TxtSeeName
            // 
            TxtSeeName.Enabled = false;
            TxtSeeName.Location = new Point(111, 29);
            TxtSeeName.Name = "TxtSeeName";
            TxtSeeName.Size = new Size(183, 27);
            TxtSeeName.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 65);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 33;
            label2.Text = "Following:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 32);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 32;
            label1.Text = "Name:";
            // 
            // SeeActor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 372);
            Controls.Add(LbActorMovies);
            Controls.Add(TxtSeeFollowing);
            Controls.Add(BtnSeeActorBack);
            Controls.Add(TxtSeeName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SeeActor";
            Text = "SeeActor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LbActorMovies;
        private TextBox TxtSeeFollowing;
        private Button BtnSeeActorBack;
        private TextBox TxtSeeName;
        private Label label2;
        private Label label1;
    }
}