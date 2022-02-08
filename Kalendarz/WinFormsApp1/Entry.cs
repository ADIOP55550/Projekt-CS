using System;
using System.Collections.Generic;

#nullable disable

namespace Kalendarz
{
    public partial class Entry
    {
        public Entry()
        {
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public bool IsDone { get; set; }
        public bool IsStarred { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
