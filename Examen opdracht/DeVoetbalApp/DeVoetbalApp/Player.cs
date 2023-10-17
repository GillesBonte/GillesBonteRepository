using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeVoetbalApp
{
    public class Player
    {

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {

                if (value.Length > 100)
                {
                   throw new PlayerNameTooLongException(value);
                }
                else
                {
                    _name = value;
                }
                
            }
        }
        public string Position { get; set; }
        public string Country { get; set; }
        public string League { get; set; }
        public string Club { get; set; }
        public int Price { get; set; }
    }

}
