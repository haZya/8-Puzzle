using System;
using System.Windows.Forms;

namespace _8_Puzzle
{
    /// <summary>
    /// Contains events and methods of Common form
    /// </summary>
    public partial class Common : Form
    {
        /// <summary>
        /// Initialization
        /// </summary>
        /// <param name="instance"></param>
        public Common(string instance)
        {
            InitializeComponent();

            // Check whcih window user wants to open
            if (instance == Main.SETTINGS_PANEL)
            {
                // Launch Settings_Panel
                Text = Main.SETTINGS_PANEL;
                panelContainer.Controls.Add(Settings_Panel.GetInstance());
            }
            else
            {
                // Launch Custom_Config_Panel
                Text = Main.CUSTOM_CONFIG_PANEL;
                panelContainer.Controls.Add(Custom_Config_Panel.GetInstance());
            }
        }

        /// <summary>
        /// Applys the settings if they have been reset to deafult on form closing
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Check if the settings have been reset to default
            if (Settings_Panel.isReset)
            {
                // If yes, apply the settings
                Settings_Panel settingsPnl = new Settings_Panel();
                settingsPnl.ApplySettings();
            }

            base.OnFormClosing(e);
        }

        /// <summary>
        /// Changes the form opacity on back color changed
        /// </summary>
        /// <param name="e"></param>
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);

            // Change form opacity to 98
            Opacity = .98;
        }
    }
}