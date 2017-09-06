using System.Collections.Generic;
using TakeMyNote.Model;

namespace TakeMyNote.Repositories
{
    public interface INotesRepository
    {
        Note Get(int id);
        IEnumerable<Note> GetAllNoteDigestByUserId(int userId);
        void Delete(int id);
        void Update(Note note);
    }
}
