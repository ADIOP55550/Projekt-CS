using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kalendarz.Db;

namespace Kalendarz
{
    public partial class CustomTag : UserControl
    {
        /// <summary>
        /// OnDelete event sentinel type
        /// </summary>
        private static readonly object s_deleted = new();

        /// <summary>
        /// Open to edit event sentinel type
        /// </summary>
        private static readonly object s_edit = new();

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public event EventHandler? OnDeleted
        {
            add => Events.AddHandler(s_deleted, value);
            remove => Events.RemoveHandler(s_deleted, value);
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public event EventHandler? OnEditRequest
        {
            add => Events.AddHandler(s_edit, value);
            remove => Events.RemoveHandler(s_edit, value);
        }

        private int _priority;
        private int _color;
        private bool _highlight;


        public string Title
        {
            get => label1.Text;
            set
            {
                this.label1.Text = value;
                this.Invalidate();
            }
        }

        public int Priority
        {
            get => _priority;

            set
            {
                _priority = value;
                this.Invalidate();
            }
        }

        public bool Highlight
        {
            get => _highlight;

            set
            {
                _highlight = value;
                this.Invalidate();
            }
        }


        public CustomTag()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ((EventHandler?) Events[s_deleted])?.Invoke(this, null!);
        }

        protected int Id;

        public new Tag Tag => new()
        {
            Name = label1.Text,
            Id = this.Id,
            Color = ColorTranslator.ToHtml(this.BackColor),
            Priority = (sbyte) this.Priority,
            Highlight = (bool) this.Highlight,
        };

        public static CustomTag FromTag(Tag tag)
        {
            var newTag = new CustomTag();

            newTag.Id = tag.Id;
            newTag.Title = tag.Name;
            var bgColor = ColorTranslator.FromHtml(tag.Color);
            newTag.BackColor = bgColor;
            newTag.label1.ForeColor = bgColor.GetBrightness() > 0.4 ? Color.Black : Color.White;
            newTag.Priority = tag.Priority;
            newTag.Highlight = tag.Highlight;

            return newTag;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ((EventHandler?) Events[s_edit])?.Invoke(this, null!);
        }
    }
}