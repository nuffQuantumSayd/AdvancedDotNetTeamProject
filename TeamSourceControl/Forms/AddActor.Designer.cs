namespace TeamSourceControl.Forms
{
    partial class AddActor
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
            ChkAddFollow = new CheckBox();
            TxtAddFName = new TextBox();
            TxtAddLName = new TextBox();
            BtnAddActor = new Button();
            BtnAddActorClear = new Button();
            BtnAddActorBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 15);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 83);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last name:";
            // 
            // ChkAddFollow
            // 
            ChkAddFollow.AutoSize = true;
            ChkAddFollow.Location = new Point(34, 158);
            ChkAddFollow.Name = "ChkAddFollow";
            ChkAddFollow.Size = new Size(75, 24);
            ChkAddFollow.TabIndex = 2;
            ChkAddFollow.Text = "Follow";
            ChkAddFollow.UseVisualStyleBackColor = true;
            // 
            // TxtAddFName
            // 
            TxtAddFName.Location = new Point(30, 39);
            TxtAddFName.Name = "TxtAddFName";
            TxtAddFName.Size = new Size(125, 27);
            TxtAddFName.TabIndex = 3;
            // 
            // TxtAddLName
            // 
            TxtAddLName.Location = new Point(30, 106);
            TxtAddLName.Name = "TxtAddLName";
            TxtAddLName.Size = new Size(125, 27);
            TxtAddLName.TabIndex = 4;
            // 
            // BtnAddActor
            // 
            BtnAddActor.Location = new Point(197, 29);
            BtnAddActor.Name = "BtnAddActor";
            BtnAddActor.Size = new Size(168, 46);
            BtnAddActor.TabIndex = 14;
            BtnAddActor.Text = "Add to Database";
            BtnAddActor.UseVisualStyleBackColor = true;
            BtnAddActor.Click += BtnAddActor_Click;
            // 
            // BtnAddActorClear
            // 
            BtnAddActorClear.Location = new Point(197, 81);
            BtnAddActorClear.Name = "BtnAddActorClear";
            BtnAddActorClear.Size = new Size(168, 46);
            BtnAddActorClear.TabIndex = 15;
            BtnAddActorClear.Text = "Clear Form";
            BtnAddActorClear.UseVisualStyleBackColor = true;
            BtnAddActorClear.Click += BtnAddActorClear_Click;
            // 
            // BtnAddActorBack
            // 
            BtnAddActorBack.Location = new Point(290, 145);
            BtnAddActorBack.Name = "BtnAddActorBack";
            BtnAddActorBack.Size = new Size(75, 37);
            BtnAddActorBack.TabIndex = 16;
            BtnAddActorBack.Text = "Back";
            BtnAddActorBack.UseVisualStyleBackColor = true;
            BtnAddActorBack.Click += BtnAddActorBack_Click;
            // 
            // AddActor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 204);
            Controls.Add(BtnAddActorBack);
            Controls.Add(BtnAddActorClear);
            Controls.Add(BtnAddActor);
            Controls.Add(TxtAddLName);
            Controls.Add(TxtAddFName);
            Controls.Add(ChkAddFollow);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddActor";
            Text = "AddActor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox ChkAddFollow;
        private TextBox TxtAddFName;
        private TextBox TxtAddLName;
        private Button BtnAddActor;
        private Button BtnAddActorClear;
        private Button BtnAddActorBack;
    }
}