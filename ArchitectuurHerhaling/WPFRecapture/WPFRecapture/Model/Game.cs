using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRecapture.Model
{
    public class Game : ModelBase
    {
        private string _name;
        private int _id;
        private string _genre;

        public string Name 
        { 
            get 
            { 
                return _name; 
            } set 
            { 
                _name = value;
                OnPropertyChanged("Name");
            } 
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
                OnPropertyChanged("Genre");
            }
        }

    }
}
