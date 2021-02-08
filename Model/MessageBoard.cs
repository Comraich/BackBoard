using System;

namespace BackBoard.Model
{
    public class MessageBoard
    {
        public string BoardId { get; set; }
        public string OwnerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string BoardTitle { get; set; }
        public string BoardDescription { get; set; }
        public Array Moderators { get; set; }
        public Array Members { get; set; }
        public Array BoardMessageThreads { get; set; }
    }
}