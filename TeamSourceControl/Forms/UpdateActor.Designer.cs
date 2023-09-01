namespace TeamSourceControl.Forms
{
    partial class UpdateActor
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
            BtnUpdateActor = new Button();
            TxtUpdateLName = new TextBox();
            TxtUpdateFName = new TextBox();
            ChkUpdateFollow = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnUpdateActor
            // 
            BtnUpdateActor.Location = new Point(198, 63);
            BtnUpdateActor.Name = "BtnUpdateActor";
            BtnUpdateActor.Size = new Size(168, 63);
            BtnUpdateActor.TabIndex = 22;
            BtnUpdateActor.Text = "Update in Database";
            BtnUpdateActor.UseVisualStyleBackColor = true;
            BtnUpdateActor.Click += BtnUpdateActor_Click;
            // 
            // TxtUpdateLName
            // 
            TxtUpdateLName.Location = new Point(31, 107);
            TxtUpdateLName.Name = "TxtUpdateLName";
            TxtUpdateLName.Size = new Size(125, 27);
            TxtUpdateLName.TabIndex = 21;
            // 
            // TxtUpdateFName
            // 
            TxtUpdateFName.Location = new Point(31, 40);
            TxtUpdateFName.Name = "TxtUpdateFName";
            TxtUpdateFName.Size = new Size(125, 27);
            TxtUpdateFName.TabIndex = 20;
            // 
            // ChkUpdateFollow
            // 
            ChkUpdateFollow.AutoSize = true;
            ChkUpdateFollow.Location = new Point(35, 159);
            ChkUpdateFollow.Name = "ChkUpdateFollow";
            ChkUpdateFollow.Size = new Size(75, 24);
            ChkUpdateFollow.TabIndex = 19;
            ChkUpdateFollow.Text = "Follow";
            ChkUpdateFollow.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 84);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 18;
            label2.Text = "Last name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 16);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 17;
            label1.Text = "First name:";
            // 
            // UpdateActor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 205);
            Controls.Add(BtnUpdateActor);
            Controls.Add(TxtUpdateLName);
            Controls.Add(TxtUpdateFName);
            Controls.Add(ChkUpdateFollow);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateActor";
            Text = "UpdateActor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnUpdateActor;
        private TextBox TxtUpdateLName;
        private TextBox TxtUpdateFName;
        private CheckBox ChkUpdateFollow;
        private Label label2;
        private Label label1;
    }
}