namespace TeamSourceControl.Forms
{
    partial class AddMovie
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtAddTitle = new TextBox();
            CbAddGenre = new ComboBox();
            NudAddHours = new NumericUpDown();
            NudAddMinutes = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            DtpAddRelease = new DateTimePicker();
            CbAddStatus = new ComboBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            BtnAddMovie = new Button();
            BtnAddClear = new Button();
            BtnAddBack = new Button();
            ((System.ComponentModel.ISupportInitialize)NudAddHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudAddMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 19);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 72);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Genre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 229);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Runtime:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 180);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 3;
            label4.Text = "Release Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 125);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 4;
            label5.Text = "Watch Status:";
            // 
            // TxtAddTitle
            // 
            TxtAddTitle.Location = new Point(124, 12);
            TxtAddTitle.Name = "TxtAddTitle";
            TxtAddTitle.Size = new Size(183, 27);
            TxtAddTitle.TabIndex = 5;
            // 
            // CbAddGenre
            // 
            CbAddGenre.FormattingEnabled = true;
            CbAddGenre.Location = new Point(124, 64);
            CbAddGenre.Name = "CbAddGenre";
            CbAddGenre.Size = new Size(183, 28);
            CbAddGenre.TabIndex = 6;
            // 
            // NudAddHours
            // 
            NudAddHours.Location = new Point(124, 222);
            NudAddHours.Name = "NudAddHours";
            NudAddHours.Size = new Size(54, 27);
            NudAddHours.TabIndex = 7;
            // 
            // NudAddMinutes
            // 
            NudAddMinutes.Location = new Point(218, 222);
            NudAddMinutes.Name = "NudAddMinutes";
            NudAddMinutes.Size = new Size(49, 27);
            NudAddMinutes.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(184, 229);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 9;
            label6.Text = "hrs";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(273, 229);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 10;
            label7.Text = "min";
            // 
            // DtpAddRelease
            // 
            DtpAddRelease.CustomFormat = "  MM / dd / yyyy";
            DtpAddRelease.Format = DateTimePickerFormat.Custom;
            DtpAddRelease.Location = new Point(124, 173);
            DtpAddRelease.Name = "DtpAddRelease";
            DtpAddRelease.Size = new Size(183, 27);
            DtpAddRelease.TabIndex = 11;
            // 
            // CbAddStatus
            // 
            CbAddStatus.FormattingEnabled = true;
            CbAddStatus.Location = new Point(124, 117);
            CbAddStatus.Name = "CbAddStatus";
            CbAddStatus.Size = new Size(183, 28);
            CbAddStatus.TabIndex = 12;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // BtnAddMovie
            // 
            BtnAddMovie.Location = new Point(341, 33);
            BtnAddMovie.Name = "BtnAddMovie";
            BtnAddMovie.Size = new Size(168, 46);
            BtnAddMovie.TabIndex = 13;
            BtnAddMovie.Text = "Add to Database";
            BtnAddMovie.UseVisualStyleBackColor = true;
            // 
            // BtnAddClear
            // 
            BtnAddClear.Location = new Point(341, 93);
            BtnAddClear.Name = "BtnAddClear";
            BtnAddClear.Size = new Size(168, 46);
            BtnAddClear.TabIndex = 14;
            BtnAddClear.Text = "Clear Form";
            BtnAddClear.UseVisualStyleBackColor = true;
            // 
            // BtnAddBack
            // 
            BtnAddBack.Location = new Point(428, 212);
            BtnAddBack.Name = "BtnAddBack";
            BtnAddBack.Size = new Size(75, 37);
            BtnAddBack.TabIndex = 15;
            BtnAddBack.Text = "Back";
            BtnAddBack.UseVisualStyleBackColor = true;
            // 
            // AddMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 273);
            Controls.Add(BtnAddBack);
            Controls.Add(BtnAddClear);
            Controls.Add(BtnAddMovie);
            Controls.Add(CbAddStatus);
            Controls.Add(DtpAddRelease);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(NudAddMinutes);
            Controls.Add(NudAddHours);
            Controls.Add(CbAddGenre);
            Controls.Add(TxtAddTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddMovie";
            Text = "Add Movie";
            ((System.ComponentModel.ISupportInitialize)NudAddHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudAddMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtAddTitle;
        private ComboBox CbAddGenre;
        private NumericUpDown NudAddHours;
        private NumericUpDown NudAddMinutes;
        private Label label6;
        private Label label7;
        private DateTimePicker DtpAddRelease;
        private ComboBox CbAddStatus;
        private FileSystemWatcher fileSystemWatcher1;
        private Button BtnAddMovie;
        private Button BtnAddBack;
        private Button BtnAddClear;
    }
}