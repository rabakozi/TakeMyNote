
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

        public Task<Note> GetByIdAsync(int id)
        {
            return notesRepository.Get(id);
        }

        public Task<Note> GetByLinkAsync(string sharedId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<NoteDigest>> GetAllByUserIdAsync(int userId)
        {
            return notesRepository.GetAllNoteDigestByUserId(userId);
        }

        public Task CreateAsync(Note note)
        {
            return notesRepository.Insert(note);
        }

        public Task UpdateAsync(Note note)
        {
            return notesRepository.Update(note);
        }

        public Task DeleteAsync(int id)
        {
            return notesRepository.Delete(id);
        }
    }
}
