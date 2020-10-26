using System;

namespace _8_Puzzle
{
    /// <summary>
    /// Contains the methods related to the A* algorithm
    /// </summary>
    public class AStar
    {
        #region Global variables
        private int g, nodesExpanded;
        private int[,] board;
        private Random random;
        private bool isFound;
        #endregion

        /// <summary>
        /// Initialization
        /// </summary>
        public AStar()
        {
            // Declare random with DateTime.Now.Ticks as the seed
            random = new Random((int)DateTime.Now.Ticks);
        }

        /// <summary>
        /// Returns the number of nodes were expanded to find the solution 
        /// </summary>
        /// <returns></returns>
        public int GetNodesExpanded()
        {
            return nodesExpanded;
        }

        /// <summary>
        /// Returns the heuristic value
        /// </summary>
        /// <param name="square"></param>
        /// <returns></returns>
        public static int Heuristic(int[,] square)
        {
            // Manhattan Distance as the heuristic
            return ManhattanDistance(square);
        }

        /// <summary>
        /// Get Manhattan Distance for the position
        /// </summary>
        /// <param name="square"></param>
        /// <returns></returns>
        private static int ManhattanDistance(int[,] square)
        {
            // City Block or Manhatten Distance heuristic
            // Manhattan Distance here represents the shortest distance (Number of Moves) required for all puzzle pieces
            // to move to their optimal positions in the goal state, added together into a single value
            int md = 0;

            #region Get Manhattan Distance for all positions in regards to the expected goal state
            switch (square[0, 0])
            {
                case 1:
                    md += 0;
                    break;
                case 2:
                    md += 1;
                    break;
                case 3:
                    md += 2;
                    break;
                case 4:
                    md += 3;
                    break;
                case 5:
                    md += 4;
                    break;
                case 6:
                    md += 3;
                    break;
                case 7:
                    md += 2;
                    break;
                case 8:
                    md += 1;
                    break;
            }

            switch (square[0, 1])
            {
                case 1:
                    md += 1;
                    break;
                case 2:
                    md += 0;
                    break;
                case 3:
                    md += 1;
                    break;
                case 4:
                    md += 2;
                    break;
                case 5:
                    md += 3;
                    break;
                case 6:
                    md += 2;
                    break;
                case 7:
                    md += 3;
                    break;
                case 8:
                    md += 2;
                    break;
            }

            switch (square[0, 2])
            {
                case 1:
                    md += 2;
                    break;
                case 2:
                    md += 1;
                    break;
                case 3:
                    md += 0;
                    break;
                case 4:
                    md += 1;
                    break;
                case 5:
                    md += 2;
                    break;
                case 6:
                    md += 3;
                    break;
                case 7:
                    md += 4;
                    break;
                case 8:
                    md += 3;
                    break;
            }

            switch (square[1, 0])
            {
                case 0:
                    md += 1;
                    break;
                case 1:
                    md += 1;
                    break;
                case 2:
                    md += 2;
                    break;
                case 3:
                    md += 3;
                    break;
                case 4:
                    md += 2;
                    break;
                case 5:
                    md += 3;
                    break;
                case 6:
                    md += 2;
                    break;
                case 7:
                    md += 1;
                    break;
                case 8:
                    md += 0;
                    break;
            }

            switch (square[1, 1])
            {
                case 1:
                    md += 2;
                    break;
                case 2:
                    md += 1;
                    break;
                case 3:
                    md += 2;
                    break;
                case 4:
                    md += 1;
                    break;
                case 5:
                    md += 2;
                    break;
                case 6:
                    md += 1;
                    break;
                case 7:
                    md += 2;
                    break;
                case 8:
                    md += 1;
                    break;
            }

            switch (square[1, 2])
            {
                case 1:
                    md += 3;
                    break;
                case 2:
                    md += 2;
                    break;
                case 3:
                    md += 1;
                    break;
                case 4:
                    md += 0;
                    break;
                case 5:
                    md += 1;
                    break;
                case 6:
                    md += 2;
                    break;
                case 7:
                    md += 3;
                    break;
                case 8:
                    md += 2;
                    break;
            }

            switch (square[2, 0])
            {
                case 1:
                    md += 2;
                    break;
                case 2:
                    md += 3;
                    break;
                case 3:
                    md += 4;
                    break;
                case 4:
                    md += 3;
                    break;
                case 5:
                    md += 2;
                    break;
                case 6:
                    md += 1;
                    break;
                case 7:
                    md += 0;
                    break;
                case 8:
                    md += 1;
                    break;
            }

            switch (square[2, 1])
            {
                case 1:
                    md += 3;
                    break;
                case 2:
                    md += 2;
                    break;
                case 3:
                    md += 3;
                    break;
                case 4:
                    md += 2;
                    break;
                case 5:
                    md += 1;
                    break;
                case 6:
                    md += 0;
                    break;
                case 7:
                    md += 1;
                    break;
                case 8:
                    md += 2;
                    break;
            }

            switch (square[2, 2])
            {
                case 1:
                    md += 4;
                    break;
                case 2:
                    md += 3;
                    break;
                case 3:
                    md += 2;
                    break;
                case 4:
                    md += 1;
                    break;
                case 5:
                    md += 0;
                    break;
                case 6:
                    md += 1;
                    break;
                case 7:
                    md += 2;
                    break;
                case 8:
                    md += 3;
                    break;
            }
            #endregion

            return md;
        }

