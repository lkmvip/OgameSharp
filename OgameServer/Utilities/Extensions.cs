using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace OgameServer.Utilities
{
    /// <summary>
    /// Extensions.
    /// </summary>
    static public class Extensions
    {
        /// <summary>
        /// Add text to a rich text box using color. 
        /// </summary>
        /// <param name="richTextBox">Current rich text box.</param>
        /// <param name="text">Text to add.</param>
        /// <param name="color">Color of the text to add.</param>
        public static void AppendText(this RichTextBox richTextBox, string text, Color color)
        {
            TextRange textRange = new TextRange(richTextBox.Document.ContentEnd, richTextBox.Document.ContentEnd);

            textRange.Text = text;

            Brush brush = new SolidColorBrush(color);

            textRange.ApplyPropertyValue(TextElement.ForegroundProperty, brush);
        }
    }
}
