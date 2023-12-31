﻿namespace TeamSourceControl.Forms
{
    partial class ActorManager
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
            groupBox1 = new GroupBox();
            BtnAddActor = new Button();
            BtnSeeActor = new Button();
            BtnDeleteActor = new Button();
            BtnUpdateActor = new Button();
            CbSortActor = new ComboBox();
            label1 = new Label();
            LbActorList = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnAddActor);
            groupBox1.Controls.Add(BtnSeeActor);
            groupBox1.Controls.Add(BtnDeleteActor);
            groupBox1.Controls.Add(BtnUpdateActor);
            groupBox1.Location = new Point(400, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 304);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actor Functions";
            // 
            // BtnAddActor
            // 
            BtnAddActor.Location = new Point(27, 94);
            BtnAddActor.Name = "BtnAddActor";
            BtnAddActor.Size = new Size(165, 62);
            BtnAddActor.TabIndex = 3;
            BtnAddActor.Text = "Add Actor";
            BtnAddActor.UseVisualStyleBackColor = true;
            BtnAddActor.Click += BtnAddActor_Click;
            // 
            // BtnSeeActor
            // 
            BtnSeeActor.Location = new Point(27, 26);
            BtnSeeActor.Name = "BtnSeeActor";
            BtnSeeActor.Size = new Size(165, 62);
            BtnSeeActor.TabIndex = 7;
            BtnSeeActor.Text = "See Actor Info";
            BtnSeeActor.UseVisualStyleBackColor = true;
            BtnSeeActor.Click += BtnSeeActor_Click;
            // 
            // BtnDeleteActor
            // 
            BtnDeleteActor.Location = new Point(27, 230);
            BtnDeleteActor.Name = "BtnDeleteActor";
            BtnDeleteActor.Size = new Size(165, 62);
            BtnDeleteActor.TabIndex = 5;
            BtnDeleteActor.Text = "Delete Actor";
            BtnDeleteActor.UseVisualStyleBackColor = true;
            BtnDeleteActor.Click += BtnDeleteActor_Click;
            // 
            // BtnUpdateActor
            // 
            BtnUpdateActor.Location = new Point(27, 162);
            BtnUpdateActor.Name = "BtnUpdateActor";
            BtnUpdateActor.Size = new Size(165, 62);
            BtnUpdateActor.TabIndex = 4;
            BtnUpdateActor.Text = "Update Actor";
            BtnUpdateActor.UseVisualStyleBackColor = true;
            BtnUpdateActor.Click += BtnUpdateActor_Click;
            // 
            // CbSortActor
            // 
            CbSortActor.FormattingEnabled = true;
            CbSortActor.Location = new Point(101, 29);
            CbSortActor.Name = "CbSortActor";
            CbSortActor.Size = new Size(269, 28);
            CbSortActor.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 10;
            label1.Text = "Sort By:";
            // 
            // LbActorList
            // 
            LbActorList.FormattingEnabled = true;
            LbActorList.ItemHeight = 20;
            LbActorList.Location = new Point(33, 77);
            LbActorList.Name = "LbActorList";
            LbActorList.Size = new Size(337, 324);
            LbActorList.TabIndex = 9;
            // 
            // ActorManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 418);
            Controls.Add(groupBox1);
            Controls.Add(CbSortActor);
            Controls.Add(label1);
            Controls.Add(LbActorList);
            Name = "ActorManager";
            Text = "ActorManager";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnAddActor;
        private Button BtnSeeActor;
        private Button BtnDeleteActor;
        private Button BtnUpdateActor;
        private ComboBox CbSortActor;
        private Label label1;
        private ListBox LbActorList;
    }
}