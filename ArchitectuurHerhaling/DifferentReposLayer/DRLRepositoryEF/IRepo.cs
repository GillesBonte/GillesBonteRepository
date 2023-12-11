using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DRLUserModel;

namespace DRLRepositoryEF
{
    public interface IRepo
    {
        void Add(User user);
        void Create();
        void Update(User user);
        List<User> GetAll();
        void Delete(User user);
        
    }

}
