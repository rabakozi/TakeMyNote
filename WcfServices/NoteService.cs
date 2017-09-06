
using TakeMyNote.Model;
using TakeMyNote.Repositories;

namespace TakeMyNote.WcfService
{
    public class NoteService : INoteService
    {
        public INotesRepository notesRepository { get; }

        public NoteService(INotesRepository notesRepository)
        {
            this.notesRepository = notesRepository;
        }

        public double Add(double dblNum1, double dblNum2)
        {
            notesRepository.Insert(new Note { Title="hello", Content = "22" });
            return (dblNum1 + dblNum2);
        }
        public double Subtract(double dblNum1, double dblNum2)
        {
            return (dblNum1 - dblNum2);
        }
        public double Multiply(double dblNum1, double dblNum2)
        {
            return (dblNum1 * dblNum2);
        }
        public double Divide(double dblNum1, double dblNum2)
        {
            return ((dblNum2 == 0) ? 0 : (dblNum1 / dblNum2));
        }
    }
}
