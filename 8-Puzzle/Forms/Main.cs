using System;
using System.Drawing;
using System.Windows.Forms;

namespace _8_Puzzle
{
    /// <summary>
    /// Contains events and methods of Main form
    /// </summary>
    public partial class Main : Form
    {
        #region Global variables
        private int[] positions;
        private static int[,] solution;
        private int move, moves;
        private static Button[] pieces;
        private bool isShuffled;
        private Button firstPiece, secondPiece;
        private Timer autoPlayTimer;
        private Color emptyPieceColor, suggestedPieceColor, possiblePieceColor;
        private const string IDLE_MODE = "Idle";
        private const string MANUAL_MODE = "Manula Mode";
        private const string AI_MODE = "AI Mode";
        private const string AUTO_MODE = "Auto Mode";
        private const string BTN_AUTO_PLAY = "Auto Play";
        private const string BTN_PAUSE = "Pause";
        public const string SETTINGS_PANEL = "Settings";
        public const string CUSTOM_CONFIG_PANEL = "Custom Configurations";
        #endregion

        /// <summary>
        /// Initialization
        /// </summary>
        public Main()
        {
            InitializeComponent();

            // Declare an array of Buttons for puzzle pieces
            pieces = new Button[Puzzle.NUM_PIECES];
            // Declare an array of integers to hold the value of each puzzle piece
            positions = new int[Puzzle.NUM_PIECES];
            // Declare a two dimetional array for holding value of each puzzle piece for all moves
            solution = new int[Puzzle.MAX_MOVES + 1, Puzzle.NUM_PIECES];

            // Initialize the timer for Auto Play function
            autoPlayTimer = new Timer()
            {
                // .8 seconds
                Interval = 800,
            };
            autoPlayTimer.Tick += OnTimerTick;

            #region DefaultConfiguration
            positions[0] = 1;
            positions[1] = 2;
            positions[2] = 3;
            positions[3] = 8;
            positions[4] = 0;
            positions[5] = 4;
            positions[6] = 7;
            positions[7] = 6;
            positions[8] = 5;
            #endregion

            #region Initialize each of the nine puzzle pieces as Buttons
            for (int i = 0; i < Puzzle.NUM_PIECES; i++)
            {
                if (pieces[i] == null)
                {
                    // Initialize, if only no already existing instance is found
                    pieces[i] = new Button();
                }
                pieces[i].FlatStyle = FlatStyle.Flat;
                pieces[i].MouseDown += OnPuzzlePieceMouseDown;
                pieces[i].MouseUp += OnPuzzlePieceMouseUp;
            }
            #endregion

            Settings_Panel.OnSettingsChanged += OnSettingsChanged;
            Custom_Config_Panel.OnCustomConfigSolved += OnCustomConfigSolved;
        }

        /// <summary>
        /// Populates the puzzle and apply settings on load
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Call Populate method
            Populate();

            #region Get user settings
            SettingsEventArgs settings = new SettingsEventArgs()
            {
                BackColor = Properties.Settings.Default.BackColor,
                SuggestedTileColor = Properties.Settings.Default.SuggestedTileColor,
                PossibleTilesColor = Properties.Settings.Default.PossibleTilesColor,
                ForeColor = Properties.Settings.Default.ForeColor,
                SecForeColor = Properties.Settings.Default.SecForeColor,
                Font = Properties.Settings.Default.Font
            };
            #endregion

            // Call ChangeSettings method to apply the settings
            ChangeSettings(settings);
        }

        /// <summary>
        /// Populates the puzzle pieces with values
        /// </summary>
        public void Populate()
        {
            // Get width and height of puzzle area
            int panelWidth = panelPuzzleArea.Width;
            int panelHeight = panelPuzzleArea.Height;

            // Get width and height of a single puzzle piece
            int width = panelWidth / Puzzle.NUM_COL;
            int height = panelHeight / Puzzle.NUM_ROW;

            #region Loop thru all puzzle pieces to populate and set values to them
            for (int i = 0; i < Puzzle.NUM_PIECES; i++)
            {
                // Assign the value to the relevent puzzle piece
                pieces[i].Text = positions[i].ToString();

                #region Check for the "Empty Tile"
                if (positions[i] == 0)
                {
                    // This is the "Empty Tile"
                    pieces[i].Text = null;
                    pieces[i].BackColor = emptyPieceColor;
                }
                else
                {
                    // Not the "Empty Tile"
                    pieces[i].BackColor = Properties.Settings.Default.BackColor;
                }
                #endregion

                // Set the bounds of the puzzle piece
                pieces[i].Width = width;
                pieces[i].Height = height;

                // Set location of the puzzle piece inside the puzzle area
                pieces[i].Location = new Point(width * (i % Puzzle.NUM_COL), height * (i / Puzzle.NUM_ROW));

                // Check if the puzzle piece already exists inside the puzzle area
                if (!panelPuzzleArea.Controls.Contains(pieces[i]))
                {
                    // If not, add it to the puzzle area
                    panelPuzzleArea.Controls.Add(pieces[i]);
                }
            }
            #endregion
        }