        /// <summary>
        /// Shuffles the puzzle randomly
        /// </summary>
        public void Shuffle()
        {
            // Declare board with number of rows and columns
            board = new int[Puzzle.NUM_ROW, Puzzle.NUM_COL];

            int digit, i, row, col;

            #region Create an array to hold the generated values
            int[] placed = new int[Puzzle.NUM_PIECES];
            
            for (i = 0; i < Puzzle.NUM_PIECES; i++)
            {
                // Assign 0 as the default value
                placed[i] = 0;
            }
            #endregion

            // Reset the cost of the path (g) and nodes expanded
            g = nodesExpanded = 0;

            #region Initialize the board with value of 0 for each position
            for (col = 0; col < Puzzle.NUM_COL; col++)
            {
                for (row = 0; row < Puzzle.NUM_ROW; row++)
                {
                    // Assign 0 as the default value
                    board[col, row] = 0;
                }
            }
            #endregion

            #region Add a random value between 0-8 for each position avoiding duplications
            for (i = 0; i < Puzzle.NUM_PIECES; i++)
            {
                isFound = false;

                #region Generate a random value between 0-8 which hasn't been generated earlier
                do
                {
                    // Generate a random digit between 0-8
                    digit = random.Next(Puzzle.NUM_PIECES);

                    // Check if the digit generated hasn't been assigned already to a position
                    isFound = placed[digit] == 0;
                    if (isFound)
                    {
                        // If not, assign as 1
                        placed[digit] = 1;
                    }
                }
                while (!isFound);
                #endregion

                #region Get a random position on the board which hasn't been assigned to a value already
                do
                {
                    // Random row
                    row = random.Next(Puzzle.NUM_ROW);
                    // Random column
                    col = random.Next(Puzzle.NUM_COL);

                    // Check if the position in regards to the generated row and col combination hasn't been assigned already
                    isFound = board[row, col] == 0;
                    if (isFound)
                    {
                        // If not, assign the digit generated earlier as the value of the position
                        board[row, col] = digit;
                    }
                }
                while (!isFound);
                #endregion
            }
            #endregion
        }

        /// <summary>
        /// Expands a node
        /// </summary>
        /// <param name="square"></param>
        /// <param name="tempSquare"></param>
        /// <returns></returns>
        private int Expand(int[,] square, ref int[,,] tempSquare)
        {
            int b = -1, col = -1, row = -1, i, j, k;

            #region Create a three dimentional array capable of storing up to four expanded nodes
            // (Upto 4, due to the maximum amount of possible moves that can be made at once is 4)
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < Puzzle.NUM_ROW; j++)
                {
                    for (k = 0; k < Puzzle.NUM_COL; k++)
                    {
                        // Add value of each position four times
                        tempSquare[i, j, k] = square[j, k];
                    }
                }
            }
            #endregion

            #region Find the row and column of the empty position
            for (i = 0; i < Puzzle.NUM_ROW; i++)
            {
                for (j = 0; j < Puzzle.NUM_COL; j++)
                {
                    if (square[i, j] == 0)
                    {
                        // Empty position
                        row = i;
                        col = j;
                        break;
                    }
                }
            }
            #endregion

