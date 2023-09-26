namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        private int _counter;
        public frmTicTacToe()
        {
            InitializeComponent();
            _counter = 0;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Button btnClicked = (Button)sender;

            if (_counter % 2 == 0)
            {
                btnClicked.Text = "X";
            }
            else
            {
                btnClicked.Text = "O";
            }
            
            btnClicked.Enabled = false;
            _counter++;
        }

    }
}