using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackBoard.Model
{
    public class BoardMessages
    {
        public string BoardMessageId { get; set; }
        public DateTime PostedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string AuthorId { get; set; }
        public string replyToMessageId { get; set; }
    }
}