            #region Expand the possible nodes, depending on the position of the empty piece
            if (row == 0 && col == 0)
            {
                #region Expand Position 1 (row = 0, col = 0), since it contains the empty piece
                // Expand to position 2 (row = 0, col = 1)
                tempSquare[0, 0, 0] = tempSquare[0, 0, 1];
                tempSquare[0, 0, 1] = 0;

                // Expand to position 4 (row = 1, col = 0)
                tempSquare[1, 0, 0] = tempSquare[1, 1, 0];
                tempSquare[1, 1, 0] = 0;
                #endregion

                // Set the number of nodes expanded
                b = 2;
            }
            else if (row == 0 && col == 1)
            {
                #region Expand Position 2 (row = 0, col = 1), since it contains the empty piece
                // Expand to position 1 (row = 0, col = 0)
                tempSquare[0, 0, 1] = tempSquare[0, 0, 0];
                tempSquare[0, 0, 0] = 0;

                // Expand to position 5 (row = 1, col = 1)
                tempSquare[1, 0, 1] = tempSquare[1, 1, 1];
                tempSquare[1, 1, 1] = 0;

                // Expand to position 3 (row = 0, col = 2)
                tempSquare[2, 0, 1] = tempSquare[2, 0, 2];
                tempSquare[2, 0, 2] = 0;
                #endregion

                // Set the number of nodes expanded
                b = 3;
            }
            else if (row == 0 && col == 2)
            {
                #region Expand Position 3 (row = 0, col = 2), since it contains the empty piece
                // Expand to position 2 (row = 0, col = 1)
                tempSquare[0, 0, 2] = tempSquare[0, 0, 1];
                tempSquare[0, 0, 1] = 0;

                // Expand to position 6 (row = 1, col = 2)
                tempSquare[1, 0, 2] = tempSquare[1, 1, 2];
                tempSquare[1, 1, 2] = 0;
                #endregion

                // Set the number of nodes expanded
                b = 2;
            }
            else if (row == 1 && col == 0)
            {
                #region Expand Position 4 (row = 1, col = 0), since it contains the empty piece
                // Expand to position 1 (row = 0, col = 0)
                tempSquare[0, 1, 0] = tempSquare[0, 0, 0];
                tempSquare[0, 0, 0] = 0;

                // Expand to position 5 (row = 1, col = 1)
                tempSquare[1, 1, 0] = tempSquare[1, 1, 1];
                tempSquare[1, 1, 1] = 0;

                // Expand to position 7 (row = 2, col = 0)
                tempSquare[2, 1, 0] = tempSquare[2, 2, 0];
                tempSquare[2, 2, 0] = 0;
                #endregion

                // Set the number of nodes expanded
                b = 3;
            }
            else if (row == 1 && col == 1)
            {
                #region Expand Position 5 (row = 1, col = 1), since it contains the empty piece
                // Expand to position 4 (row = 1, col = 0)
                tempSquare[0, 1, 1] = tempSquare[0, 1, 0];
                tempSquare[0, 1, 0] = 0;

                // Expand to position 2 (row = 0, col = 1)
                tempSquare[1, 1, 1] = tempSquare[1, 0, 1];
                tempSquare[1, 0, 1] = 0;

                // Expand to position 6 (row = 1, col = 2)
                tempSquare[2, 1, 1] = tempSquare[2, 1, 2];
                tempSquare[2, 1, 2] = 0;

                // Expand to position 8 (row = 2, col = 1)
                tempSquare[3, 1, 1] = tempSquare[3, 2, 1];
                tempSquare[3, 2, 1] = 0;
                #endregion

                // Set the number of nodes expanded
                b = 4;
            }
            else if (row == 1 && col == 2)
            {
                #region Expand Position 6 (row = 1, col = 2), since it contains the empty piece
                // Expand to position 3 (row = 0, col = 2)
                tempSquare[0, 1, 2] = tempSquare[0, 0, 2];
                tempSquare[0, 0, 2] = 0;

                // Expand to position 5 (row = 1, col = 1)
                tempSquare[1, 1, 2] = tempSquare[1, 1, 1];
                tempSquare[1, 1, 1] = 0;

                // Expand to position 9 (row = 2, col = 2)
                tempSquare[2, 1, 2] = tempSquare[2, 2, 2];
                tempSquare[2, 2, 2] = 0;
                #endregion

                // Set the number of nodes expanded
                b = 3;
            }
            else if (row == 2 && col == 0)
            {
                #region Expand Position 7 (row = 2, col = 0), since it contains the empty piece
                // Expand to position 4 (row = 1, col = 0)
                tempSquare[0, 2, 0] = tempSquare[0, 1, 0];
                tempSquare[0, 1, 0] = 0;

                // Expand to position 8 (row = 2, col = 1)
                tempSquare[1, 2, 0] = tempSquare[1, 2, 1];
                tempSquare[1, 2, 1] = 0;
                #endregion

                // Set the number of nodes expanded
                b = 2;
            }
            else if (row == 2 && col == 1)
            {
                #region Expand Position 8 (row = 2, col = 1), since it contains the empty piece
                // Expand to position 7 (row = 2, col = 0)
                tempSquare[0, 2, 1] = tempSquare[0, 2, 0];
                tempSquare[0, 2, 0] = 0;

                // Expand to position 5 (row = 1, col = 1)
                tempSquare[1, 2, 1] = tempSquare[1, 1, 1];
                tempSquare[1, 1, 1] = 0;

                // Expand to position 9 (row = 2, col = 2)
                tempSquare[2, 2, 1] = tempSquare[2, 2, 2];
                tempSquare[2, 2, 2] = 0;
                #endregion

                // Set the number of nodes expanded
                b = 3;
            }
            else if (row == 2 && col == 2)
            {
                #region Expand Position 9 (row = 2, col = 2), since it contains the empty piece
                // Expand to position 8 (row = 2, col = 1)
                tempSquare[0, 2, 2] = tempSquare[0, 2, 1];
                tempSquare[0, 2, 1] = 0;

                // Expand to position 6 (row = 1, col = 2)
                tempSquare[1, 2, 2] = tempSquare[1, 1, 2];
                tempSquare[1, 1, 2] = 0;
                #endregion

                // Set the number of nodes expanded
                b = 2;
            }
            #endregion

