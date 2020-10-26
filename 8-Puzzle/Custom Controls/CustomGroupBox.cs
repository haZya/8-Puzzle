using System.Drawing;
using System.Windows.Forms;

namespace _8_Puzzle
{
    /// <summary>
    /// Custom GroupBox control
    /// </summary>
    public class CustomGroupBox : GroupBox
    {
        /// <summary>
        /// Override OnPaint event to paint GroupBox
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Set colors
            Brush textBrush = new SolidBrush(ForeColor);
            Brush borderBrush = new SolidBrush(ForeColor);

            // Create a Pen
            Pen borderPen = new Pen(borderBrush);

            // Get the size of the header font area
            SizeF strSize = g.MeasureString(Text, Font);

            // Create a Rectangle for the bounds
            Rectangle rect = new Rectangle(ClientRectangle.X,
                                           ClientRectangle.Y + (int)(strSize.Height / 2),
                                           ClientRectangle.Width - 1,
                                           ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

            // Clear text and border
            g.Clear(BackColor);

            // Draw text
            g.DrawString(Text, Font, textBrush, Padding.Left, 0);

            #region Draw Border 
            g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height)); // Line Left
            g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height)); // Line Right
            g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height)); // Line Bottom
            g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + Padding.Left - 3, rect.Y)); // Line Top1
            g.DrawLine(borderPen, new Point(rect.X + Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y)); // Line Top2
            #endregion
        }
    }
}