namespace TeamSourceControl.Forms
{
    partial class MoviesWithActors
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
            CbMovie = new ComboBox();
            CbActor = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            BtnPair = new Button();
            BtnMovieActorBack = new Button();
            SuspendLayout();
            // 
            // CbMovie
            // 
            CbMovie.FormattingEnabled = true;
            CbMovie.Location = new Point(87, 28);
            CbMovie.Name = "CbMovie";
            CbMovie.Size = new Size(151, 28);
            CbMovie.TabIndex = 0;
            // 
            // CbActor
            // 
            CbActor.FormattingEnabled = true;
            CbActor.Location = new Point(87, 62);
            CbActor.Name = "CbActor";
            CbActor.Size = new Size(151, 28);
            CbActor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 36);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "Movie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 70);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "Actor:";
            // 
            // BtnPair
            // 
            BtnPair.Location = new Point(33, 108);
            BtnPair.Name = "BtnPair";
            BtnPair.Size = new Size(205, 47);
            BtnPair.TabIndex = 5;
            BtnPair.Text = "Pair Together";
            BtnPair.UseVisualStyleBackColor = true;
            // 
            // BtnMovieActorBack
            // 
            BtnMovieActorBack.Location = new Point(271, 118);
            BtnMovieActorBack.Name = "BtnMovieActorBack";
            BtnMovieActorBack.Size = new Size(75, 37);
            BtnMovieActorBack.TabIndex = 17;
            BtnMovieActorBack.Text = "Back";
            BtnMovieActorBack.UseVisualStyleBackColor = true;
            // 
            // MoviesWithActors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 174);
            Controls.Add(BtnMovieActorBack);
            Controls.Add(BtnPair);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CbActor);
            Controls.Add(CbMovie);
            Name = "MoviesWithActors";
            Text = "Pair Movies w/ Actors";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CbMovie;
        private ComboBox CbActor;
        private Label label2;
        private Label label3;
        private Button BtnPair;
        private Button BtnMovieActorBack;
    }
}