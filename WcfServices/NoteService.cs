
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public Task<Note> GetById(int id)
        {
            return notesRepository.Get(id);
        }

        public Task<Note> GetByLink(string sharedId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<NoteDigest>> GetAllByUserId(int userId)
        {
            return notesRepository.GetAllNoteDigestByUserId(userId);
        }

        public Task Create(Note note)
        {
            return notesRepository.Insert(note);
        }

        public Task Update(Note note)
        {
            return notesRepository.Update(note);
        }

        public Task Delete(int id)
        {
            return notesRepository.Delete(id);
        }
    }
}
