using Microsoft.Win32;

namespace ChatProgramExamPrep
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool userExists = false;

            foreach (var item in File.ReadAllLines(Directory.GetCurrentDirectory() + "/Users.txt"))
            {
                if (txtUsername.Text != "" && item.Contains(txtUsername.Text))
                {
                    userExists = true;
                    break;
                }
            }

            if (userExists) 
            {
                frmMainMenu newMenu = new frmMainMenu();
                newMenu.Show();
            }
            else
            {
                MessageBox.Show("User does not exist.");
            }

        }

    }

}