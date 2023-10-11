namespace ExampleExamTaskList
{
    public partial class frmToDo : Form
    {
        public frmToDo()
        {
            InitializeComponent();
        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            frmAddToDo frmAddToDo = new frmAddToDo();
            frmAddToDo.ShowDialog();
        }
    }
}