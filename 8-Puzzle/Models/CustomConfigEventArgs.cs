namespace _8_Puzzle
{
    /// <summary>
    /// Custom CustomConfigEventArgs event model for holding custom config data
    /// </summary>
    public class CustomConfigEventArgs
    {
        public int Moves { get; set; }
        public int[] Positions { get; set; }
        public int[,] Solution { get; set; }
    }
}