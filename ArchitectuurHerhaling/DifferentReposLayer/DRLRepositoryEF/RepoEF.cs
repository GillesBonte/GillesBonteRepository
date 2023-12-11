using DRLDataContext;
using DRLUserModel;

namespace DRLRepositoryEF
{
    public class RepoEF : IRepo
    {
        private MyDbContext _dbContext;

        public RepoEF()
        {
            _dbContext = new MyDbContext();
        }

        public void Create()
        {
            for (int i = 1; i < 9; i++)
            {

                _dbContext.Users.Add(new User() { Id = i, Name = "A" + i, Function = "Employee" });
                _dbContext.SaveChanges();
            }
        }

        public void Delete(User user)
        {
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _dbContext.Users.ToList();
        }

        public void Update(User user)
        {
            User userToDelete = GetUserById(user.Id);
            Delete(userToDelete);
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        void IRepo.Add(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        private User GetUserById(int id)
        {
            User resultUser = new User();

            foreach (User user in _dbContext.Users)
            {
                if (user.Id == id)
                {
                    resultUser = user;
                }
            }
            return resultUser;
        }
    }
}