using System.Drawing;
using System.Windows.Forms;

namespace _8_Puzzle
{
    /// <summary>
    /// Contains methods related to picking fonts
    /// </summary>
    public class FontPicker
    {
        /// <summary>
        /// Method for picking a font using a FontDialog
        /// </summary>
        /// <returns></returns>
        public Font GetFont()
        {
            // Create a new instance FontDialog
            FontDialog fontDialog = new FontDialog
            {
                // Get current font
                Font = Properties.Settings.Default.Font
            };

            // Return selected font, if user clicks OK 
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                // Clicked OK
                return fontDialog.Font;
            }

            return null;
        }
    }
}