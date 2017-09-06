using System;
using System.Collections.Generic;
using System.Text;

namespace TakeMyNote.Model
{
    public class NoteDigest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
    }
}
