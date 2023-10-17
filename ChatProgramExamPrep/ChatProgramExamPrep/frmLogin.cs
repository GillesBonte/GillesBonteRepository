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
            UserManager userManager = new UserManager();

            foreach (User item in userManager)
            {
                if (item.UserName == txtUsername.Text && item.Password == txtPassword.Text)
                {
                    userExists = true;
                }
            }

            if (userExists) 
            {
                frmMainMenu newMenu = new frmMainMenu();
                newMenu.Show();
            }
            else
            {
                MessageBox.Show("Account certification failed.");
            }

        }

    }

}