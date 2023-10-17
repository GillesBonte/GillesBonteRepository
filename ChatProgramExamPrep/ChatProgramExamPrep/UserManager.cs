using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatProgramExamPrep
{
    public class UserManager : List<User>
    {
        public UserManager() 
        {
            ImportUsers();
        }

        private void ImportUsers()
        {

            foreach (var item in File.ReadAllLines(Directory.GetCurrentDirectory() + "/Users.txt"))
            {
                string[] strUserSplit = item.Split(',');
                this.Add(new User() { UserName = strUserSplit[0], Password = strUserSplit[1]  });
            }

        }

    }

}
