namespace TicTacToe
{
    partial class frmTicTacToe
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
            panel1 = new Panel();
            btnBotRight = new Button();
            btnBotMid = new Button();
            btnBotLeft = new Button();
            btnMidRight = new Button();
            btnMidMid = new Button();
            btnMidLeft = new Button();
            btnTopRight = new Button();
            btnTopMid = new Button();
            btnTopLeft = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBotRight);
            panel1.Controls.Add(btnBotMid);
            panel1.Controls.Add(btnBotLeft);
            panel1.Controls.Add(btnMidRight);
            panel1.Controls.Add(btnMidMid);
            panel1.Controls.Add(btnMidLeft);
            panel1.Controls.Add(btnTopRight);
            panel1.Controls.Add(btnTopMid);
            panel1.Controls.Add(btnTopLeft);
            panel1.Location = new Point(15, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 470);
            panel1.TabIndex = 0;
            // 
            // btnBotRight
            // 
            btnBotRight.Location = new Point(374, 314);
            btnBotRight.Name = "btnBotRight";
            btnBotRight.Size = new Size(174, 143);
            btnBotRight.TabIndex = 8;
            btnBotRight.UseVisualStyleBackColor = true;
            btnBotRight.Click += btnPlay_Click;
            // 
            // btnBotMid
            // 
            btnBotMid.Location = new Point(194, 314);
            btnBotMid.Name = "btnBotMid";
            btnBotMid.Size = new Size(174, 143);
            btnBotMid.TabIndex = 7;
            btnBotMid.UseVisualStyleBackColor = true;
            btnBotMid.Click += btnPlay_Click;
            // 
            // btnBotLeft
            // 
            btnBotLeft.Location = new Point(14, 314);
            btnBotLeft.Name = "btnBotLeft";
            btnBotLeft.Size = new Size(174, 143);
            btnBotLeft.TabIndex = 6;
            btnBotLeft.UseVisualStyleBackColor = true;
            btnBotLeft.Click += btnPlay_Click;
            // 
            // btnMidRight
            // 
            btnMidRight.Location = new Point(374, 165);
            btnMidRight.Name = "btnMidRight";
            btnMidRight.Size = new Size(174, 143);
            btnMidRight.TabIndex = 5;
            btnMidRight.UseVisualStyleBackColor = true;
            btnMidRight.Click += btnPlay_Click;
            // 
            // btnMidMid
            // 
            btnMidMid.Location = new Point(194, 165);
            btnMidMid.Name = "btnMidMid";
            btnMidMid.Size = new Size(174, 143);
            btnMidMid.TabIndex = 4;
            btnMidMid.UseVisualStyleBackColor = true;
            btnMidMid.Click += btnPlay_Click;
            // 
            // btnMidLeft
            // 
            btnMidLeft.Location = new Point(14, 165);
            btnMidLeft.Name = "btnMidLeft";
            btnMidLeft.Size = new Size(174, 143);
            btnMidLeft.TabIndex = 3;
            btnMidLeft.UseVisualStyleBackColor = true;
            btnMidLeft.Click += btnPlay_Click;
            // 
            // btnTopRight
            // 
            btnTopRight.Location = new Point(374, 16);
            btnTopRight.Name = "btnTopRight";
            btnTopRight.Size = new Size(174, 143);
            btnTopRight.TabIndex = 2;
            btnTopRight.UseVisualStyleBackColor = true;
            btnTopRight.Click += btnPlay_Click;
            // 
            // btnTopMid
            // 
            btnTopMid.Location = new Point(194, 16);
            btnTopMid.Name = "btnTopMid";
            btnTopMid.Size = new Size(174, 143);
            btnTopMid.TabIndex = 1;
            btnTopMid.UseVisualStyleBackColor = true;
            btnTopMid.Click += btnPlay_Click;
            // 
            // btnTopLeft
            // 
            btnTopLeft.Location = new Point(14, 16);
            btnTopLeft.Name = "btnTopLeft";
            btnTopLeft.Size = new Size(174, 143);
            btnTopLeft.TabIndex = 0;
            btnTopLeft.UseVisualStyleBackColor = true;
            btnTopLeft.Click += btnPlay_Click;
            // 
            // frmTicTacToe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 533);
            Controls.Add(panel1);
            Name = "frmTicTacToe";
            Text = "Tic Tac Toe";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBotRight;
        private Button btnBotMid;
        private Button btnBotLeft;
        private Button btnMidRight;
        private Button btnMidMid;
        private Button btnMidLeft;
        private Button btnTopRight;
        private Button btnTopMid;
        private Button btnTopLeft;
    }
}