using System;
using System.Drawing;
using System.Windows.Forms;

namespace _8_Puzzle
{
    /// <summary>
    /// Contains events and methods of Settings_Panel User Control
    /// </summary>
    public partial class Settings_Panel : UserControl
    {
        #region Global variables
        private static Settings_Panel instance;
        private ColorPicker colorPicker;
        private FontPicker fontPicker;
        private Color selectedBackColor, selectedSugTileColor, selectedPosTilesColor;
        private Color selectedForeColor, selectedSecForeColor;
        private Font selectedFont;
        public static bool isReset;
        public static event EventHandler<SettingsEventArgs> OnSettingsChanged;
        #endregion

        /// <summary>
        /// Initialization
        /// </summary>
        public Settings_Panel()
        {
            InitializeComponent();

            // Call Populate method
            Populate();

            colorPicker = new ColorPicker();
            fontPicker = new FontPicker();
        }

        /// <summary>
        /// Populates and applys settings on load
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

            #region Change settings of GroupBox controls
            groupBoxFormSettings.ForeColor = foreColor;
            groupBoxFontSettings.ForeColor = foreColor;
            #endregion

            #region Change settings of Button controls
            btnBackColor.ForeColor = foreColor;
            btnSuggestedColor.ForeColor = foreColor;
            btnPossibleColor.ForeColor = foreColor;
            btnForeColor.ForeColor = foreColor;
            btnSecForeColor.ForeColor = foreColor;
            btnFont.ForeColor = foreColor;
            btnReset.ForeColor = foreColor;
            btnOK.ForeColor = foreColor;
            btnCancel.ForeColor = foreColor;
            #endregion

            #region Change settings of Label controls
            labelBackColorText.ForeColor = foreColor;
            labelSugTileColorText.ForeColor = foreColor;
            labelPosTilesColorText.ForeColor = foreColor;
            labelForeColorText.ForeColor = foreColor;
            labelSecForeColorText.ForeColor = foreColor;
            labelFontText.ForeColor = foreColor;
            labelFont.BackColor = foreColor;
            labelFont.ForeColor = backColor;
            #endregion

            // Call Populate method
            // Necessary for invalidation On Load
            Populate();
        }

        /// <summary>
        /// Assigns user settings to the fields
        /// </summary>
        private void Populate()
        {
            #region Get user settings
            selectedBackColor = Properties.Settings.Default.BackColor;
            selectedSugTileColor = Properties.Settings.Default.SuggestedTileColor;
            selectedPosTilesColor = Properties.Settings.Default.PossibleTilesColor;
            selectedForeColor = Properties.Settings.Default.ForeColor;
            selectedSecForeColor = Properties.Settings.Default.SecForeColor;
            selectedFont = Properties.Settings.Default.Font;
            #endregion

            #region Assign user settings to the relevent fields
            pictureBoxBackColor.BackColor = selectedBackColor;
            pictureBoxSugTileColor.BackColor = selectedSugTileColor;
            pictureBoxPosTilesColor.BackColor = selectedPosTilesColor;
            pictureBoxForeColor.BackColor = selectedForeColor;
            pictureBoxSecFColor.BackColor = selectedSecForeColor;
            labelFont.Text = $"{ selectedFont.Name }, { selectedFont.Style }, { selectedFont.Size }";
            #endregion
        }

        /// <summary>
        /// Get an instance of the UserControl
        /// </summary>
        /// <returns></returns>
        public static Settings_Panel GetInstance()
        {
            if (instance == null)
            {
                // Get an instance, if does not already exists
                instance = new Settings_Panel();
            }

            return instance;
        }

        /// <summary>
        /// Launchs ColorDialog window to pick BackColor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBackColor_Click(object sender, EventArgs e)
        {
            Color color = colorPicker.GetColor();

            if (color != Color.Empty)
            {
                // User has picked a color
                selectedBackColor = color;
                pictureBoxBackColor.BackColor = selectedBackColor;
            }
        }

