using BasicMVVM.Models;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;

namespace BasicMVVM.ViewModels
{
    class UserViewModel : ViewModelBase
    {
        public ObservableCollection<User> _users;
        private User _currentUser;

        public UserViewModel()
        {
            _users = new ObservableCollection<User>();
            _users.Add(new User()
            { UserId = 1, Department = "IT", UserName = "Gilles" });
            _users.Add(new User()
            { UserId = 2, Department = "Post", UserName = "Lindsey" });
            _users.Add(new User()
            { UserId = 3, Department = "Meme", UserName = "Lemmy" });


        }

        public ObservableCollection<User> users
        {
            get
            {
                return _users;
            }
            private set
            {
            }
        }
        private User CurrentUser
        {
            get
            {
                return _currentUser;
            }
            set
            {
                _currentUser = value;
                OnPropertyChanged("CurrentUser");
            }
        }
    }
}
