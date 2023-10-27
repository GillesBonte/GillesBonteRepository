namespace GUIMultiLayer
{
    partial class frmGUI
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
            btnToonBestanden = new Button();
            btnToonInhoudEersteBestand = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnToonBestanden
            // 
            btnToonBestanden.Location = new Point(91, 49);
            btnToonBestanden.Name = "btnToonBestanden";
            btnToonBestanden.Size = new Size(212, 48);
            btnToonBestanden.TabIndex = 0;
            btnToonBestanden.Text = "Toon Bestanden";
            btnToonBestanden.UseVisualStyleBackColor = true;
            btnToonBestanden.Click += btnToonBestanden_Click;
            // 
            // btnToonInhoudEersteBestand
            // 
            btnToonInhoudEersteBestand.Location = new Point(91, 122);
            btnToonInhoudEersteBestand.Name = "btnToonInhoudEersteBestand";
            btnToonInhoudEersteBestand.Size = new Size(212, 49);
            btnToonInhoudEersteBestand.TabIndex = 1;
            btnToonInhoudEersteBestand.Text = "Toon Eerste Bestand";
            btnToonInhoudEersteBestand.UseVisualStyleBackColor = true;
            btnToonInhoudEersteBestand.Click += btnToonInhoudEersteBestand_Click;
            // 
            // button3
            // 
            button3.Location = new Point(91, 192);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(btnToonInhoudEersteBestand);
            Controls.Add(btnToonBestanden);
            Name = "frmGUI";
            Text = "GUI";
            ResumeLayout(false);
        }

        #endregion

        private Button btnToonBestanden;
        private Button btnToonInhoudEersteBestand;
        private Button button3;
    }
}