        /// <summary>
        /// Launchs ColorDialog window to pick a color fr "Suggested Tile"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuggestedColor_Click(object sender, EventArgs e)
        {
            Color color = colorPicker.GetColor();

            if (color != Color.Empty)
            {
                // User has picked a color
                selectedSugTileColor = color;
                pictureBoxSugTileColor.BackColor = selectedSugTileColor;
            }
        }

        /// <summary>
        /// Launchs ColorDialog window to pick a color for "Possible Tile"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPossibleColor_Click(object sender, EventArgs e)
        {
            Color color = colorPicker.GetColor();

            if (color != Color.Empty)
            {
                // User has picked a color
                selectedPosTilesColor = color;
                pictureBoxPosTilesColor.BackColor = selectedPosTilesColor;
            }
        }

        /// <summary>
        /// Launchs ColorDialog window to pick fore color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnForeColor_Click(object sender, EventArgs e)
        {
            Color color = colorPicker.GetColor();
            if (color != Color.Empty)
            {
                // User has picked a color
                selectedForeColor = color;
                pictureBoxForeColor.BackColor = selectedForeColor;
            }
        }

        /// <summary>
        /// Launchs ColorDialog window to pick secondary fore color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSecForeColor_Click(object sender, EventArgs e)
        {
            Color color = colorPicker.GetColor();

            if (color != Color.Empty)
            {
                // User has picked a color
                selectedSecForeColor = color;
                pictureBoxSecFColor.BackColor = selectedSecForeColor;
            }
        }

        /// <summary>
        /// Launchs FontDialog window to pick a font for the puzzle pieces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFont_Click(object sender, EventArgs e)
        {
            Font font = fontPicker.GetFont();

            if (font != null)
            {
                // User has picked a color
                selectedFont = font;
                labelFont.Text = $"{ selectedFont.Name }, { selectedFont.Style }, { selectedFont.Size }";
            }
        }

        /// <summary>
        /// Applys settings and close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOK_Click(object sender, EventArgs e)
        {
            // Call ApplySettings method
            ApplySettings();

            // Close parent form
            ParentForm.Close();
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

        /// <summary>
        /// Resets the settings to their default state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            #region Reset settings to default and save
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
            #endregion

            #region Apply the affected settings
            selectedBackColor = Properties.Settings.Default.BackColor;
            selectedSugTileColor = Properties.Settings.Default.SuggestedTileColor;
            selectedPosTilesColor = Properties.Settings.Default.PossibleTilesColor;
            selectedForeColor = Properties.Settings.Default.ForeColor;
            selectedSecForeColor = Properties.Settings.Default.SecForeColor;
            selectedFont = Properties.Settings.Default.Font;
            #endregion

            #region Apply to the fields
            pictureBoxBackColor.BackColor = selectedBackColor;
            pictureBoxSugTileColor.BackColor = selectedSugTileColor;
            pictureBoxPosTilesColor.BackColor = selectedPosTilesColor;
            pictureBoxForeColor.BackColor = selectedForeColor;
            pictureBoxSecFColor.BackColor = selectedSecForeColor;
            labelFont.Text = $"{ selectedFont.Name }, { selectedFont.Style }, { selectedFont.Size }";
            #endregion

            isReset = true;
        }

        /// <summary>
        /// Passes the settings in order to apply
        /// </summary>
        public void ApplySettings()
        {
            #region Set values for settings
            SettingsEventArgs settings = new SettingsEventArgs()
            {
                BackColor = selectedBackColor,
                SuggestedTileColor = selectedSugTileColor,
                PossibleTilesColor = selectedPosTilesColor,
                ForeColor = selectedForeColor,
                SecForeColor = selectedSecForeColor,
                Font = selectedFont
            };
            #endregion

            // Invoke the custom event
            OnSettingsChanged.Invoke(this, settings);
        }
    }
}