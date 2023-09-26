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
            //must define the object as button to get the proper commands
            Button btnClicked = (Button)sender;

            //when counter even put text on the clicked button as X
            if (_counter % 2 == 0)
            {
                btnClicked.Text = "X";
            }
            else //otherwise as O
            {
                btnClicked.Text = "O";
            }
            
            btnClicked.Enabled = false;
            _counter++;
        }

    }
}