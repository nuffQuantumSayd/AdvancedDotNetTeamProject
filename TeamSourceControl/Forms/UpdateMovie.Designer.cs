namespace TeamSourceControl.Forms
{
    partial class UpdateMovie
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
            BtnUpdateBack = new Button();
            BtnUpdateMovie = new Button();
            CbUpdateStatus = new ComboBox();
            DtpUpdateRelease = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            NudUpdateMinutes = new NumericUpDown();
            NudUpdateHours = new NumericUpDown();
            CbUpdateGenre = new ComboBox();
            TxtUpdateTitle = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)NudUpdateMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudUpdateHours).BeginInit();
            SuspendLayout();
            // 
            // BtnUpdateBack
            // 
            BtnUpdateBack.Location = new Point(427, 218);
            BtnUpdateBack.Name = "BtnUpdateBack";
            BtnUpdateBack.Size = new Size(75, 37);
            BtnUpdateBack.TabIndex = 31;
            BtnUpdateBack.Text = "Back";
            BtnUpdateBack.UseVisualStyleBackColor = true;
            BtnUpdateBack.Click += BtnUpdateBack_Click;
            // 
            // BtnUpdateMovie
            // 
            BtnUpdateMovie.Location = new Point(334, 51);
            BtnUpdateMovie.Name = "BtnUpdateMovie";
            BtnUpdateMovie.Size = new Size(168, 74);
            BtnUpdateMovie.TabIndex = 29;
            BtnUpdateMovie.Text = "Update in Database";
            BtnUpdateMovie.UseVisualStyleBackColor = true;
            BtnUpdateMovie.Click += BtnUpdateMovie_Click;
            // 
            // CbUpdateStatus
            // 
            CbUpdateStatus.FormattingEnabled = true;
            CbUpdateStatus.Location = new Point(123, 123);
            CbUpdateStatus.Name = "CbUpdateStatus";
            CbUpdateStatus.Size = new Size(183, 28);
            CbUpdateStatus.TabIndex = 28;
            // 
            // DtpUpdateRelease
            // 
            DtpUpdateRelease.CustomFormat = "  MM / dd / yyyy";
            DtpUpdateRelease.Format = DateTimePickerFormat.Custom;
            DtpUpdateRelease.Location = new Point(123, 179);
            DtpUpdateRelease.Name = "DtpUpdateRelease";
            DtpUpdateRelease.Size = new Size(183, 27);
            DtpUpdateRelease.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(272, 235);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 26;
            label7.Text = "min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(183, 235);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 25;
            label6.Text = "hrs";
            // 
            // NudUpdateMinutes
            // 
            NudUpdateMinutes.Location = new Point(217, 228);
            NudUpdateMinutes.Name = "NudUpdateMinutes";
            NudUpdateMinutes.Size = new Size(49, 27);
            NudUpdateMinutes.TabIndex = 24;
            // 
            // NudUpdateHours
            // 
            NudUpdateHours.Location = new Point(123, 228);
            NudUpdateHours.Name = "NudUpdateHours";
            NudUpdateHours.Size = new Size(54, 27);
            NudUpdateHours.TabIndex = 23;
            // 
            // CbUpdateGenre
            // 
            CbUpdateGenre.FormattingEnabled = true;
            CbUpdateGenre.Location = new Point(123, 70);
            CbUpdateGenre.Name = "CbUpdateGenre";
            CbUpdateGenre.Size = new Size(183, 28);
            CbUpdateGenre.TabIndex = 22;
            // 
            // TxtUpdateTitle
            // 
            TxtUpdateTitle.Location = new Point(123, 18);
            TxtUpdateTitle.Name = "TxtUpdateTitle";
            TxtUpdateTitle.Size = new Size(183, 27);
            TxtUpdateTitle.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 131);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 20;
            label5.Text = "Watch Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 186);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 19;
            label4.Text = "Release Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 235);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 18;
            label3.Text = "Runtime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 78);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 17;
            label2.Text = "Genre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 25);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 16;
            label1.Text = "Title:";
            // 
            // UpdateMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 273);
            Controls.Add(BtnUpdateBack);
            Controls.Add(BtnUpdateMovie);
            Controls.Add(CbUpdateStatus);
            Controls.Add(DtpUpdateRelease);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(NudUpdateMinutes);
            Controls.Add(NudUpdateHours);
            Controls.Add(CbUpdateGenre);
            Controls.Add(TxtUpdateTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateMovie";
            Text = "Update Movie";
            ((System.ComponentModel.ISupportInitialize)NudUpdateMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudUpdateHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnUpdateBack;
        private Button BtnClear;
        private Button BtnUpdateMovie;
        private ComboBox CbUpdateStatus;
        private DateTimePicker DtpUpdateRelease;
        private Label label7;
        private Label label6;
        private NumericUpDown NudUpdateMinutes;
        private NumericUpDown NudUpdateHours;
        private ComboBox CbUpdateGenre;
        private TextBox TxtUpdateTitle;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}