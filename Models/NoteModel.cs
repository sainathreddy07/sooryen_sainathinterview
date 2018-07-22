using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTest.Models
{
    public class NoteModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Topic { get; set; }
        public string UserId { get; set; }
    }
}