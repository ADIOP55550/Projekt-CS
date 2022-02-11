using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz
{
    public class HighlightInfo
    {
        public Color? HighlightColor = null;
        public Color? BorderColor = null;
        public Color? IndicatorColor = null;
        public Color? IndicatorBorderColor = null;

        public HighlightInfo()
        {
        }

        public HighlightInfo(Color? highlightColor, Color? borderColor, Color? indicatorColor,
            Color? indicatorBorderColor)
        {
            HighlightColor = highlightColor;
            BorderColor = borderColor;
            IndicatorColor = indicatorColor;
            IndicatorBorderColor = indicatorBorderColor;
        }

        public static HighlightInfo operator +(HighlightInfo a, HighlightInfo b)
        {
            return new HighlightInfo
            {
                BorderColor = b.BorderColor ?? a.BorderColor ?? null,
                HighlightColor = b.HighlightColor ?? a.HighlightColor ?? null,
                IndicatorBorderColor = b.IndicatorBorderColor ?? a.IndicatorBorderColor ?? null,
                IndicatorColor = b.IndicatorColor ?? a.IndicatorColor ?? null
            };
        }

        /// <summary>
        /// Merges two HighlightInfos and stores the result in the first one (this)
        /// </summary>
        /// <param name="other">HighlightInfo to be merged to this</param>
        /// <returns>this</returns>
        public HighlightInfo Merge(HighlightInfo other)
        {
            BorderColor = other.BorderColor ?? BorderColor ?? null;
            HighlightColor = other.HighlightColor ?? HighlightColor ?? null;
            IndicatorBorderColor = other.IndicatorBorderColor ?? IndicatorBorderColor ?? null;
            IndicatorColor = other.IndicatorColor ?? IndicatorColor ?? null;

            return this;
        }

        /// <summary>
        /// Merges other onto this without overriding already set members
        /// </summary>
        /// <param name="other">HighlightInfo to be merged to this</param>
        /// <returns>this</returns>
        public HighlightInfo MergeNoOverride(HighlightInfo other)
        {
            BorderColor = this.BorderColor ?? other.BorderColor ?? null;
            HighlightColor = this.HighlightColor ?? other.HighlightColor ?? null;
            IndicatorBorderColor = this.IndicatorBorderColor ?? other.IndicatorBorderColor ?? null;
            IndicatorColor = this.IndicatorColor ?? other.IndicatorColor ?? null;
            return this;
        }

        public static HighlightInfo Random(Random? rnd = null)
        {
            rnd ??= new Random();

            return new HighlightInfo
            {
                HighlightColor = rnd.NextDouble() < 0.06
                    ? Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))
                    : null,
                BorderColor = rnd.NextDouble() < 0.01
                    ? Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))
                    : null,
                IndicatorColor = rnd.NextDouble() < 0.4
                    ? Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))
                    : null,
                IndicatorBorderColor = rnd.NextDouble() < 0.3
                    ? Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))
                    : null
            };
        }
    }
}