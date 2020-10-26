namespace _8_Puzzle
{
    partial class Custom_Config_Panel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new _8_Puzzle.CustomButton();
            this.btnCancel = new _8_Puzzle.CustomButton();
            this.btnReset = new _8_Puzzle.CustomButton();
            this.numFirstBox = new System.Windows.Forms.NumericUpDown();
            this.numSecondBox = new System.Windows.Forms.NumericUpDown();
            this.numFourthBox = new System.Windows.Forms.NumericUpDown();
            this.numFifthBox = new System.Windows.Forms.NumericUpDown();
            this.numSeventhBox = new System.Windows.Forms.NumericUpDown();
            this.numEightBox = new System.Windows.Forms.NumericUpDown();
            this.numThirdBox = new System.Windows.Forms.NumericUpDown();
            this.numSixthBox = new System.Windows.Forms.NumericUpDown();
            this.numNinthBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecondBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFourthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFifthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeventhBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThirdBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSixthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNinthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.btnOK.Location = new System.Drawing.Point(452, 245);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 35);
            this.btnOK.TabIndex = 10;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(452, 288);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.btnReset.Location = new System.Drawing.Point(452, 41);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 35);
            this.btnReset.TabIndex = 9;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // numFirstBox
            // 
            this.numFirstBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.numFirstBox.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFirstBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.numFirstBox.Location = new System.Drawing.Point(61, 41);
            this.numFirstBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numFirstBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numFirstBox.Name = "numFirstBox";
            this.numFirstBox.Size = new System.Drawing.Size(90, 78);
            this.numFirstBox.TabIndex = 0;
            this.numFirstBox.Tag = "0";
            this.numFirstBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numFirstBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFirstBox.ValueChanged += new System.EventHandler(this.NumBox_ValueChanged);
            // 
            // numSecondBox
            // 
            this.numSecondBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.numSecondBox.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSecondBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.numSecondBox.Location = new System.Drawing.Point(190, 41);
            this.numSecondBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSecondBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numSecondBox.Name = "numSecondBox";
            this.numSecondBox.Size = new System.Drawing.Size(90, 78);
            this.numSecondBox.TabIndex = 1;
            this.numSecondBox.Tag = "1";
            this.numSecondBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSecondBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSecondBox.ValueChanged += new System.EventHandler(this.NumBox_ValueChanged);
            // 
            // numFourthBox
            // 
            this.numFourthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.numFourthBox.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFourthBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.numFourthBox.Location = new System.Drawing.Point(61, 143);
            this.numFourthBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numFourthBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numFourthBox.Name = "numFourthBox";
            this.numFourthBox.Size = new System.Drawing.Size(90, 78);
            this.numFourthBox.TabIndex = 3;
            this.numFourthBox.Tag = "3";
            this.numFourthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numFourthBox.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numFourthBox.ValueChanged += new System.EventHandler(this.NumBox_ValueChanged);
            // 
            // numFifthBox
            // 
            this.numFifthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.numFifthBox.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFifthBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.numFifthBox.Location = new System.Drawing.Point(190, 143);
            this.numFifthBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numFifthBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numFifthBox.Name = "numFifthBox";
            this.numFifthBox.Size = new System.Drawing.Size(90, 78);
            this.numFifthBox.TabIndex = 4;
            this.numFifthBox.Tag = "4";
            this.numFifthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numFifthBox.ValueChanged += new System.EventHandler(this.NumBox_ValueChanged);
            // 
            // numSeventhBox
            // 
            this.numSeventhBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.numSeventhBox.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSeventhBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.numSeventhBox.Location = new System.Drawing.Point(61, 245);
            this.numSeventhBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSeventhBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numSeventhBox.Name = "numSeventhBox";
            this.numSeventhBox.Size = new System.Drawing.Size(90, 78);
            this.numSeventhBox.TabIndex = 6;
            this.numSeventhBox.Tag = "6";
            this.numSeventhBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSeventhBox.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numSeventhBox.ValueChanged += new System.EventHandler(this.NumBox_ValueChanged);
            // 
            // numEightBox
            // 
            this.numEightBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.numEightBox.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEightBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.numEightBox.Location = new System.Drawing.Point(190, 245);
            this.numEightBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numEightBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numEightBox.Name = "numEightBox";
            this.numEightBox.Size = new System.Drawing.Size(90, 78);
            this.numEightBox.TabIndex = 7;
            this.numEightBox.Tag = "7";
            this.numEightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numEightBox.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numEightBox.ValueChanged += new System.EventHandler(this.NumBox_ValueChanged);
            // 
            // numThirdBox
            // 
            this.numThirdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.numThirdBox.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numThirdBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.numThirdBox.Location = new System.Drawing.Point(319, 41);
            this.numThirdBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numThirdBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numThirdBox.Name = "numThirdBox";
            this.numThirdBox.Size = new System.Drawing.Size(90, 78);
            this.numThirdBox.TabIndex = 2;
            this.numThirdBox.Tag = "2";
            this.numThirdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numThirdBox.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numThirdBox.ValueChanged += new System.EventHandler(this.NumBox_ValueChanged);
            // 
            // numSixthBox
            // 
            this.numSixthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.numSixthBox.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSixthBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.numSixthBox.Location = new System.Drawing.Point(319, 143);
            this.numSixthBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSixthBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numSixthBox.Name = "numSixthBox";
            this.numSixthBox.Size = new System.Drawing.Size(90, 78);
            this.numSixthBox.TabIndex = 5;
            this.numSixthBox.Tag = "5";
            this.numSixthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSixthBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numSixthBox.ValueChanged += new System.EventHandler(this.NumBox_ValueChanged);
            // 
            // numNinthBox
            // 
            this.numNinthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.numNinthBox.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNinthBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(28)))), ((int)(((byte)(64)))));
            this.numNinthBox.Location = new System.Drawing.Point(319, 245);
            this.numNinthBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numNinthBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numNinthBox.Name = "numNinthBox";
            this.numNinthBox.Size = new System.Drawing.Size(90, 78);
            this.numNinthBox.TabIndex = 8;
            this.numNinthBox.Tag = "8";
            this.numNinthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNinthBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNinthBox.ValueChanged += new System.EventHandler(this.NumBox_ValueChanged);
            // 
            // Custom_Config_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numNinthBox);
            this.Controls.Add(this.numSixthBox);
            this.Controls.Add(this.numThirdBox);
            this.Controls.Add(this.numEightBox);
            this.Controls.Add(this.numSeventhBox);
            this.Controls.Add(this.numFifthBox);
            this.Controls.Add(this.numFourthBox);
            this.Controls.Add(this.numSecondBox);
            this.Controls.Add(this.numFirstBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Custom_Config_Panel";
            this.Size = new System.Drawing.Size(634, 361);
            ((System.ComponentModel.ISupportInitialize)(this.numFirstBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecondBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFourthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFifthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeventhBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThirdBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSixthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNinthBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton btnOK;
        private CustomButton btnCancel;
        private CustomButton btnReset;
        private System.Windows.Forms.NumericUpDown numFirstBox;
        private System.Windows.Forms.NumericUpDown numSecondBox;
        private System.Windows.Forms.NumericUpDown numFourthBox;
        private System.Windows.Forms.NumericUpDown numFifthBox;
        private System.Windows.Forms.NumericUpDown numSeventhBox;
        private System.Windows.Forms.NumericUpDown numEightBox;
        private System.Windows.Forms.NumericUpDown numThirdBox;
        private System.Windows.Forms.NumericUpDown numSixthBox;
        private System.Windows.Forms.NumericUpDown numNinthBox;
    }
}
