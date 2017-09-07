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

        public Task<Note> Get(int id)
        {
            return ctx.Notes.FirstAsync(n => n.Id == id);
        }

        public async Task<IEnumerable<NoteDigest>> GetAllNoteDigestByUserId(int userId)
        {
            var notes = await ctx.Notes.Where(n => n.UserId == userId).ToListAsync();
            return (IEnumerable<Note>)notes;
        }

        public Task Insert(Note note)
        {
            ((DbSet<Note>)ctx.Set<Note>())
                .Add(note);

            return ctx.SaveChangesAsync();
        }

        public Task Update(Note note)
        {
            //var noteToUpdate = ctx.Set<Note>().FirstOrDefault(n => n.Id == note.Id);

            ctx.Set<Note>()
                .Attach(note);
            //ctx.Entry(dbtaskResult).Property(tr => tr.Guid).IsModified = true;

            return ctx.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            var noteToRemove = new Note { Id = id };

            ctx.Notes.Attach(noteToRemove);
            ctx.Notes.Remove(noteToRemove);

            return ctx.SaveChangesAsync();
        }
    }
}
