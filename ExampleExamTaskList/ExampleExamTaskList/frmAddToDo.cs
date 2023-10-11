using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleExamTaskList
{
    public partial class frmAddToDo : Form
    {

        public Action<ToDoItem>? ToDoItemCreated;
        public frmAddToDo()
        {
            InitializeComponent();
            cbbType.Items.Add(typeof(HomeWork).Name);
            cbbType.Items.Add(typeof(OutsideWork).Name);
        }

        private void frmAddToDo_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddToDoItem();
        }

        private void AddToDoItem()
        {

            if (cbbType.GetItemText(cbbType.SelectedItem) == typeof(HomeWork).Name)
            {
                ToDoItemCreated?.Invoke(new HomeWork()
                {
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Executer = txtExecuter.Text,
                    Location = txtLocation.Text,
                    DueDate = dtpCompletionDate.Value
                });
            }
            else if (cbbType.GetItemText(cbbType.SelectedItem) == typeof(OutsideWork).Name)
            {
                ToDoItemCreated?.Invoke(new OutsideWork()
                {
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Executer = txtExecuter.Text,
                    Location = txtLocation.Text,
                    DueDate = dtpCompletionDate.Value
                });
            }
        }
    }
}
