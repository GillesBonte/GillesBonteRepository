namespace ChatProgramExamPrep
{
    partial class frmMainMenu
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
            btnCreate = new Button();
            btnJoin = new Button();
            lstbRooms = new ListBox();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 12);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 41);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Room";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnJoin
            // 
            btnJoin.Location = new Point(12, 59);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(150, 41);
            btnJoin.TabIndex = 1;
            btnJoin.Text = "Join Room";
            btnJoin.UseVisualStyleBackColor = true;
            // 
            // lstbRooms
            // 
            lstbRooms.FormattingEnabled = true;
            lstbRooms.ItemHeight = 25;
            lstbRooms.Location = new Point(183, 14);
            lstbRooms.Name = "lstbRooms";
            lstbRooms.Size = new Size(340, 279);
            lstbRooms.TabIndex = 2;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 304);
            Controls.Add(lstbRooms);
            Controls.Add(btnJoin);
            Controls.Add(btnCreate);
            Name = "frmMainMenu";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreate;
        private Button btnJoin;
        private ListBox lstbRooms;
    }
}