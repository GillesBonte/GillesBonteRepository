namespace DeVoetbalApp
{
    partial class Form1
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
            this.btnImport = new System.Windows.Forms.Button();
            this.grpFunctions = new System.Windows.Forms.GroupBox();
            this.grpLinq = new System.Windows.Forms.GroupBox();
            this.btnQuery4 = new System.Windows.Forms.Button();
            this.btnQuery3 = new System.Windows.Forms.Button();
            this.btnQuery2 = new System.Windows.Forms.Button();
            this.btnQuery1 = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.grpFunctions.SuspendLayout();
            this.grpLinq.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(6, 26);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(261, 59);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import players";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // grpFunctions
            // 
            this.grpFunctions.Controls.Add(this.btnImport);
            this.grpFunctions.Location = new System.Drawing.Point(515, 12);
            this.grpFunctions.Name = "grpFunctions";
            this.grpFunctions.Size = new System.Drawing.Size(273, 95);
            this.grpFunctions.TabIndex = 1;
            this.grpFunctions.TabStop = false;
            this.grpFunctions.Text = "Functions";
            // 
            // grpLinq
            // 
            this.grpLinq.Controls.Add(this.btnQuery4);
            this.grpLinq.Controls.Add(this.btnQuery3);
            this.grpLinq.Controls.Add(this.btnQuery2);
            this.grpLinq.Controls.Add(this.btnQuery1);
            this.grpLinq.Location = new System.Drawing.Point(515, 113);
            this.grpLinq.Name = "grpLinq";
            this.grpLinq.Size = new System.Drawing.Size(273, 294);
            this.grpLinq.TabIndex = 2;
            this.grpLinq.TabStop = false;
            this.grpLinq.Text = "Linq queries";
            // 
            // btnQuery4
            // 
            this.btnQuery4.Location = new System.Drawing.Point(6, 221);
            this.btnQuery4.Name = "btnQuery4";
            this.btnQuery4.Size = new System.Drawing.Size(261, 59);
            this.btnQuery4.TabIndex = 4;
            this.btnQuery4.Text = "Query 4";
            this.btnQuery4.UseVisualStyleBackColor = true;
            this.btnQuery4.Click += new System.EventHandler(this.btnQuery4_Click);
            // 
            // btnQuery3
            // 
            this.btnQuery3.Location = new System.Drawing.Point(6, 156);
            this.btnQuery3.Name = "btnQuery3";
            this.btnQuery3.Size = new System.Drawing.Size(261, 59);
            this.btnQuery3.TabIndex = 3;
            this.btnQuery3.Text = "Query 3";
            this.btnQuery3.UseVisualStyleBackColor = true;
            this.btnQuery3.Click += new System.EventHandler(this.btnQuery3_Click);
            // 
            // btnQuery2
            // 
            this.btnQuery2.Location = new System.Drawing.Point(6, 91);
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Size = new System.Drawing.Size(261, 59);
            this.btnQuery2.TabIndex = 2;
            this.btnQuery2.Text = "Query 2";
            this.btnQuery2.UseVisualStyleBackColor = true;
            this.btnQuery2.Click += new System.EventHandler(this.btnQuery2_Click);
            // 
            // btnQuery1
            // 
            this.btnQuery1.Location = new System.Drawing.Point(6, 26);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(261, 59);
            this.btnQuery1.TabIndex = 1;
            this.btnQuery1.Text = "Query 1";
            this.btnQuery1.UseVisualStyleBackColor = true;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.txtResult);
            this.grpResult.Location = new System.Drawing.Point(12, 12);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(497, 395);
            this.grpResult.TabIndex = 3;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(6, 26);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(485, 355);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpLinq);
            this.Controls.Add(this.grpFunctions);
            this.Name = "Form1";
            this.Text = "Voetball app";
            this.grpFunctions.ResumeLayout(false);
            this.grpLinq.ResumeLayout(false);
            this.grpResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnImport;
        private GroupBox grpFunctions;
        private GroupBox grpLinq;
        private Button btnQuery4;
        private Button btnQuery3;
        private Button btnQuery2;
        private Button btnQuery1;
        private GroupBox grpResult;
        private RichTextBox txtResult;
    }
}