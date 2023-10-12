using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace ExampleExamTaskList
{
    public partial class frmToDo : Form
    {
        private frmAddToDo _frmAddToDo = new frmAddToDo();
        private ToDoList<ToDoItem> _toDoList;

        public frmToDo()
        {
            InitializeComponent();
            _toDoList = new ToDoList<ToDoItem>();
            _frmAddToDo.ToDoItemCreated += ToDoItemCreated;
        }

        private void _frmAddToDo_ToDoItemCreated(object? sender, CustomEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            _frmAddToDo.Show();
        }

        private void ToDoItemCreated(object? sender, CustomEventArgs e)
        {
            _toDoList.Add(e.ToDoItem);
            UpdateList(_toDoList);
        }

        private void UpdateList(IEnumerable<ToDoItem> items)
        {
            lstbToDo.Items.Clear();
            foreach (ToDoItem item in items)
            {
                lstbToDo.Items.Add(item);
            }
        }

        private void btnCompleteToDo_Click(object sender, EventArgs e)
        {
            int intSelectedIndex = lstbToDo.SelectedIndex;
            _toDoList[intSelectedIndex].DateExecuted = DateTime.Now;
            UpdateList(_toDoList);

        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            IEnumerable<ToDoItem> list = from ToDoItem in _toDoList
                                         where ToDoItem.DateExecuted != null
                                         select ToDoItem;

            UpdateList(list);
        }
        private void btnImportToDo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt|All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(ofd.OpenFile()))
                {
                    string strLine;
                    while ((strLine = reader.ReadLine()) != null)
                    {
                        string[] strSplit = strLine.Split(',');

                        if (strSplit[0] == "HomeWork")
                        {
                            _toDoList.Add(new HomeWork()
                            {
                                Description = strSplit[2],
                                Name = strSplit[1],
                                DueDate = DateTime.Now,
                                Executer = strSplit[4],
                                Location = strSplit[5]
                            });
                        }
                        else if (strSplit[0] == "OutsideWork")
                        {
                            _toDoList.Add(new OutsideWork()
                            {
                                Description = strSplit[2],
                                Name = strSplit[1],
                                DueDate = DateTime.Now,
                                Executer = strSplit[4],
                                Location = strSplit[5]
                            });
                        }

                    }
                }
            }
            UpdateList(_toDoList);
        }

        private void btnGroupByExecuter_Click(object sender, EventArgs e)
        {
            IEnumerable<ToDoItem> list = (from ToDoItem in _toDoList
                                         group ToDoItem by ToDoItem.Executer into groupExecuter
                                         from ToDoItem in groupExecuter
                                         select ToDoItem) ;

            UpdateList(list);
        }
    }

}