using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTest.Dacs.Entities
{
    public class NoteEntities
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public string Topic { get; set; }
    }
}