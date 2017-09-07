
using System.Collections.Generic;
using TakeMyNote.Model;
using TakeMyNote.Repositories;

namespace TakeMyNote.WcfServices
{
    public class NoteService : INoteService
    {
        public INotesRepository notesRepository { get; }

        public NoteService(INotesRepository notesRepository)
        {
            this.notesRepository = notesRepository;
        }

        public Note GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Note GetByLink(string sharedId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<NoteDigest> GetAllByUserId(int userId)
        {
            throw new System.NotImplementedException();
        }

        public void Create(Note note)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Note note)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
