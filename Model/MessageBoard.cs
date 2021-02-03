using System;

namespace BackBoard
{
    public class MessageBoard
    {
        public DateTime DateCreated { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Array Users { get; set; }

        public int OwnerId { get; set; }

        public int BoardId { get; set; }

        public Array Messages { get; set; }
    }
}
