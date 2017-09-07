using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakeMyNote.Model;
using TakeMyNote.Repositories;

namespace TakeMyNote.WcfServices
{
    class UserService : IUserService
    {
        public IUsersRepository usersRepository { get; }

        public UserService(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public Task Create(User user)
        {
            return usersRepository.Insert(user);
        }

        public Task Delete(int id)
        {
            return usersRepository.Delete(id);
        }

        public Task<IEnumerable<User>> GetAll()
        {
            return usersRepository.GetAll();
        }

        public Task<User> GetById(int id)
        {
            return usersRepository.Get(id);
        }

        public Task Update(User user)
        {
            return usersRepository.Update(user);
        }
    }
}
