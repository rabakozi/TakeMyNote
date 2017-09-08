﻿using System;
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

        public Task CreateAsync(User user)
        {
            return usersRepository.Insert(user);
        }

        public Task DeleteAsync(int id)
        {
            return usersRepository.Delete(id);
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            return usersRepository.GetAll();
        }

        public Task<User> GetByIdAsync(int id)
        {
            return usersRepository.Get(id);
        }

        public Task UpdateAsync(User user)
        {
            return usersRepository.Update(user);
        }

        // sync wrappers

        public IEnumerable<User> GetAll()
        {
            return GetAllAsync().GetAwaiter().GetResult();
        }

        public User GetById(int id)
        {
            return GetByIdAsync(id).GetAwaiter().GetResult();
        }

        public void Create(User user)
        {
            CreateAsync(user).GetAwaiter().GetResult();
        }

        public void Update(User user)
        {
            UpdateAsync(user).GetAwaiter().GetResult();
        }

        public void Delete(int id)
        {
            DeleteAsync(id).GetAwaiter().GetResult();
        }
    }
}
