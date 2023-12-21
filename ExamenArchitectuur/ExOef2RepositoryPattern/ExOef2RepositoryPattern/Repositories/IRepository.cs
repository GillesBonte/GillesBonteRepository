using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExOef2RepositoryPattern.Models;

namespace ExOef2RepositoryPattern.Repositories
{

    //omdat de oefening vraagt om een Repository van customers ZONDER implementatie
    //ga ik uit van een interface
    public interface IRepository
    {
        //create
        void Create();
        void AddCustomer(Customer customer);

        //read
        List<Customer> GetAll();
        Customer GetById(int id);

        //update
        void Update(Customer customer);

        //delete
        void Delete(int id);
    }

}
