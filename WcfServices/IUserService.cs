using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using TakeMyNote.Model;

namespace TakeMyNote.WcfServices
{
    [ServiceContract]
    public interface IUserService
    {

        [OperationContract(AsyncPattern = true)]
        Task<IEnumerable<User>> GetAllAsync();
        [OperationContract]
        IEnumerable<User> GetAll();

        [OperationContract(AsyncPattern = true)]
        Task<User> GetByIdAsync(int id);
        [OperationContract]
        User GetById(int id);

        [OperationContract(AsyncPattern = true)]
        Task CreateAsync(User user);
        [OperationContract]
        void Create(User user);

        [OperationContract(AsyncPattern = true)]
        Task UpdateAsync(User user);
        [OperationContract]
        void Update(User user);

        [OperationContract(AsyncPattern = true)]
        Task DeleteAsync(int id);
        [OperationContract]
        void Delete(int id);
    }
}       
