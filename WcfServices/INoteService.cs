using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using TakeMyNote.Model;

namespace TakeMyNote.WcfServices
{
    [ServiceContract]
    public interface INoteService
    {
        [OperationContract]
        Task<Note> GetById(int id);

        [OperationContract]
        Task<Note> GetByLink(string sharedId);

        [OperationContract]
        Task<IEnumerable<NoteDigest>> GetAllByUserId(int userId);

        [OperationContract]
        Task Create(Note note);

        [OperationContract]
        Task Update(Note note);

        [OperationContract]
        Task Delete(int id);
    }
}       
