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

        private static readonly Color[] HighlightColors = new[]
        {
            Color.FromArgb(121, 195, 254),
            Color.FromArgb(93, 182, 255),
            Color.FromArgb(60, 168, 255),
            Color.FromArgb(0, 154, 255),
            Color.FromArgb(0, 140, 255),
            Color.FromArgb(0, 125, 253),
            Color.FromArgb(0, 109, 250),
            Color.FromArgb(0, 93, 245),
            Color.FromArgb(0, 75, 238),
            Color.FromArgb(0, 54, 229),
            Color.FromArgb(24, 23, 218)
        };

        public HighlightInfo HighlightInfo => new HighlightInfo
        {
            IndicatorBorderColor = this.Content.Length > 0
                ? this.Tags.OrderBy(t => t.Priority).Reverse().Select(t => HighlightColors[t.Priority])
                    .FirstOrDefault(Color.Black)
                : null,
            IndicatorColor = this.Content.Length > 0 && IsDone ? Color.DarkSlateGray :
                Content.Length == 0 && Tags.Count > 0 ? Color.LightGray : null,
            HighlightColor = ColorTranslator.FromHtml(this.Tags.Where(t => t.Highlight).OrderBy(tag => tag.Priority)
                .Reverse().FirstOrDefault(new Tag {Color = "transparent"}).Color)
        };
    }
}