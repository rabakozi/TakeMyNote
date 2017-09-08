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
        [OperationContract(AsyncPattern = true)]
        Task<Note> GetByIdAsync(int id);

        [OperationContract(AsyncPattern = true)]
        Task<Note> GetByLinkAsync(string sharedId);

        [OperationContract(AsyncPattern = true)]
        Task<IEnumerable<NoteDigest>> GetAllByUserIdAsync(int userId);

        [OperationContract(AsyncPattern = true)]
        Task CreateAsync(Note note);

        [OperationContract(AsyncPattern = true)]
        Task UpdateAsync(Note note);

        [OperationContract(AsyncPattern = true)]
        Task DeleteAsync(int id);
    }
}       
