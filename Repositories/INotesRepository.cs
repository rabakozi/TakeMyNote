using System.Collections.Generic;
using TakeMyNote.Model;

namespace TakeMyNote.Repositories
{
    public interface INotesRepository
    {
        Note Get(int id);
        IEnumerable<Note> GetAllNoteDigestByUserId(int userId);
        void Update(Note note);
        void Insert(Note note);
        void Delete(int id);
    }
}
