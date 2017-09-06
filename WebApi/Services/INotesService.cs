using TakeMyNote.Model;

namespace TakeMyNote.WebApi.Services
{
    public interface INotesService
    {
        Note Get(int id);
    }
}
