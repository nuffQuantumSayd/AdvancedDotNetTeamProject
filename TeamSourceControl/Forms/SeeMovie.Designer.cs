namespace TeamSourceControl.Forms
{
    partial class SeeMovie
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
            TxtSeeTitle = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnSeeBack = new Button();
            TxtSeeGenre = new TextBox();
            TxtSeeStatus = new TextBox();
            TxtSeeRelease = new TextBox();
            TxtSeeRuntime = new TextBox();
            LbMovieActors = new ListBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // TxtSeeTitle
            // 
            TxtSeeTitle.Enabled = false;
            TxtSeeTitle.Location = new Point(133, 23);
            TxtSeeTitle.Name = "TxtSeeTitle";
            TxtSeeTitle.Size = new Size(183, 27);
            TxtSeeTitle.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 136);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 17;
            label5.Text = "Watch Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 191);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 16;
            label4.Text = "Release Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 240);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 15;
            label3.Text = "Runtime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 83);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 14;
            label2.Text = "Genre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 30);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 13;
            label1.Text = "Title:";
            // 
            // BtnSeeBack
            // 
            BtnSeeBack.Location = new Point(504, 233);
            BtnSeeBack.Name = "BtnSeeBack";
            BtnSeeBack.Size = new Size(75, 37);
            BtnSeeBack.TabIndex = 26;
            BtnSeeBack.Text = "Back";
            BtnSeeBack.UseVisualStyleBackColor = true;
            BtnSeeBack.Click += BtnSeeBack_Click;
            // 
            // TxtSeeGenre
            // 
            TxtSeeGenre.Enabled = false;
            TxtSeeGenre.Location = new Point(133, 76);
            TxtSeeGenre.Name = "TxtSeeGenre";
            TxtSeeGenre.Size = new Size(183, 27);
            TxtSeeGenre.TabIndex = 27;
            // 
            // TxtSeeStatus
            // 
            TxtSeeStatus.Enabled = false;
            TxtSeeStatus.Location = new Point(133, 129);
            TxtSeeStatus.Name = "TxtSeeStatus";
            TxtSeeStatus.Size = new Size(183, 27);
            TxtSeeStatus.TabIndex = 28;
            // 
            // TxtSeeRelease
            // 
            TxtSeeRelease.Enabled = false;
            TxtSeeRelease.Location = new Point(133, 184);
            TxtSeeRelease.Name = "TxtSeeRelease";
            TxtSeeRelease.Size = new Size(183, 27);
            TxtSeeRelease.TabIndex = 29;
            // 
            // TxtSeeRuntime
            // 
            TxtSeeRuntime.Enabled = false;
            TxtSeeRuntime.Location = new Point(133, 233);
            TxtSeeRuntime.Name = "TxtSeeRuntime";
            TxtSeeRuntime.Size = new Size(183, 27);
            TxtSeeRuntime.TabIndex = 30;
            // 
            // LbMovieActors
            // 
            LbMovieActors.FormattingEnabled = true;
            LbMovieActors.ItemHeight = 20;
            LbMovieActors.Location = new Point(340, 38);
            LbMovieActors.Name = "LbMovieActors";
            LbMovieActors.Size = new Size(239, 184);
            LbMovieActors.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(340, 15);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 32;
            label8.Text = "Actors:";
            // 
            // SeeMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 288);
            Controls.Add(label8);
            Controls.Add(LbMovieActors);
            Controls.Add(TxtSeeRuntime);
            Controls.Add(TxtSeeRelease);
            Controls.Add(TxtSeeStatus);
            Controls.Add(TxtSeeGenre);
            Controls.Add(BtnSeeBack);
            Controls.Add(TxtSeeTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SeeMovie";
            Text = "Movie Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CbAddStatus;
        private DateTimePicker DtpAddRelease;
        private Label label7;
        private Label label6;
        private NumericUpDown NudAddMinutes;
        private NumericUpDown NudAddHours;
        private ComboBox CbAddGenre;
        private TextBox TxtSeeTitle;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnSeeBack;
        private TextBox TxtSeeGenre;
        private TextBox TxtSeeStatus;
        private TextBox TxtSeeRelease;
        private TextBox TxtSeeRuntime;
        private ListBox LbMovieActors;
        private Label label8;
    }
}