        /// <summary>
        /// Suggests user the next move and other possible moves
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPuzzlePieceMouseDown(object sender, MouseEventArgs e)
        {
            // Set the puzzle piece which is being clicked as firstPiece
            firstPiece = sender as Button;

            // Check whether the puzzle is shuffled or not
            if (isShuffled)
            {
                // If yes, check whether the user has clicked on the empty piece while puzzle is not yet fixed
                if (move != moves && firstPiece.Text == String.Empty)
                {
                    // If yes, find all possible moves for the next step and change their back colors
                    for (int i = 0; i < Puzzle.NUM_PIECES; i++)
                    {
                        // Find the piece which has been clicked
                        if (pieces[i] == firstPiece)
                        {
                            firstPiece.Cursor = Cursors.NoMove2D; // Change mouse cursor to NoMove2D
                            #region Set BackColor of the possible moves depending on the piece which has been clicked
                            switch (i)
                            {
                                case 0:
                                    pieces[1].BackColor = possiblePieceColor;
                                    pieces[3].BackColor = possiblePieceColor;
                                    break;
                                case 1:
                                    pieces[0].BackColor = possiblePieceColor;
                                    pieces[2].BackColor = possiblePieceColor;
                                    pieces[4].BackColor = possiblePieceColor;
                                    break;
                                case 2:
                                    pieces[1].BackColor = possiblePieceColor;
                                    pieces[5].BackColor = possiblePieceColor;
                                    break;
                                case 3:
                                    pieces[0].BackColor = possiblePieceColor;
                                    pieces[4].BackColor = possiblePieceColor;
                                    pieces[6].BackColor = possiblePieceColor;
                                    break;
                                case 4:
                                    pieces[1].BackColor = possiblePieceColor;
                                    pieces[3].BackColor = possiblePieceColor;
                                    pieces[5].BackColor = possiblePieceColor;
                                    pieces[7].BackColor = possiblePieceColor;
                                    break;
                                case 5:
                                    pieces[2].BackColor = possiblePieceColor;
                                    pieces[4].BackColor = possiblePieceColor;
                                    pieces[8].BackColor = possiblePieceColor;
                                    break;
                                case 6:
                                    pieces[3].BackColor = possiblePieceColor;
                                    pieces[7].BackColor = possiblePieceColor;
                                    break;
                                case 7:
                                    pieces[4].BackColor = possiblePieceColor;
                                    pieces[6].BackColor = possiblePieceColor;
                                    pieces[8].BackColor = possiblePieceColor;
                                    break;
                                case 8:
                                    pieces[5].BackColor = possiblePieceColor;
                                    pieces[7].BackColor = possiblePieceColor;
                                    break;
                            }
                            #endregion
                        }
                    }

                    // Find the next suggested piece and change its back color
                    for (int i = 0; i < Puzzle.NUM_PIECES; i++)
                    {
                        // Find the piece against which the "Empty Tile" will be swaped in order to fix
                        if (solution[move, i] == 0)
                        {
                            // Change its BackColor
                            pieces[i].BackColor = suggestedPieceColor;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Moves the Empty Tile to the relevent position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPuzzlePieceMouseUp(object sender, MouseEventArgs e)
        {
            firstPiece.Cursor = Cursors.Default; // Change mouse cursor back to default

            // Get X position where the click released relative to the X position of firstPiece
            int positionX = e.X + firstPiece.Location.X;
            // Get Y position where the click released relative to the Y position of firstPiece
            int positionY = e.Y + firstPiece.Location.Y;

            #region Loop thru all pieces to find the secondPiece on which the mouse up has been performed
            for (int i = 0; i < Puzzle.NUM_PIECES; i++)
            {
                #region Get the bounds of each puzzle piece
                int xStart = pieces[i].Location.X; // Get the X position of the piece's top left bound
                int xEnd = pieces[i].Location.X + pieces[i].Width; // Get the X position of the piece's top right bound
                int yStart = pieces[i].Location.Y; // Get the Y position of the piece's bottom left bound
                int yEnd = pieces[i].Location.Y + pieces[i].Height; // Get the Y position of the piece's bottom right bound
                #endregion

                // Check if the click released position is within the piece's bounds
                if (positionX > xStart && positionX < xEnd && positionY > yStart && positionY < yEnd)
                {
                    // If true, set the piece as secondPiece
                    secondPiece = pieces[i];
                }
            }
            #endregion

            // Check if the puzzle is shuffled
            if (isShuffled)
            {
                // Shuffled
                if (secondPiece != null)
                {
                    // secondPiece found
                    // Check if the Mouse Up has been performed on the Suggested piece or on another Possible piece
                    if (secondPiece.BackColor == suggestedPieceColor || secondPiece.BackColor == possiblePieceColor)
                    {
                        // Call Slide method in Puzzle class to slide the two pieces
                        Puzzle puzzle = new Puzzle();
                        puzzle.Slide(ref firstPiece, ref secondPiece);

                        // Find on to which type of piece it has been slided to
                        if (secondPiece.BackColor == suggestedPieceColor)
                        {
                            // Slided to the "Suggested Tile"
                            move++;
                            labelCurrentMove.Text = (move - 1).ToString();
                        }
                        else
                        {
                            // Slided to a "Possible Tile"
                            groupBoxPlayModes.Enabled = true;
                            labelStatus.Text = AI_MODE;

                            #region Try to find a solution to the new position by running the algorithm again
                            int count = 0;
                            do
                            {
                                int[,] board = new int[Puzzle.NUM_ROW, Puzzle.NUM_COL];

                                #region Get the values of each piece in regards to their positions
                                for (int i = 0; i < Puzzle.NUM_ROW; i++)
                                {
                                    for (int j = 0; j < Puzzle.NUM_COL; j++)
                                    {
                                        int val = 0;
                                        if (pieces[Puzzle.NUM_ROW * i + j].Text != String.Empty)
                                        {
                                            // Get the value of each piece except for the "Empty Tile"
                                            int.TryParse(pieces[Puzzle.NUM_ROW * i + j].Text, out val);
                                        }
                                        // Assign the value
                                        board[i, j] = val;
                                    }
                                }
                                #endregion

                                // Attempt to find a solution within the max moves
                                AStar aStar = new AStar();
                                moves = aStar.Solve(ref solution, board);

                                // Reset the fields
                                move = 1;
                                labelMovesNeeded.Text = (moves - 1).ToString();
                                labelCurrentMove.Text = (move - 1).ToString();

                                count++;
                            }
                            while (moves == Puzzle.MAX_MOVES && count < Puzzle.MAX_MOVES);
                            #endregion

                            #region Check if a solution is found and if not activate the Manual Mode
                            if (moves == Puzzle.MAX_MOVES)
                            {
                                // No possible solution found within the given max moves,
                                // therefore activate the Manual Mode
                                groupBoxPlayModes.Enabled = false;
                                labelStatus.Text = MANUAL_MODE;

                                // Dispose and reinitialize solution array,
                                // Necessary to remove the result from the previous attempt
                                solution = null;
                                solution = new int[Puzzle.MAX_MOVES + 1, Puzzle.NUM_PIECES];

                                #region Remove any solution suggestion left behind
                                for (int i = 0; i < 9; i++)
                                {
                                    if (solution[move, i] == 0)
                                    {
                                        // Assign to -1 to remove the next move suggestion
                                        solution[move, i] = -1;
                                    }
                                }
                                #endregion

                                // Reset current move and moves needed labels to 0
                                labelCurrentMove.Text = 0.ToString();
                                labelMovesNeeded.Text = 0.ToString();
                            }
                            else
                            {
                                // Get the position of each piece for the first move 
                                for (int i = 0; i < Puzzle.NUM_PIECES; i++)
                                {
                                    positions[i] = solution[0, i];
                                }
                            }
                            #endregion
                        }
                    }
                }

                #region Change BackColor of all puzzle pieces back to their default colors
                for (int i = 0; i < Puzzle.NUM_PIECES; i++)
                {
                    if (pieces[i].Text != String.Empty)
                    {
                        // Not the "Empty Tile"
                        pieces[i].BackColor = Properties.Settings.Default.BackColor;
                    }
                    else
                    {
                        // This is the "Empty Tile"
                        pieces[i].BackColor = emptyPieceColor;
                    }
                }
                #endregion
            }
        }

        /// <summary>
        /// Saves user settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSettingsChanged(object sender, SettingsEventArgs e)
        {
            // Call ChangeSettings method to apply settings
            ChangeSettings(e);

            #region Add user settings passed to their relevent property and save
            Properties.Settings.Default.BackColor = e.BackColor;
            Properties.Settings.Default.SuggestedTileColor = e.SuggestedTileColor;
            Properties.Settings.Default.PossibleTilesColor = e.PossibleTilesColor;
            Properties.Settings.Default.ForeColor = e.ForeColor;
            Properties.Settings.Default.SecForeColor = e.SecForeColor;
            Properties.Settings.Default.Font = e.Font;
            Properties.Settings.Default.Save();
            #endregion
        }

        /// <summary>
        /// Applys user settings
        /// </summary>
        /// <param name="settings"></param>
        private void ChangeSettings(SettingsEventArgs settings)
        {
            #region Change settings of puzzle pieces
            for (int i = 0; i < Puzzle.NUM_PIECES; i++)
            {
                pieces[i].Font = settings.Font;
                pieces[i].BackColor = settings.BackColor;
                pieces[i].ForeColor = settings.ForeColor;

                if (pieces[i].Text == String.Empty)
                {
                    pieces[i].BackColor = settings.ForeColor;
                }
            }
            emptyPieceColor = settings.ForeColor;
            suggestedPieceColor = settings.SuggestedTileColor;
            possiblePieceColor = settings.PossibleTilesColor;
            #endregion

            #region Change settings of GroupBox controls
            groupBoxOptions.ForeColor = settings.ForeColor;
            groupBoxConfigs.ForeColor = settings.ForeColor;
            groupBoxPlayModes.ForeColor = settings.ForeColor;
            groupBoxStats.ForeColor = settings.ForeColor;
            #endregion

            #region Change settings of Button controls
            btnSettings.ForeColor = settings.ForeColor;
            btnShuffle.ForeColor = settings.ForeColor;
            btnCustomConfig.ForeColor = settings.ForeColor;
            btnNext.ForeColor = settings.ForeColor;
            btnAutoPlay.ForeColor = settings.ForeColor;
            #endregion

            #region Change settings of Label controls
            labelMoveText.BackColor = settings.ForeColor;
            labelMovesText.BackColor = settings.ForeColor;
            labelOfText.ForeColor = settings.ForeColor;
            labelStatus.BackColor = settings.ForeColor;
            labelMoveText.ForeColor = settings.BackColor;
            labelMovesText.ForeColor = settings.BackColor;
            labelCurrentMove.ForeColor = settings.SecForeColor;
            labelMovesNeeded.ForeColor = settings.SecForeColor;
            labelStatus.ForeColor = settings.BackColor;
            #endregion

            #region Change settings of Form
            BackColor = settings.BackColor;
            #endregion
        }

        /// <summary>
        /// Triggers Shuffle and Populate of the puzzle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShuffle_Click(object sender, EventArgs e)
        {
            // Set move and moves variables
            move = 1;
            moves = Puzzle.MAX_MOVES;

            // Call Shuffle and Populate methods
            Shuffle();
            Populate();

            // Reset current move and moves needed labels
            labelMovesNeeded.Text = (moves - 1).ToString();
            labelCurrentMove.Text = (move - 1).ToString();
        }

        /// <summary>
        /// Shuffles the puzzle randomly till find a solution
        /// </summary>
        private void Shuffle()
        {
            Cursor = Cursors.WaitCursor; // Change mouse cursor to WaitCursor

            #region Shuffle and solve till find a solution under given amount of moves
            while (moves == Puzzle.MAX_MOVES)
            {
                AStar aStar = new AStar();
                aStar.Shuffle();
                moves = aStar.Solve(ref solution, null);
            }
            #endregion

            // Get the position of each piece for the first move 
            for (int i = 0; i < Puzzle.NUM_PIECES; i++)
            {
                positions[i] = solution[0, i];
            }

            groupBoxPlayModes.Enabled = true;
            labelStatus.Text = AI_MODE;
            isShuffled = true;
            Cursor = Cursors.Default; // Change mouse cursor back to default
        }

        /// <summary>
        /// Launches Custom Configurations window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCustomConfig_Click(object sender, EventArgs e)
        {
            // Show an instance of "Common" form with "Custom_Config_Panel" User control added in
            Common form = new Common(CUSTOM_CONFIG_PANEL);
            form.ShowDialog(); // Show as a modal
        }

        /// <summary>
        /// Triggers when a custom configuration is added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCustomConfigSolved(object sender, CustomConfigEventArgs e)
        {
            // Set move and moves variables
            move = 1;
            labelCurrentMove.Text = (move - 1).ToString();
            moves = e.Moves;
            labelMovesNeeded.Text = (moves - 1).ToString();            

            // Set Solution and Positions
            solution = e.Solution;
            positions = e.Positions;

            #region Loop thru all puzzle pieces to populate and set values to them
            for (int i = 0; i < Puzzle.NUM_PIECES; i++)
            {
                // Assign the value to the relevent puzzle piece
                pieces[i].Text = positions[i].ToString();

                #region Check for the "Empty Tile"
                if (positions[i] == 0)
                {
                    // This is the "Empty Tile"
                    pieces[i].Text = null;
                    pieces[i].BackColor = emptyPieceColor;
                }
                else
                {
                    // Not the "Empty Tile"
                    pieces[i].BackColor = Properties.Settings.Default.BackColor;
                }
                #endregion
            }
            #endregion

            groupBoxPlayModes.Enabled = true;
            labelStatus.Text = AI_MODE;
            isShuffled = true;
        }

        /// <summary>
        /// Slides the two puzzle pieces related to the next move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNext_Click(object sender, EventArgs e)
        {
            // Check if the puzzle has already been fixed
            if (move < moves)
            {
                // Not yet fixed
                labelStatus.Text = AI_MODE;

                #region Change position of each puzzle piece according to the solution
                for (int i = 0; i < Puzzle.NUM_PIECES; i++)
                {
                    // Get solution value for the current position
                    positions[i] = solution[move, i];

                    // Assign the value to the relevent puzzle piece
                    pieces[i].Text = positions[i].ToString();

                    #region Check for the "Empty Tile"
                    if (positions[i] == 0)
                    {
                        // This is the "Empty Tile"
                        pieces[i].Text = null;
                        pieces[i].BackColor = emptyPieceColor;
                    }
                    else
                    {
                        // Not the "Empty Tile"
                        pieces[i].BackColor = Properties.Settings.Default.BackColor;
                    }
                    #endregion
                }
                #endregion

                // Set current move
                move++;
                labelCurrentMove.Text = (move - 1).ToString();
            }
            else
            {
                // Fixed
                groupBoxPlayModes.Enabled = false;
                labelStatus.Text = IDLE_MODE;
            }
        }

        /// <summary>
        /// Performs Auto Play or Pause Auto Play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAutoPlay_Click(object sender, EventArgs e)
        {
            // Check button state
            if (btnAutoPlay.Text == BTN_AUTO_PLAY)
            {
                // btnAutoPlay clicked, therefore enable autoPlayTimer
                autoPlayTimer.Enabled = true;
                groupBoxConfigs.Enabled = false;
                btnNext.Enabled = false;
                btnAutoPlay.Text = BTN_PAUSE;
            }
            else
            {
                // btnPause clicked, therefore disable autoPlayTimer
                autoPlayTimer.Enabled = false;
                groupBoxConfigs.Enabled = true;
                btnNext.Enabled = true;
                btnAutoPlay.Text = BTN_AUTO_PLAY;
            }
        }

        /// <summary>
        /// Continues Auto Play on timer tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTimerTick(object sender, EventArgs e)
        {
            // Check if the puzzle has already been fixed
            if (move < moves)
            {
                // Not yet fixed
                labelStatus.Text = AUTO_MODE;

                #region Change position of each puzzle piece according to the solution
                for (int i = 0; i < Puzzle.NUM_PIECES; i++)
                {
                    // Get solution value for the current position
                    positions[i] = solution[move, i];

                    // Assign the value to the relevent puzzle piece
                    pieces[i].Text = positions[i].ToString();

                    #region Check for the "Empty Tile"
                    if (positions[i] == 0)
                    {
                        // This is the "Empty Tile"
                        pieces[i].Text = null;
                        pieces[i].BackColor = emptyPieceColor;
                    }
                    else
                    {
                        // Not the "Empty Tile"
                        pieces[i].BackColor = Properties.Settings.Default.BackColor;
                    }
                    #endregion
                }
                #endregion

                // Set current move
                move++;
                labelCurrentMove.Text = (move - 1).ToString();
            }
            else
            {
                // Fixed, therefore disable the autoPlayTimer
                autoPlayTimer.Enabled = false;
                groupBoxConfigs.Enabled = true;
                btnNext.Enabled = true;
                groupBoxPlayModes.Enabled = false;
                btnAutoPlay.Text = BTN_AUTO_PLAY;
                labelStatus.Text = IDLE_MODE;
            }
        }

        /// <summary>
        /// Launches Settings window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            // Show an instance of "Common" form with "Settings_Panel" User control added in
            Common form = new Common(SETTINGS_PANEL);
            form.ShowDialog(); // Show as a modal
        }
    }
}