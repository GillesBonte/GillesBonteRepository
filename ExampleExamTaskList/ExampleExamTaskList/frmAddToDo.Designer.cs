namespace ExampleExamTaskList
{
    partial class frmAddToDo
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbbType = new ComboBox();
            txtName = new TextBox();
            txtExecuter = new TextBox();
            txtLocation = new TextBox();
            dtpCompletionDate = new DateTimePicker();
            label6 = new Label();
            txtDescription = new RichTextBox();
            btnCancel = new Button();
            btnAddClose = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 69);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 111);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Executer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 153);
            label4.Name = "label4";
            label4.Size = new Size(145, 25);
            label4.TabIndex = 3;
            label4.Text = "Completion date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 195);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 4;
            label5.Text = "Location";
            // 
            // cbbType
            // 
            cbbType.FormattingEnabled = true;
            cbbType.Location = new Point(194, 23);
            cbbType.Name = "cbbType";
            cbbType.Size = new Size(343, 33);
            cbbType.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(194, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(343, 31);
            txtName.TabIndex = 6;
            // 
            // txtExecuter
            // 
            txtExecuter.Location = new Point(194, 108);
            txtExecuter.Name = "txtExecuter";
            txtExecuter.Size = new Size(343, 31);
            txtExecuter.TabIndex = 7;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(194, 192);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(343, 31);
            txtLocation.TabIndex = 8;
            // 
            // dtpCompletionDate
            // 
            dtpCompletionDate.Location = new Point(194, 148);
            dtpCompletionDate.Name = "dtpCompletionDate";
            dtpCompletionDate.Size = new Size(343, 31);
            dtpCompletionDate.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(573, 26);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 10;
            label6.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(571, 70);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(354, 153);
            txtDescription.TabIndex = 11;
            txtDescription.Text = "";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(26, 243);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(179, 52);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddClose
            // 
            btnAddClose.Location = new Point(571, 243);
            btnAddClose.Name = "btnAddClose";
            btnAddClose.Size = new Size(169, 52);
            btnAddClose.TabIndex = 13;
            btnAddClose.Text = "Add and Close";
            btnAddClose.UseVisualStyleBackColor = true;
            btnAddClose.Click += btnAddClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(756, 243);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(169, 52);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmAddToDo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 307);
            Controls.Add(btnAdd);
            Controls.Add(btnAddClose);
            Controls.Add(btnCancel);
            Controls.Add(txtDescription);
            Controls.Add(label6);
            Controls.Add(dtpCompletionDate);
            Controls.Add(txtLocation);
            Controls.Add(txtExecuter);
            Controls.Add(txtName);
            Controls.Add(cbbType);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddToDo";
            Text = "Add To Do";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbbType;
        private TextBox txtName;
        private TextBox txtExecuter;
        private TextBox txtLocation;
        private DateTimePicker dtpCompletionDate;
        private Label label6;
        private RichTextBox txtDescription;
        private Button btnCancel;
        private Button btnAddClose;
        private Button btnAdd;
    }
}