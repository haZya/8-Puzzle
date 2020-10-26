using System.Drawing;
using System.Windows.Forms;

namespace _8_Puzzle
{
    /// <summary>
    /// Contains methods related to picking colors
    /// </summary>
    public class ColorPicker
    {
        /// <summary>
        /// Method for picking a color using a ColorDialog
        /// </summary>
        /// <returns></returns>
        public Color GetColor()
        {
            // Create a new instance ColorDialog
            ColorDialog colorDialog = new ColorDialog
            {
                // Keeps the user from selecting a custom color
                AllowFullOpen = false,

                // Allows the user to get help (The default is false)
                ShowHelp = true
            };

            // Return selected color, if user clicks OK
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Clicked OK
                return colorDialog.Color;
            }
            else
            {
                // Canceled
                return Color.Empty;
            }
        }
    }
}