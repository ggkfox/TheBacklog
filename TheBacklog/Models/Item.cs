using System;

namespace TheBacklog.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public bool Owned { get; set; }
        public bool Finished { get; set; }
    }
}