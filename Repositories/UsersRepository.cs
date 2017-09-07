using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TakeMyNote.DataAccess;
using TakeMyNote.Model;

namespace TakeMyNote.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly DatabaseContext ctx;

        public UsersRepository(IDesignTimeDbContextFactory<DatabaseContext> dbContextFactory)
        {
            ctx = dbContextFactory.CreateDbContext(null);
        }

        public Task<User> Get(int id)
        {
            return ctx.Users.FirstAsync(n => n.Id == id);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var users = await ctx.Users.ToListAsync();
            return (IEnumerable<User>)users;
        }

        public Task Insert(User user)
        {
            ((DbSet<User>)ctx.Set<User>())
                .Add(user);

            return ctx.SaveChangesAsync();
        }

        public Task Update(User user)
        {
            ctx.Set<User>()
               .Attach(user);

            return ctx.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            var userToRemove = new User { Id = id };

            ctx.Users.Attach(userToRemove);
            ctx.Users.Remove(userToRemove);

            return ctx.SaveChangesAsync();
        }
    }
}
