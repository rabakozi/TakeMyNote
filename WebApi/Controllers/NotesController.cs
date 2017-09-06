using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TakeMyNote.Model;
using TakeMyNote.WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class NotesController : Controller
    {
        private readonly INotesService notesService;

        public NotesController(INotesService notesService)
        {
            this.notesService = notesService;
        }
        //// GET api/values
        //[HttpGet]
        //public IEnumerable<User> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public Note Get(int id)
        {
            //return new Note { Id = id};
            return notesService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Note value)
        {
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
        public IEnumerable<Note> Get()
        {
            var notes = new List<Note>();
            return notes;
        }
    }
}


// TODO: share link, list... collection, support infinite scroll
// TODO: authentication; list notes by users...
