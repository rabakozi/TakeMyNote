using System.Collections.Generic;
using System.Threading.Tasks;
using TakeMyNote.Model;

namespace TakeMyNote.Repositories
{
    public interface IUsersRepository
    {
        Task<User> Get(int id);
        Task<IEnumerable<User>> GetAll();
        Task Update(User user);
        Task Insert(User user);
        Task Delete(int id);
    }
}
