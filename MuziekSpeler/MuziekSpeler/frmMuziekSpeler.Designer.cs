namespace MuziekSpeler
{
    partial class frmMuziekSpeler
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
            label1 = new Label();
            cbLiedjes = new ComboBox();
            btnSpeel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 0;
            label1.Text = "Liedje";
            // 
            // cbLiedjes
            // 
            cbLiedjes.FormattingEnabled = true;
            cbLiedjes.Location = new Point(75, 6);
            cbLiedjes.Name = "cbLiedjes";
            cbLiedjes.Size = new Size(266, 33);
            cbLiedjes.TabIndex = 1;
            // 
            // btnSpeel
            // 
            btnSpeel.Location = new Point(12, 45);
            btnSpeel.Name = "btnSpeel";
            btnSpeel.Size = new Size(329, 34);
            btnSpeel.TabIndex = 2;
            btnSpeel.Text = "Speel";
            btnSpeel.UseVisualStyleBackColor = true;
            btnSpeel.Click += btnSpeel_Click;
            // 
            // frmMuziekSpeler
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 96);
            Controls.Add(btnSpeel);
            Controls.Add(cbLiedjes);
            Controls.Add(label1);
            Name = "frmMuziekSpeler";
            Text = "Muziekspeler";
            Load += frmMuziekSpeler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbLiedjes;
        private Button btnSpeel;
    }
}