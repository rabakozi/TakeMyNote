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
        private readonly DatabaseContext dbContext;

        public NotesRepository(IDesignTimeDbContextFactory<DatabaseContext> dbContextFactory)
        {
            this.dbContext = dbContextFactory.CreateDbContext(null);
        }

        public Note Get(int id)
        {
            return dbContext.Notes.FirstOrDefault();
        }

        public IEnumerable<Note> GetAllNoteDigestByUserId(int userId)
        {
            //var ctx = _readOnlyDbContext();
            //var tt = _mapper.Map<IEnumerable<AutoClassificationCustomer>>(await ctx.Set<EntityModels.AutoClassificationCustomer>().Where(t => t.TaskResultId == taskResultId).ToListAsync());


            return dbContext.Set<Note>().Where(n => n.UserId == userId);
        }

        public void Insert(Note note)
        {
            //var ctx = _dbContext();

            //var dbCustomers = _mapper.Map<IEnumerable<EntityModels.AutoClassificationCustomer>>(customers).ToList();
            //foreach (var c in dbCustomers)
            //{
            //    c.TaskResultId = taskResultId;
            //}

            //((DbSet<EntityModels.AutoClassificationCustomer>)ctx.Set<EntityModels.AutoClassificationCustomer>())
            //    .AddRange(dbCustomers);

            //await ctx.SaveChangesAsync();

            
        }

        public void Update(Note note)
        {
            //var ctx = _dbContext();

            //var dbtaskResult = ctx.Set<EntityModels.AutoClassificationTaskResult>().FirstOrDefault(tr => tr.Id == taskResultId);
            //dbtaskResult.Guid = guid;

            //ctx.Set<EntityModels.AutoClassificationTaskResult>()
            //    .Attach(dbtaskResult);
            //ctx.Entry(dbtaskResult).Property(tr => tr.Guid).IsModified = true;

            //await ctx.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var noteToRemove = new Note { Id = id };

            dbContext.Notes.Attach(noteToRemove);
            dbContext.Notes.Remove(noteToRemove);
            dbContext.SaveChanges();
            //dbContext.Notes.Remove(n => n.Id == id);
        }
    }
}
