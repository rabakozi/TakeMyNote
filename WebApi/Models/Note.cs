using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakeMyNote.WebApi.Models
{
    public class Note
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
    }
}
