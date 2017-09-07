using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TakeMyNote.Model;
using TakeMyNote.Repositories;

namespace WebApi.Controllers
{
    /// <summary>
    /// This controller implements Notes CRUD functionalities
    /// </summary>
    [Route("api/[controller]")]
    public class NotesController : Controller
    {
        private readonly INotesRepository notesRepository;

        public NotesController(INotesRepository notesRepository)
        {
            this.notesRepository = notesRepository;
        }
        
        /// <summary>
        /// Gets a Note by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Note</returns>
        [HttpGet("{id}")]
        public Task<Note> Get(int id)
        {
            return notesRepository.Get(id);
        }

        /// <summary>
        /// Creates a new Note
        /// </summary>
        [HttpPost]
        public Task Post([FromBody]Note note)
        {
            return notesRepository.Insert(note);
        }

        /// <summary>
        /// Amends an existing Note
        /// </summary>
        [HttpPut("{id}")]
        public Task Put(int id, [FromBody]Note note)
        {
            return notesRepository.Update(note);
        }

        /// <summary>
        /// Deletes a Note of a given Id
        /// </summary>
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
            return notesRepository.Delete(id);
        }

        /// <summary>
        /// Returns a list of Note digest of a user
        /// </summary>
        /// <returns>IEnumerable&lt;Note&gt;</returns>
        [HttpGet]
        public Task<IEnumerable<NoteDigest>> GetByUserId(int userId)
        {
            return notesRepository.GetAllNoteDigestByUserId(userId);
        }
    }
}

// TODO: share link, list... collection, support infinite scroll
// TODO: authentication; list notes by users...
