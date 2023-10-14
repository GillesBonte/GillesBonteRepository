namespace CalculationProgressAsync
{
    partial class frmDataProgress
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
            btnStart = new Button();
            pbCalculations = new ProgressBar();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(15, 13);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(474, 256);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // pbCalculations
            // 
            pbCalculations.Location = new Point(12, 275);
            pbCalculations.Name = "pbCalculations";
            pbCalculations.Size = new Size(477, 28);
            pbCalculations.TabIndex = 1;
            // 
            // frmDataProgress
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 315);
            Controls.Add(pbCalculations);
            Controls.Add(btnStart);
            Name = "frmDataProgress";
            Text = "Calculation Progress";
            ResumeLayout(false);
        }

        #endregion
        private Button btnStart;
        private ProgressBar pbCalculations;
    }
}