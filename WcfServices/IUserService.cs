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

        [OperationContract(AsyncPattern = true)]
        Task<User> GetByIdAsync(int id);

        [OperationContract(AsyncPattern = true)]
        Task CreateAsync(User user);

        [OperationContract(AsyncPattern = true)]
        Task UpdateAsync(User user);

        [OperationContract(AsyncPattern = true)]
        Task DeleteAsync(int id);
    }
}       
