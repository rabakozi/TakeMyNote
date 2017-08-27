using System;

namespace TakeMyNote.Data.Model
{
    public class Note
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Creation { get; set; }
        public DateTime Modifyed { get; set; }
        public string Heading { get; set; }
    }
}
