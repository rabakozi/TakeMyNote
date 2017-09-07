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
        [OperationContract]
        Task<IEnumerable<User>> GetAll();

        [OperationContract]
        Task<User> GetById(int id);

        [OperationContract]
        Task Create(User user);

        [OperationContract]
        Task Update(User user);

        [OperationContract]
        Task Delete(int id);
    }
}       
