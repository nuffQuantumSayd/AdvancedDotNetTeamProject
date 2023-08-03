namespace TeamSourceControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LbMovieList = new ListBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            BtnAddMovie = new Button();
            BtnUpdateMovie = new Button();
            BtnDeleteMovie = new Button();
            BtnManageMovieActors = new Button();
            BtnSeeMovie = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LbMovieList
            // 
            LbMovieList.FormattingEnabled = true;
            LbMovieList.ItemHeight = 20;
            LbMovieList.Location = new Point(33, 71);
            LbMovieList.Name = "LbMovieList";
            LbMovieList.Size = new Size(337, 324);
            LbMovieList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 26);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Sort By:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(269, 28);
            comboBox1.TabIndex = 2;
            // 
            // BtnAddMovie
            // 
            BtnAddMovie.Location = new Point(27, 94);
            BtnAddMovie.Name = "BtnAddMovie";
            BtnAddMovie.Size = new Size(165, 62);
            BtnAddMovie.TabIndex = 3;
            BtnAddMovie.Text = "Add Movie";
            BtnAddMovie.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateMovie
            // 
            BtnUpdateMovie.Location = new Point(27, 162);
            BtnUpdateMovie.Name = "BtnUpdateMovie";
            BtnUpdateMovie.Size = new Size(165, 62);
            BtnUpdateMovie.TabIndex = 4;
            BtnUpdateMovie.Text = "Update Movie";
            BtnUpdateMovie.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteMovie
            // 
            BtnDeleteMovie.Location = new Point(27, 230);
            BtnDeleteMovie.Name = "BtnDeleteMovie";
            BtnDeleteMovie.Size = new Size(165, 62);
            BtnDeleteMovie.TabIndex = 5;
            BtnDeleteMovie.Text = "Delete Movie";
            BtnDeleteMovie.UseVisualStyleBackColor = true;
            // 
            // BtnManageMovieActors
            // 
            BtnManageMovieActors.Location = new Point(389, 333);
            BtnManageMovieActors.Name = "BtnManageMovieActors";
            BtnManageMovieActors.Size = new Size(219, 62);
            BtnManageMovieActors.TabIndex = 6;
            BtnManageMovieActors.Text = "Manage Movie Actors";
            BtnManageMovieActors.UseVisualStyleBackColor = true;
            // 
            // BtnSeeMovie
            // 
            BtnSeeMovie.Location = new Point(27, 26);
            BtnSeeMovie.Name = "BtnSeeMovie";
            BtnSeeMovie.Size = new Size(165, 62);
            BtnSeeMovie.TabIndex = 7;
            BtnSeeMovie.Text = "See Movie Info";
            BtnSeeMovie.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnAddMovie);
            groupBox1.Controls.Add(BtnSeeMovie);
            groupBox1.Controls.Add(BtnDeleteMovie);
            groupBox1.Controls.Add(BtnUpdateMovie);
            groupBox1.Location = new Point(389, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 304);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Movie Functions";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 418);
            Controls.Add(groupBox1);
            Controls.Add(BtnManageMovieActors);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(LbMovieList);
            Name = "Form1";
            Text = "Movie Manager";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LbMovieList;
        private Label label1;
        private ComboBox comboBox1;
        private Button BtnAddMovie;
        private Button BtnUpdateMovie;
        private Button BtnDeleteMovie;
        private Button BtnManageMovieActors;
        private Button BtnSeeMovie;
        private GroupBox groupBox1;
    }
}