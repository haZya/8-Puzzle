namespace _8_Puzzle
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPuzzleArea = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.groupBoxConfigs = new _8_Puzzle.CustomGroupBox();
            this.btnCustomConfig = new _8_Puzzle.CustomButton();
            this.btnShuffle = new _8_Puzzle.CustomButton();
            this.groupBoxOptions = new _8_Puzzle.CustomGroupBox();
            this.btnSettings = new _8_Puzzle.CustomButton();
            this.groupBoxStats = new _8_Puzzle.CustomGroupBox();
            this.labelMovesNeeded = new System.Windows.Forms.Label();
            this.labelCurrentMove = new System.Windows.Forms.Label();
            this.labelOfText = new System.Windows.Forms.Label();
            this.labelMovesText = new System.Windows.Forms.Label();
            this.labelMoveText = new System.Windows.Forms.Label();
            this.groupBoxPlayModes = new _8_Puzzle.CustomGroupBox();
            this.btnNext = new _8_Puzzle.CustomButton();
            this.btnAutoPlay = new _8_Puzzle.CustomButton();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panelControl.SuspendLayout();
            this.groupBoxConfigs.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxStats.SuspendLayout();
            this.groupBoxPlayModes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPuzzleArea
            // 
            this.panelPuzzleArea.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPuzzleArea.Location = new System.Drawing.Point(0, 0);
            this.panelPuzzleArea.Name = "panelPuzzleArea";
            this.panelPuzzleArea.Size = new System.Drawing.Size(557, 557);
            this.panelPuzzleArea.TabIndex = 1;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.groupBoxConfigs);
            this.panelControl.Controls.Add(this.groupBoxOptions);
            this.panelControl.Controls.Add(this.groupBoxStats);
            this.panelControl.Controls.Add(this.groupBoxPlayModes);
            this.panelControl.Controls.Add(this.labelStatus);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControl.Location = new System.Drawing.Point(557, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(193, 557);
            this.panelControl.TabIndex = 0;
            // 
            // groupBoxConfigs
            // 
            this.groupBoxConfigs.Controls.Add(this.btnCustomConfig);
            this.groupBoxConfigs.Controls.Add(this.btnShuffle);
            this.groupBoxConfigs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConfigs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.groupBoxConfigs.Location = new System.Drawing.Point(13, 97);
            this.groupBoxConfigs.Name = "groupBoxConfigs";
            this.groupBoxConfigs.Padding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.groupBoxConfigs.Size = new System.Drawing.Size(166, 128);
            this.groupBoxConfigs.TabIndex = 17;
            this.groupBoxConfigs.TabStop = false;
            this.groupBoxConfigs.Text = "Configurations";
            // 
            // btnCustomConfig
            // 
            this.btnCustomConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomConfig.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.btnCustomConfig.Location = new System.Drawing.Point(25, 79);
            this.btnCustomConfig.Name = "btnCustomConfig";
            this.btnCustomConfig.Size = new System.Drawing.Size(115, 30);
            this.btnCustomConfig.TabIndex = 17;
            this.btnCustomConfig.Text = "Custom";
            this.btnCustomConfig.UseVisualStyleBackColor = true;
            this.btnCustomConfig.Click += new System.EventHandler(this.BtnCustomConfig_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.btnShuffle.Location = new System.Drawing.Point(25, 30);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(115, 30);
            this.btnShuffle.TabIndex = 16;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.BtnShuffle_Click);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.btnSettings);
            this.groupBoxOptions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.groupBoxOptions.Location = new System.Drawing.Point(13, 8);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Padding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.groupBoxOptions.Size = new System.Drawing.Size(166, 79);
            this.groupBoxOptions.TabIndex = 17;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.btnSettings.Location = new System.Drawing.Point(25, 30);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(115, 30);
            this.btnSettings.TabIndex = 18;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.labelMovesNeeded);
            this.groupBoxStats.Controls.Add(this.labelCurrentMove);
            this.groupBoxStats.Controls.Add(this.labelOfText);
            this.groupBoxStats.Controls.Add(this.labelMovesText);
            this.groupBoxStats.Controls.Add(this.labelMoveText);
            this.groupBoxStats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.groupBoxStats.Location = new System.Drawing.Point(13, 373);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Padding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.groupBoxStats.Size = new System.Drawing.Size(166, 140);
            this.groupBoxStats.TabIndex = 17;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Stats";
            // 
            // labelMovesNeeded
            // 
            this.labelMovesNeeded.BackColor = System.Drawing.Color.Transparent;
            this.labelMovesNeeded.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovesNeeded.ForeColor = System.Drawing.Color.White;
            this.labelMovesNeeded.Location = new System.Drawing.Point(67, 99);
            this.labelMovesNeeded.Name = "labelMovesNeeded";
            this.labelMovesNeeded.Size = new System.Drawing.Size(33, 22);
            this.labelMovesNeeded.TabIndex = 25;
            this.labelMovesNeeded.Text = "0";
            this.labelMovesNeeded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentMove
            // 
            this.labelCurrentMove.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentMove.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentMove.ForeColor = System.Drawing.Color.White;
            this.labelCurrentMove.Location = new System.Drawing.Point(67, 29);
            this.labelCurrentMove.Name = "labelCurrentMove";
            this.labelCurrentMove.Size = new System.Drawing.Size(33, 22);
            this.labelCurrentMove.TabIndex = 24;
            this.labelCurrentMove.Text = "0";
            this.labelCurrentMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOfText
            // 
            this.labelOfText.AutoSize = true;
            this.labelOfText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.labelOfText.Location = new System.Drawing.Point(72, 65);
            this.labelOfText.Name = "labelOfText";
            this.labelOfText.Size = new System.Drawing.Size(23, 20);
            this.labelOfText.TabIndex = 23;
            this.labelOfText.Text = "of";
            // 
            // labelMovesText
            // 
            this.labelMovesText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.labelMovesText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovesText.ForeColor = System.Drawing.Color.White;
            this.labelMovesText.Location = new System.Drawing.Point(103, 99);
            this.labelMovesText.Name = "labelMovesText";
            this.labelMovesText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.labelMovesText.Size = new System.Drawing.Size(52, 22);
            this.labelMovesText.TabIndex = 22;
            this.labelMovesText.Text = "Moves";
            this.labelMovesText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMoveText
            // 
            this.labelMoveText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.labelMoveText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoveText.ForeColor = System.Drawing.Color.White;
            this.labelMoveText.Location = new System.Drawing.Point(12, 29);
            this.labelMoveText.Name = "labelMoveText";
            this.labelMoveText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.labelMoveText.Size = new System.Drawing.Size(52, 22);
            this.labelMoveText.TabIndex = 21;
            this.labelMoveText.Text = "Move";
            this.labelMoveText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxPlayModes
            // 
            this.groupBoxPlayModes.Controls.Add(this.btnNext);
            this.groupBoxPlayModes.Controls.Add(this.btnAutoPlay);
            this.groupBoxPlayModes.Enabled = false;
            this.groupBoxPlayModes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPlayModes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.groupBoxPlayModes.Location = new System.Drawing.Point(13, 235);
            this.groupBoxPlayModes.Name = "groupBoxPlayModes";
            this.groupBoxPlayModes.Padding = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.groupBoxPlayModes.Size = new System.Drawing.Size(166, 128);
            this.groupBoxPlayModes.TabIndex = 17;
            this.groupBoxPlayModes.TabStop = false;
            this.groupBoxPlayModes.Text = "Play Modes";
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.btnNext.Location = new System.Drawing.Point(25, 30);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 30);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next Step";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoPlay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.btnAutoPlay.Location = new System.Drawing.Point(25, 79);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.Size = new System.Drawing.Size(115, 30);
            this.btnAutoPlay.TabIndex = 16;
            this.btnAutoPlay.Text = "Auto Play";
            this.btnAutoPlay.UseVisualStyleBackColor = true;
            this.btnAutoPlay.Click += new System.EventHandler(this.BtnAutoPlay_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(0, 524);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(193, 31);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "Idle";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(750, 557);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelPuzzleArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8 Puzzle";
            this.panelControl.ResumeLayout(false);
            this.groupBoxConfigs.ResumeLayout(false);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.groupBoxPlayModes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPuzzleArea;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label labelStatus;
        private CustomGroupBox groupBoxPlayModes;
        private CustomButton btnNext;
        private CustomButton btnAutoPlay;
        private CustomGroupBox groupBoxStats;
        private System.Windows.Forms.Label labelMovesNeeded;
        private System.Windows.Forms.Label labelCurrentMove;
        private System.Windows.Forms.Label labelOfText;
        private System.Windows.Forms.Label labelMovesText;
        private System.Windows.Forms.Label labelMoveText;
        private CustomGroupBox groupBoxOptions;
        private CustomGroupBox groupBoxConfigs;
        private CustomButton btnCustomConfig;
        private CustomButton btnShuffle;
        private CustomButton btnSettings;
    }
}

