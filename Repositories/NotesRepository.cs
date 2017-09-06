using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TakeMyNote.DataAccess;
using TakeMyNote.Model;

namespace TakeMyNote.Repositories
{
    public class NotesRepository : INotesRepository
    {
        private readonly DatabaseContext ctx;

        public NotesRepository(IDesignTimeDbContextFactory<DatabaseContext> dbContextFactory)
        {
            ctx = dbContextFactory.CreateDbContext(null);
        }

        public Note Get(int id)
        {
            return ctx.Notes.FirstOrDefault();
        }

        public IEnumerable<Note> GetAllNoteDigestByUserId(int userId)
        {
            //var ctx = _readOnlyDbContext();
            //var tt = _mapper.Map<IEnumerable<AutoClassificationCustomer>>(await ctx.Set<EntityModels.AutoClassificationCustomer>().Where(t => t.TaskResultId == taskResultId).ToListAsync());


            return ctx.Set<Note>().Where(n => n.UserId == userId);
        }

        public void Insert(Note note)
        {
            ((DbSet<Note>)ctx.Set<Note>())
                .Add(note);

            ctx.SaveChanges();


        }

        public void Update(Note note)
        {
            //var noteToUpdate = ctx.Set<Note>().FirstOrDefault(n => n.Id == note.Id);

            ctx.Set<Note>()
                .Attach(note);
            //ctx.Entry(dbtaskResult).Property(tr => tr.Guid).IsModified = true;

            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var noteToRemove = new Note { Id = id };

            ctx.Notes.Attach(noteToRemove);
            ctx.Notes.Remove(noteToRemove);
            ctx.SaveChanges();
        }
    }
}
