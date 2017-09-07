using System;
using System.Collections.Generic;
using System.ServiceModel;
using TakeMyNote.Model;

namespace TakeMyNote.WcfServices
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        User GetById(int id);

        [OperationContract]
        void Create(User note);

        [OperationContract]
        void Update(User note);

        [OperationContract]
        void Delete(int id);
    }
}       
