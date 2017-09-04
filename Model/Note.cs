using System;

namespace TakeMyNote.Model
{
    public class Note
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
    }
}
