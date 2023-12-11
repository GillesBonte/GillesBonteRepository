using System.Data.Entity;
using DRLUserModel;
namespace DRLDataContext
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("UsersDB")
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
