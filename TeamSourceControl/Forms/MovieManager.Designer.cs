﻿namespace TeamSourceControl
{
    partial class MovieManager
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
            CbSort = new ComboBox();
            BtnAdd = new Button();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            BtnMovieWithActor = new Button();
            BtnSee = new Button();
            groupBox1 = new GroupBox();
            BtnActor = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LbMovieList
            // 
            LbMovieList.FormattingEnabled = true;
            LbMovieList.ItemHeight = 20;
            LbMovieList.Location = new Point(33, 71);
            LbMovieList.Name = "LbMovieList";
            LbMovieList.Size = new Size(337, 364);
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
            // CbSort
            // 
            CbSort.FormattingEnabled = true;
            CbSort.Location = new Point(101, 23);
            CbSort.Name = "CbSort";
            CbSort.Size = new Size(269, 28);
            CbSort.TabIndex = 2;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(27, 94);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(165, 62);
            BtnAdd.TabIndex = 3;
            BtnAdd.Text = "Add Movie";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(27, 162);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(165, 62);
            BtnUpdate.TabIndex = 4;
            BtnUpdate.Text = "Update Movie";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(27, 230);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(165, 62);
            BtnDelete.TabIndex = 5;
            BtnDelete.Text = "Delete Movie";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnMovieWithActor
            // 
            BtnMovieWithActor.Location = new Point(389, 339);
            BtnMovieWithActor.Name = "BtnMovieWithActor";
            BtnMovieWithActor.Size = new Size(219, 46);
            BtnMovieWithActor.TabIndex = 6;
            BtnMovieWithActor.Text = "Movie Actor Pairing";
            BtnMovieWithActor.UseVisualStyleBackColor = true;
            BtnMovieWithActor.Click += BtnMovieWithActor_Click;
            // 
            // BtnSee
            // 
            BtnSee.Location = new Point(27, 26);
            BtnSee.Name = "BtnSee";
            BtnSee.Size = new Size(165, 62);
            BtnSee.TabIndex = 7;
            BtnSee.Text = "See Movie Info";
            BtnSee.UseVisualStyleBackColor = true;
            BtnSee.Click += BtnSee_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnAdd);
            groupBox1.Controls.Add(BtnSee);
            groupBox1.Controls.Add(BtnDelete);
            groupBox1.Controls.Add(BtnUpdate);
            groupBox1.Location = new Point(389, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 304);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Movie Functions";
            // 
            // BtnActor
            // 
            BtnActor.Location = new Point(389, 391);
            BtnActor.Name = "BtnActor";
            BtnActor.Size = new Size(219, 44);
            BtnActor.TabIndex = 9;
            BtnActor.Text = "Manage Actors";
            BtnActor.UseVisualStyleBackColor = true;
            BtnActor.Click += BtnActor_Click;
            // 
            // MovieManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 469);
            Controls.Add(BtnActor);
            Controls.Add(groupBox1);
            Controls.Add(BtnMovieWithActor);
            Controls.Add(CbSort);
            Controls.Add(label1);
            Controls.Add(LbMovieList);
            Name = "MovieManager";
            Text = "Movie Manager";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LbMovieList;
        private Label label1;
        private ComboBox CbSort;
        private Button BtnAdd;
        private Button BtnUpdate;
        private Button BtnDelete;
        private Button BtnMovieWithActor;
        private Button BtnSee;
        private GroupBox groupBox1;
        private Button BtnActor;
    }
}