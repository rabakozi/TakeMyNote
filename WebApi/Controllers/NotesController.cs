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
    /// This controller implements API Search functionalities
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
        /// Search a coupon.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Mock search result data.</returns>
        [HttpGet("{id}")]
        public Note Get(int id)
        {
            //return new Note { Id = id};
            return notesRepository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Note value)
        {
            notesRepository.Insert(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Note value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Note> GetByUserId(int userId)
        {
            return notesRepository.GetAllNoteDigestByUserId(userId);
        }
    }
}


// TODO: share link, list... collection, support infinite scroll
// TODO: authentication; list notes by users...
