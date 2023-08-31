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
            BtnSeeActorBack = new Button();
            TxtSeeName = new TextBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // LbActorMovies
            // 
            LbActorMovies.FormattingEnabled = true;
            LbActorMovies.ItemHeight = 20;
            LbActorMovies.Location = new Point(38, 91);
            LbActorMovies.Name = "LbActorMovies";
            LbActorMovies.Size = new Size(239, 184);
            LbActorMovies.TabIndex = 43;
            // 
            // BtnSeeActorBack
            // 
            BtnSeeActorBack.Location = new Point(316, 238);
            BtnSeeActorBack.Name = "BtnSeeActorBack";
            BtnSeeActorBack.Size = new Size(75, 37);
            BtnSeeActorBack.TabIndex = 38;
            BtnSeeActorBack.Text = "Back";
            BtnSeeActorBack.UseVisualStyleBackColor = true;
            BtnSeeActorBack.Click += BtnSeeActorBack_Click;
            // 
            // TxtSeeName
            // 
            TxtSeeName.Enabled = false;
            TxtSeeName.Location = new Point(94, 24);
            TxtSeeName.Name = "TxtSeeName";
            TxtSeeName.Size = new Size(183, 27);
            TxtSeeName.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 27);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 32;
            label1.Text = "Name:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(293, 27);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 24);
            checkBox1.TabIndex = 44;
            checkBox1.Text = "Following";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 68);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 45;
            label2.Text = "Seen in:";
            // 
            // SeeActor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 301);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(LbActorMovies);
            Controls.Add(BtnSeeActorBack);
            Controls.Add(TxtSeeName);
            Controls.Add(label1);
            Name = "SeeActor";
            Text = "SeeActor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LbActorMovies;
        private Button BtnSeeActorBack;
        private TextBox TxtSeeName;
        private Label label1;
        private CheckBox checkBox1;
        private Label label2;
    }
}