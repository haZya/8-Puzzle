using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _8_Puzzle
{
    /// <summary>
    /// Contains events and methods of Custom_Config_Panel User Control
    /// </summary>
    public partial class Custom_Config_Panel : UserControl
    {
        #region Global variables
        private static Custom_Config_Panel instance;
        private ErrorProvider errorProvider;
        private int moves;
        private int[,] solution;
        public static event EventHandler<CustomConfigEventArgs> OnCustomConfigSolved;
        #endregion

        /// <summary>
        /// Initialization
        /// </summary>
        public Custom_Config_Panel()
        {
            InitializeComponent();

            errorProvider = new ErrorProvider();
            solution = new int[Puzzle.MAX_MOVES + 1, Puzzle.NUM_PIECES];
        }

        /// <summary>
        /// Applys settings on load
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Get back color and fore color from user settings
            Color backColor = Properties.Settings.Default.BackColor;
            Color foreColor = Properties.Settings.Default.ForeColor;

            // Set User Control BackColor
            BackColor = backColor;

            #region Change settings of Button controls
            btnReset.ForeColor = foreColor;
            btnOK.ForeColor = foreColor;
            btnCancel.ForeColor = foreColor;
            #endregion

            #region Change fore color settings of NumericUpDown controls
            numFirstBox.ForeColor = foreColor;
            numSecondBox.ForeColor = foreColor;
            numThirdBox.ForeColor = foreColor;
            numFourthBox.ForeColor = foreColor;
            numFifthBox.ForeColor = foreColor;
            numSixthBox.ForeColor = foreColor;
            numSeventhBox.ForeColor = foreColor;
            numEightBox.ForeColor = foreColor;
            numNinthBox.ForeColor = foreColor;
            #endregion

            #region Change back color settings of NumericUpDown controls
            numFirstBox.BackColor = backColor;
            numSecondBox.BackColor = backColor;
            numThirdBox.BackColor = backColor;
            numFourthBox.BackColor = backColor;
            numFifthBox.BackColor = backColor;
            numSixthBox.BackColor = backColor;
            numSeventhBox.BackColor = backColor;
            numEightBox.BackColor = backColor;
            numNinthBox.BackColor = backColor;
            #endregion
        }

        /// <summary>
        /// Get an instance of the UserControl
        /// </summary>
        /// <returns></returns>
        public static Custom_Config_Panel GetInstance()
        {
            if (instance == null)
            {
                // Get an instance, if does not already exists
                instance = new Custom_Config_Panel();
            }

            return instance;
        }

        /// <summary>
        /// Validates NumericUpDown controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumBox_ValueChanged(object sender, EventArgs e)
        {
            // Get sender as NumericUpDown control
            NumericUpDown numBox = sender as NumericUpDown;

            #region Add values in NumericUpDown to a list
            List<int> values = new List<int>();

            if (numBox.Tag != numFirstBox.Tag)
                values.Add((int)numFirstBox.Value);
            if (numBox.Tag != numSecondBox.Tag)
                values.Add((int)numSecondBox.Value);
            if (numBox.Tag != numThirdBox.Tag)
                values.Add((int)numThirdBox.Value);
            if (numBox.Tag != numFourthBox.Tag)
                values.Add((int)numFourthBox.Value);
            if (numBox.Tag != numFifthBox.Tag)
                values.Add((int)numFifthBox.Value);
            if (numBox.Tag != numSixthBox.Tag)
                values.Add((int)numSixthBox.Value);
            if (numBox.Tag != numSeventhBox.Tag)
                values.Add((int)numSeventhBox.Value);
            if (numBox.Tag != numEightBox.Tag)
                values.Add((int)numEightBox.Value);
            if (numBox.Tag != numNinthBox.Tag)
                values.Add((int)numNinthBox.Value);
            #endregion

            // Get the value of the currently focused NumericUpDown control
            int val = (int)numBox.Value;

            #region Check if any of the other fields has the same value
            if (val == values[0] || val == values[1] || val == values[2] || val == values[3] || val == values[4] || val == values[5] || val == values[6] || val == values[7])
            {
                // Show error
                errorProvider.SetError(numBox, "Another field has the same value");
            }
            else
            {
                // Remove error
                errorProvider.SetError(numBox, "");
            }
            #endregion
        }

        /// <summary>
        /// Resets the fields to their default and clear errors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            #region Default values of NumericUpDown controls
            numFirstBox.Value = 1;
            numSecondBox.Value = 2;
            numThirdBox.Value = 3;
            numFourthBox.Value = 8;
            numFifthBox.Value = 0;
            numSixthBox.Value = 4;
            numSeventhBox.Value = 7;
            numEightBox.Value = 6;
            numNinthBox.Value = 5;
            #endregion

            // Clear the error provider
            errorProvider.Clear();
        }

        /// <summary>
        /// Tries to find a soluton within given max moves
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOK_Click(object sender, EventArgs e)
        {
            #region Add values of all NumericUpDown controls to a list
            List<int> values = new List<int>
            {
                (int)numFirstBox.Value,
                (int)numSecondBox.Value,
                (int)numThirdBox.Value,
                (int)numFourthBox.Value,
                (int)numFifthBox.Value,
                (int)numSixthBox.Value,
                (int)numSeventhBox.Value,
                (int)numEightBox.Value,
                (int)numNinthBox.Value
            };
            #endregion

            // Try to solve and get a solution for the configuration
            moves = Solve(values);

            // Check if a solution found within the max moves
            if (moves == Puzzle.MAX_MOVES)
            {
                // No solution found
                DialogResult result = MessageBox.Show("Sorry, could not find a solution for this configuration",
                    "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                if (result == DialogResult.Retry)
                {
                    // Retry
                    moves = Solve(values);
                    if (moves == Puzzle.MAX_MOVES)
                    {
                        // No solution found
                        MessageBox.Show("Sorry, could not find a solution for this configuration," +
                            "please try another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                // Solution found
                // Clear errors
                errorProvider.Clear();

                #region Get position of each puzzle piece for the first move
                int[] positions = new int[Puzzle.NUM_PIECES];

                for (int i = 0; i < Puzzle.NUM_PIECES; i++)
                {
                    positions[i] = solution[0, i];
                }
                #endregion

                // Close parent form
                ParentForm.Close();

                #region Set values for custom config
                CustomConfigEventArgs conf = new CustomConfigEventArgs()
                {
                    Moves = moves,
                    Positions = positions,
                    Solution = solution
                };
                #endregion

                // Invoke the custom event
                OnCustomConfigSolved.Invoke(this, conf);
            }
        }

        /// <summary>
        /// Tries to solve the configuration provided
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private int Solve(List<int> values)
        {
            int count = 0;
            moves = Puzzle.MAX_MOVES;

            #region Try to solve the given config for maximum of thousand times
            while (moves == Puzzle.MAX_MOVES && count < 1000)
            {
                int[,] board = new int[3, 3];

                #region Get the values of each piece in regards to their positions
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (values[Puzzle.NUM_ROW * i + j] != 0)
                        {
                            // Get the value of each piece except for the "Empty Tile"
                            board[i, j] = values[Puzzle.NUM_ROW * i + j];
                        }
                    }
                }
                #endregion

                // Call SolveNext method to get a solution within the max moves
                Puzzle puzzle = new Puzzle();
                AStar aStar = new AStar();
                moves = aStar.Solve(ref solution, board);

                count++;
            }
            #endregion

            return moves;
        }

        /// <summary>
        /// Cancels and closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Close parent form
            ParentForm.Close();
        }
    }
}