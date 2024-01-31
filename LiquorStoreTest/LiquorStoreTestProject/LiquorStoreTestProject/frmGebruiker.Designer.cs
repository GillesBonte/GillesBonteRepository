namespace LiquorStoreTestProject
{
    partial class frmGebruiker
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
            txtGebruiker = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtGebruiker
            // 
            txtGebruiker.Location = new Point(136, 112);
            txtGebruiker.Name = "txtGebruiker";
            txtGebruiker.Size = new Size(325, 31);
            txtGebruiker.TabIndex = 0;
            txtGebruiker.Text = "test";
            // 
            // button1
            // 
            button1.Location = new Point(360, 229);
            button1.Name = "button1";
            button1.Size = new Size(323, 124);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmGebruiker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 450);
            Controls.Add(button1);
            Controls.Add(txtGebruiker);
            Name = "frmGebruiker";
            Text = "Form1";
            Load += frmGebruiker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGebruiker;
        private Button button1;
    }
}
