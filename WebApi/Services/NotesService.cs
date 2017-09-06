using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TakeMyNote.DataAccess;
using TakeMyNote.Model;

namespace TakeMyNote.WebApi.Services
{
    public class NotesService : INotesService
    {
        private readonly DatabaseContext dbContext;

        public NotesService(IDesignTimeDbContextFactory<DatabaseContext> dbContextFactory)
        {
            this.dbContext = dbContextFactory.CreateDbContext(null);
        }

        public Note Get(int id)
        {
            return dbContext.Notes.FirstOrDefault();
        }
    }
}
