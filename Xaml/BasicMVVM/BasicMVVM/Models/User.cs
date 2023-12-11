using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMVVM.Models
{
    class User : BaseClass
    {
        #region privates
        private string _userName;
        private int _userId;
        private string _userDepartment;
        #endregion
        #region Properties
        public string UserName
        {
            get
            {
                return _userName;
            }
            set 
            {
                _userName = value;
                OnPropertyChanged("UserName");
            }
        }
        public int UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
                OnPropertyChanged("UserId");
            }
        }
        public string Department
        {
            get
            {
                return _userDepartment;
            }
            set
            {
                _userDepartment = value;
                OnPropertyChanged("Department");
            }
        }
        #endregion
    }
}
