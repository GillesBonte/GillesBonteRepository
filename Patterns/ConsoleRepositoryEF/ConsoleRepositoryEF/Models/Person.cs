using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRepositoryEF.Models
{
    public class Person
    {
        public Person()
        { 
            FirstName = string.Empty;
            LastName = string.Empty;
            Age = 0;
        }

        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

}
