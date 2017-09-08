using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TakeMyNote.Model;
using TakeMyNote.Repositories;

namespace WebApi.Controllers
{
    /// <summary>
    /// This controller implements Notes CRUD functionalities
    /// </summary>
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsersRepository usersRepository;

        public UsersController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        /// <summary>
        /// Gets all the users
        /// </summary>
        /// <returns>IEnumerable&lt;User&gt;</returns>
        [HttpGet]
        public Task<IEnumerable<User>> Get()
        {
            return usersRepository.GetAll();
        }

        /// <summary>
        /// Gets a User by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User</returns>
        [HttpGet("{id}")]
        public Task<User> Get(int id)
        {
            return usersRepository.Get(id);
        }

        /// <summary>
        /// Creates a new User
        /// </summary>
        [HttpPost]
        public Task Post([FromBody]User user)
        {
            return usersRepository.Insert(user);
        }

        /// <summary>
        /// Amends an existing User
        /// </summary>
        [HttpPut("{id}")]
        public Task Put(int id, [FromBody]User user)
        {
            user.Id = id;
            return usersRepository.Update(user);
        }

        /// <summary>
        /// Deletes a User of a given Id
        /// </summary>
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
            return usersRepository.Delete(id);
        }
    }
}