            return b;
        }

        /// <summary>
        /// Finds the shortest node to the goal
        /// </summary>
        /// <returns></returns>
        private bool Move()
        {
            int b, count, i, j, k, min;
            int[] f = new int[4], index = new int[4];
            int[,,] tempSquare = new int[4, Puzzle.NUM_ROW, Puzzle.NUM_COL];

            #region Check if the goal node is in the top of the priority key before calling Expand
            if (board[0, 0] == 1 && board[0, 1] == 2 && board[0, 2] == 3 &&
                board[1, 0] == 8 && board[1, 1] == 0 && board[1, 2] == 4 &&
                board[2, 0] == 7 && board[2, 1] == 6 && board[2, 2] == 5)
                return true;
            #endregion

            // Call Expand method to expand the node
            b = Expand(board, ref tempSquare);

            #region Loop thru the number of expands to find all possible nodes
            for (i = 0; i < b; i++)
            {
                int[,] ts = new int[Puzzle.NUM_ROW, Puzzle.NUM_COL];

                #region Get value of each position in regards to the current expand
                for (j = 0; j < Puzzle.NUM_ROW; j++)
                {
                    for (k = 0; k < Puzzle.NUM_COL; k++)
                    {
                        ts[j, k] = tempSquare[i, j, k];
                    }
                }
                #endregion

                // Use A* with cost of the path and heuristic (Manhattan distance) to find the shortest node
                f[i] = g + Heuristic(ts);

                #region Set value of each position in regards to the current expand
                for (j = 0; j < Puzzle.NUM_ROW; j++)
                {
                    for (k = 0; k < Puzzle.NUM_COL; k++)
                    {
                        // Assign the value
                        board[j, k] = tempSquare[i, j, k];
                    }
                }
                #endregion
            }
            #endregion

            #region Find the minimum f value out of the nodes found
            min = f[0];
            for (i = 1; i < b; i++)
            {
                if (f[i] < min)
                {
                    // Get minimum f
                    min = f[i];
                }
            }
            #endregion

            #region Get all shortest nodes
            for (count = i = 0; i < b; i++)
            {
                if (f[i] == min)
                {
                    // index[1] = i
                    index[count++] = i;
                }
            }
            #endregion

            // Get one node randomly choosen if more than one shortest nodes were found
            i = index[random.Next(count)];

            // Increment the cost of the path thus far
            g++;

            // Add number of nodes expanded to the overall nodeExpanded value
            nodesExpanded += b;

            #region Set value of each position in regards to the shortest node found
            for (j = 0; j < Puzzle.NUM_ROW; j++)
            {
                for (k = 0; k < Puzzle.NUM_COL; k++)
                {
                    // Assign the value
                    board[j, k] = tempSquare[i, j, k];
                }
            }
            #endregion

            return false;
        }

        /// <summary>
        /// Solves the puzzle and get a solution with all moves needed
        /// </summary>
        /// <param name="solution"></param>
        /// <returns></returns>
        public int Solve(ref int[,] solution, int[,] board)
        {
            bool found = false;
            int i, j, k, m = 0;
            if (board != null)
            {
                // Configuration changed
                this.board = board;
            }

            #region Go thru all nodes till find the goal state
            while (!found && m < Puzzle.MAX_MOVES)
            {
                for (i = k = 0; i < Puzzle.NUM_ROW; i++)
                {
                    for (j = 0; j < Puzzle.NUM_COL; j++)
                    {
                        // Add value for each position in reagrds to the move
                        solution[m, k++] = this.board[i, j];
                    }
                }

                // Call Move mehod to get shortest path
                found = Move();

                // Increase the number of moves by 1
                m++;
            }
            #endregion

            return m;
        }
    }
}