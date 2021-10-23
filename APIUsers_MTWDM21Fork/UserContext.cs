using Microsoft.EntityFrameworkCore;

namespace APIUsers_MTWDM21Fork
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        public DbSet<Models.User> Users { get; set; }

    }
}
