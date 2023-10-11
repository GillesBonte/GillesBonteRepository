namespace ExampleExamTaskList
{
    partial class frmToDo
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
            lstbToDo = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAddToDo = new Button();
            btnGroupByWeek = new Button();
            btnImportToDo = new Button();
            btnCompleteToDo = new Button();
            btnGroupByExecuter = new Button();
            btnCompleted = new Button();
            btnToComplete = new Button();
            SuspendLayout();
            // 
            // lstbToDo
            // 
            lstbToDo.FormattingEnabled = true;
            lstbToDo.ItemHeight = 25;
            lstbToDo.Location = new Point(14, 64);
            lstbToDo.Name = "lstbToDo";
            lstbToDo.Size = new Size(534, 554);
            lstbToDo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "To Do:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(686, 64);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 2;
            label2.Text = "ACTIES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(686, 252);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 3;
            label3.Text = "FILTERS";
            // 
            // btnAddToDo
            // 
            btnAddToDo.Location = new Point(554, 92);
            btnAddToDo.Name = "btnAddToDo";
            btnAddToDo.Size = new Size(334, 45);
            btnAddToDo.TabIndex = 4;
            btnAddToDo.Text = "Add To Do";
            btnAddToDo.UseVisualStyleBackColor = true;
            // 
            // btnGroupByWeek
            // 
            btnGroupByWeek.Location = new Point(554, 280);
            btnGroupByWeek.Name = "btnGroupByWeek";
            btnGroupByWeek.Size = new Size(334, 45);
            btnGroupByWeek.TabIndex = 5;
            btnGroupByWeek.Text = "Group By Week";
            btnGroupByWeek.UseVisualStyleBackColor = true;
            // 
            // btnImportToDo
            // 
            btnImportToDo.Location = new Point(554, 194);
            btnImportToDo.Name = "btnImportToDo";
            btnImportToDo.Size = new Size(334, 45);
            btnImportToDo.TabIndex = 6;
            btnImportToDo.Text = "Import To Do List";
            btnImportToDo.UseVisualStyleBackColor = true;
            // 
            // btnCompleteToDo
            // 
            btnCompleteToDo.Location = new Point(554, 143);
            btnCompleteToDo.Name = "btnCompleteToDo";
            btnCompleteToDo.Size = new Size(334, 45);
            btnCompleteToDo.TabIndex = 7;
            btnCompleteToDo.Text = "Complete To Do";
            btnCompleteToDo.UseVisualStyleBackColor = true;
            // 
            // btnGroupByExecuter
            // 
            btnGroupByExecuter.Location = new Point(554, 331);
            btnGroupByExecuter.Name = "btnGroupByExecuter";
            btnGroupByExecuter.Size = new Size(334, 45);
            btnGroupByExecuter.TabIndex = 8;
            btnGroupByExecuter.Text = "Group By Executer";
            btnGroupByExecuter.UseVisualStyleBackColor = true;
            // 
            // btnCompleted
            // 
            btnCompleted.Location = new Point(554, 382);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(334, 45);
            btnCompleted.TabIndex = 9;
            btnCompleted.Text = "Completed To Do's";
            btnCompleted.UseVisualStyleBackColor = true;
            // 
            // btnToComplete
            // 
            btnToComplete.Location = new Point(554, 433);
            btnToComplete.Name = "btnToComplete";
            btnToComplete.Size = new Size(334, 45);
            btnToComplete.TabIndex = 10;
            btnToComplete.Text = "To Complete (7 days)";
            btnToComplete.UseVisualStyleBackColor = true;
            // 
            // frmToDo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 626);
            Controls.Add(btnToComplete);
            Controls.Add(btnCompleted);
            Controls.Add(btnGroupByExecuter);
            Controls.Add(btnCompleteToDo);
            Controls.Add(btnImportToDo);
            Controls.Add(btnGroupByWeek);
            Controls.Add(btnAddToDo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstbToDo);
            Name = "frmToDo";
            Text = "To Do";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstbToDo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAddToDo;
        private Button btnGroupByWeek;
        private Button btnImportToDo;
        private Button btnCompleteToDo;
        private Button btnGroupByExecuter;
        private Button btnCompleted;
        private Button btnToComplete;
    }
}