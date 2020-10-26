using System;
using System.Drawing;
using System.Windows.Forms;

namespace _8_Puzzle
{
    /// <summary>
    /// Custom GroupBox control
    /// </summary>
    public class CustomButton : Button
    {
        /// <summary>
        /// Override OnEnabledChanged event to alter button appearance
        /// </summary>
        /// <param name="e"></param>
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            // Check if the button is enabled or not
            if (Enabled)
            {
                // Button enabled, therefore change BorderColor to empty (default)
                FlatAppearance.BorderColor = Color.Empty;
            }
            else
            {
                // Button disabled, therefore change BorderColor to black
                FlatAppearance.BorderColor = Color.Black;
            }
        }
    }
}