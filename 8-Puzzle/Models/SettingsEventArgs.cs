using System;
using System.Drawing;

namespace _8_Puzzle
{
    /// <summary>
    /// Custom SettingsEventArgs event model for holding settings data
    /// </summary>
    public class SettingsEventArgs : EventArgs
    {
        public Color BackColor { get; set; }
        public Color SuggestedTileColor { get; set; }
        public Color PossibleTilesColor { get; set; }
        public Color ForeColor { get; set; }
        public Color SecForeColor { get; set; }
        public Font Font { get; set; }
    }
}