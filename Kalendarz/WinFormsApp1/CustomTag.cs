﻿using System;
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
        private int _priority;
        private int _color;

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


        public CustomTag()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        protected int Id;

        public Tag Tag => new Tag
        {
            Name = label1.Text,
            Id = this.Id,
            Color = ColorTranslator.ToHtml(this.BackColor),
            Priority = (sbyte) this.Priority,
            Highlight = false, // todo
        };

        public static CustomTag FromTag(Tag tag)
        {
            var newTag = new CustomTag();

            newTag.Id = tag.Id;
            newTag.Title = tag.Name;
            var bgColor = ColorTranslator.FromHtml(tag.Color);
            newTag.BackColor = bgColor;
            newTag.ForeColor = bgColor.GetBrightness() > 0.6 ? Color.Black : Color.White;
            newTag.Priority = tag.Priority;

            return newTag;
        }
    }
}