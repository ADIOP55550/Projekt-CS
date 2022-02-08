using System;
using System.Collections.Generic;

#nullable disable

namespace Kalendarz.Db
{
    public partial class Entry
    {
        public Entry()
        {
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; } = "";
        public bool IsDone { get; set; } = false;
        public bool IsStarred { get; set; } = false;

        public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();

        public HighlightInfo HighlightInfo => new HighlightInfo
        {
            IndicatorBorderColor = this.Content.Length > 0 ? Color.Blue : null,
            IndicatorColor = this.Content.Length > 0 && IsDone ? Color.Blue : null,
        };
    }
}