using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalErrorHandling
{
    internal class Animal
    {

        private int _legCount;
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int Legcount 
        { 
            get
            {
                return _legCount;
            }
                
          set
            {
                if (value <= 1)
                {
                    throw new Exception();
                }
                else
                {
                    _legCount = value;
                }
            }
        
        }
        public string Color { get; set; }

        public int GetAge()
        {
            if (DateOfBirth.HasValue)
            {
                int intAge = DateTime.Now.Year - DateOfBirth.Value.Year;
                if (DateTime.Now.DayOfYear < DateOfBirth.Value.DayOfYear)
                {
                    intAge--;
                }
                return intAge;
            }
            else
            {
                throw new Exception()
            }
            
        }

    }

}
