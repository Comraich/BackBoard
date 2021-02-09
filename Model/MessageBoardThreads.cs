using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackBoard.Model
{
    public class MessageBoardThreads
    {
        public string BoardMessageThreadId { get; set; }
        public DateTime PostedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string AuthorId { get; set; }
        public Array Messages { get; set; }
    }
}