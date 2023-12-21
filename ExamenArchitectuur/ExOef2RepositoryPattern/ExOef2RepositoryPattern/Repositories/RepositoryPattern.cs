using ExOef2RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOef2RepositoryPattern.Repositories
{
    public class RepositoryPattern : IRepository
    {
        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();

            //BVB: listCustomers.Add(customer)
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
