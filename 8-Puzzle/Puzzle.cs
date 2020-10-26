using System.Windows.Forms;

namespace _8_Puzzle
{
    /// <summary>
    /// Contains methods related to the puzzle
    /// </summary>
    public class Puzzle
    {
        #region Global variables
        public static readonly int NUM_PIECES = 9;
        public static readonly int NUM_ROW = 3;
        public static readonly int NUM_COL = 3;
        public static readonly int MAX_MOVES = 256;
        #endregion

        /// <summary>
        /// Slides two puzzle pieces
        /// </summary>
        /// <param name="firstPiece"></param>
        /// <param name="secondPiece"></param>
        public void Slide(ref Button firstPiece, ref Button secondPiece)
        {
            // Slide two pieces together by interchanging their values
            string temp = secondPiece.Text;
            secondPiece.Text = firstPiece.Text;
            firstPiece.Text = temp;
        }
    }
}