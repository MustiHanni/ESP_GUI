namespace ESP_GUI
{
    partial class MainPage
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.SendButton = new System.Windows.Forms.Button();
            this.ReadCounterLabel = new System.Windows.Forms.Label();
            this.MoveToInputNrUpDown = new System.Windows.Forms.NumericUpDown();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortComboBox = new System.Windows.Forms.ComboBox();
            this.MoveButton = new System.Windows.Forms.Button();
            this.ReadCounterButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ResetCounterButton = new System.Windows.Forms.Button();
            this.SpeedButton = new System.Windows.Forms.Button();
            this.StopLabel = new System.Windows.Forms.Label();
            this.ResetCounterLabel = new System.Windows.Forms.Label();
            this.SpeedInputNrUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.OutputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoveToInputNrUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedInputNrUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(385, 117);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(108, 286);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ReadCounterLabel
            // 
            this.ReadCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadCounterLabel.Location = new System.Drawing.Point(185, 80);
            this.ReadCounterLabel.Name = "ReadCounterLabel";
            this.ReadCounterLabel.Size = new System.Drawing.Size(158, 53);
            this.ReadCounterLabel.TabIndex = 1;
            this.ReadCounterLabel.Text = "Read Counter";
            this.ReadCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MoveToInputNrUpDown
            // 
            this.MoveToInputNrUpDown.Location = new System.Drawing.Point(189, 30);
            this.MoveToInputNrUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MoveToInputNrUpDown.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.MoveToInputNrUpDown.Name = "MoveToInputNrUpDown";
            this.MoveToInputNrUpDown.Size = new System.Drawing.Size(154, 20);
            this.MoveToInputNrUpDown.TabIndex = 2;
            this.MoveToInputNrUpDown.ValueChanged += new System.EventHandler(this.MoveStepInputNrUpDown_ValueChanged);
            // 
            // PortLabel
            // 
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.Location = new System.Drawing.Point(381, 9);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(112, 38);
            this.PortLabel.TabIndex = 4;
            this.PortLabel.Text = "USB Port";
            this.PortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PortComboBox
            // 
            this.PortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.Location = new System.Drawing.Point(385, 80);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(108, 21);
            this.PortComboBox.TabIndex = 5;
            this.PortComboBox.SelectedIndexChanged += new System.EventHandler(this.PortComboBox_SelectedIndexChanged);
            this.PortComboBox.Click += new System.EventHandler(this.PortComboBox_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(12, 12);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(154, 53);
            this.MoveButton.TabIndex = 6;
            this.MoveButton.Text = "Move To";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // ReadCounterButton
            // 
            this.ReadCounterButton.Location = new System.Drawing.Point(12, 80);
            this.ReadCounterButton.Name = "ReadCounterButton";
            this.ReadCounterButton.Size = new System.Drawing.Size(154, 53);
            this.ReadCounterButton.TabIndex = 7;
            this.ReadCounterButton.Text = "Read Counter";
            this.ReadCounterButton.UseVisualStyleBackColor = true;
            this.ReadCounterButton.Click += new System.EventHandler(this.ReadCounterButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(12, 143);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(154, 53);
            this.LeftButton.TabIndex = 8;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(189, 143);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(154, 53);
            this.RightButton.TabIndex = 9;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(12, 213);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(154, 53);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ResetCounterButton
            // 
            this.ResetCounterButton.Location = new System.Drawing.Point(12, 281);
            this.ResetCounterButton.Name = "ResetCounterButton";
            this.ResetCounterButton.Size = new System.Drawing.Size(154, 53);
            this.ResetCounterButton.TabIndex = 11;
            this.ResetCounterButton.Text = "Reset Counter";
            this.ResetCounterButton.UseVisualStyleBackColor = true;
            this.ResetCounterButton.Click += new System.EventHandler(this.ResetCounterButton_Click);
            // 
            // SpeedButton
            // 
            this.SpeedButton.Location = new System.Drawing.Point(12, 350);
            this.SpeedButton.Name = "SpeedButton";
            this.SpeedButton.Size = new System.Drawing.Size(154, 53);
            this.SpeedButton.TabIndex = 12;
            this.SpeedButton.Text = "Set Speed";
            this.SpeedButton.UseVisualStyleBackColor = true;
            this.SpeedButton.Click += new System.EventHandler(this.SpeedButton_Click);
            // 
            // StopLabel
            // 
            this.StopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopLabel.Location = new System.Drawing.Point(185, 213);
            this.StopLabel.Name = "StopLabel";
            this.StopLabel.Size = new System.Drawing.Size(158, 53);
            this.StopLabel.TabIndex = 13;
            this.StopLabel.Text = "Stop";
            this.StopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ResetCounterLabel
            // 
            this.ResetCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetCounterLabel.Location = new System.Drawing.Point(185, 281);
            this.ResetCounterLabel.Name = "ResetCounterLabel";
            this.ResetCounterLabel.Size = new System.Drawing.Size(158, 53);
            this.ResetCounterLabel.TabIndex = 14;
            this.ResetCounterLabel.Text = "Reset Counter ";
            this.ResetCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SpeedInputNrUpDown1
            // 
            this.SpeedInputNrUpDown1.Location = new System.Drawing.Point(189, 368);
            this.SpeedInputNrUpDown1.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.SpeedInputNrUpDown1.Name = "SpeedInputNrUpDown1";
            this.SpeedInputNrUpDown1.Size = new System.Drawing.Size(154, 20);
            this.SpeedInputNrUpDown1.TabIndex = 15;
            this.SpeedInputNrUpDown1.TabStop = false;
            this.SpeedInputNrUpDown1.ValueChanged += new System.EventHandler(this.SpeedInputNrUpDown_ValueChanged);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(12, 426);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(481, 53);
            this.OutputLabel.TabIndex = 16;
            this.OutputLabel.Text = "Data Stream";
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(531, 488);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.SpeedInputNrUpDown1);
            this.Controls.Add(this.ResetCounterLabel);
            this.Controls.Add(this.StopLabel);
            this.Controls.Add(this.SpeedButton);
            this.Controls.Add(this.ResetCounterButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.ReadCounterButton);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.PortComboBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.MoveToInputNrUpDown);
            this.Controls.Add(this.ReadCounterLabel);
            this.Controls.Add(this.SendButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Connect_ESP";
            ((System.ComponentModel.ISupportInitialize)(this.MoveToInputNrUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedInputNrUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label ReadCounterLabel;
        private System.Windows.Forms.NumericUpDown MoveToInputNrUpDown;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.ComboBox PortComboBox;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button ReadCounterButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ResetCounterButton;
        private System.Windows.Forms.Button SpeedButton;
        private System.Windows.Forms.Label StopLabel;
        private System.Windows.Forms.Label ResetCounterLabel;
        private System.Windows.Forms.NumericUpDown SpeedInputNrUpDown1;
        private System.Windows.Forms.Label OutputLabel;
    }
}

