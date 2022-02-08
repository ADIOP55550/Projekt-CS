using System;
using System.Collections.Generic;

#nullable disable

namespace Kalendarz.Db
{
    public partial class Tag
    {
        public int Id { get; set; }
        public int EntryId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public bool Highlight { get; set; }
        public sbyte Priority { get; set; }

        public virtual Entry Entry { get; set; }
    }
}
