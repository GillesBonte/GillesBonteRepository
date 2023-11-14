using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleRepositoryEF.Models;

namespace ConsoleRepositoryEF.DAL__Data_Access_Layer_
{

    //deze DAL is bij voorkeur een singleton
    public class PersonContext : DbContext
    {
        public PersonContext() : base("PersonDB")
        {
        }

        public DbSet<Person> Persons { get; set;}

    }

}
