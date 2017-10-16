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
            this.MoveToInputNrUpDown = new System.Windows.Forms.NumericUpDown();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortComboBox = new System.Windows.Forms.ComboBox();
            this.SpeedInputNrUpDown = new System.Windows.Forms.NumericUpDown();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.MoveToCheckBox = new System.Windows.Forms.CheckBox();
            this.ReadCounterCheckBox = new System.Windows.Forms.CheckBox();
            this.LefCheckBox = new System.Windows.Forms.CheckBox();
            this.StopCheckBox = new System.Windows.Forms.CheckBox();
            this.ResetCheckBox = new System.Windows.Forms.CheckBox();
            this.SpeedCheckBox = new System.Windows.Forms.CheckBox();
            this.RightCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MoveToInputNrUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedInputNrUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Enabled = false;
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(385, 97);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(108, 286);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MoveToInputNrUpDown
            // 
            this.MoveToInputNrUpDown.Enabled = false;
            this.MoveToInputNrUpDown.Location = new System.Drawing.Point(12, 58);
            this.MoveToInputNrUpDown.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.MoveToInputNrUpDown.Minimum = new decimal(new int[] {
            0,
            -2147483648,
            0,
            -2147483648});
            this.MoveToInputNrUpDown.Name = "MoveToInputNrUpDown";
            this.MoveToInputNrUpDown.Size = new System.Drawing.Size(154, 20);
            this.MoveToInputNrUpDown.TabIndex = 2;
            this.MoveToInputNrUpDown.Tag = "kick";
            this.MoveToInputNrUpDown.ValueChanged += new System.EventHandler(this.MoveStepInputNrUpDown_ValueChanged);
            // 
            // PortLabel
            // 
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.Location = new System.Drawing.Point(553, 28);
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
            this.PortComboBox.Location = new System.Drawing.Point(233, 186);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(108, 21);
            this.PortComboBox.TabIndex = 5;
            this.PortComboBox.SelectedIndexChanged += new System.EventHandler(this.PortComboBox_SelectedIndexChanged);
            this.PortComboBox.Click += new System.EventHandler(this.PortComboBox_Click);
            // 
            // SpeedInputNrUpDown
            // 
            this.SpeedInputNrUpDown.Enabled = false;
            this.SpeedInputNrUpDown.Location = new System.Drawing.Point(12, 314);
            this.SpeedInputNrUpDown.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.SpeedInputNrUpDown.Name = "SpeedInputNrUpDown";
            this.SpeedInputNrUpDown.Size = new System.Drawing.Size(154, 20);
            this.SpeedInputNrUpDown.TabIndex = 15;
            this.SpeedInputNrUpDown.TabStop = false;
            this.SpeedInputNrUpDown.ValueChanged += new System.EventHandler(this.SpeedInputNrUpDown_ValueChanged);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(110, 426);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(481, 53);
            this.OutputLabel.TabIndex = 16;
            this.OutputLabel.Text = "XX-XX-XX-XX-XX-XX-XX-XX-XX";
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoveToCheckBox
            // 
            this.MoveToCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.MoveToCheckBox.Location = new System.Drawing.Point(12, 12);
            this.MoveToCheckBox.Name = "MoveToCheckBox";
            this.MoveToCheckBox.Size = new System.Drawing.Size(100, 40);
            this.MoveToCheckBox.TabIndex = 17;
            this.MoveToCheckBox.Text = "Move To";
            this.MoveToCheckBox.UseVisualStyleBackColor = false;
            this.MoveToCheckBox.CheckedChanged += new System.EventHandler(this.MoveToCheckBox_CheckedChanged);
            // 
            // ReadCounterCheckBox
            // 
            this.ReadCounterCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ReadCounterCheckBox.Location = new System.Drawing.Point(12, 84);
            this.ReadCounterCheckBox.Name = "ReadCounterCheckBox";
            this.ReadCounterCheckBox.Size = new System.Drawing.Size(100, 40);
            this.ReadCounterCheckBox.TabIndex = 18;
            this.ReadCounterCheckBox.Text = "Read Counter";
            this.ReadCounterCheckBox.UseVisualStyleBackColor = false;
            this.ReadCounterCheckBox.CheckedChanged += new System.EventHandler(this.ReadCounterCheckBox_CheckedChanged);
            // 
            // LefCheckBox
            // 
            this.LefCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.LefCheckBox.Location = new System.Drawing.Point(12, 130);
            this.LefCheckBox.Name = "LefCheckBox";
            this.LefCheckBox.Size = new System.Drawing.Size(100, 40);
            this.LefCheckBox.TabIndex = 19;
            this.LefCheckBox.Text = "Left";
            this.LefCheckBox.UseVisualStyleBackColor = false;
            this.LefCheckBox.CheckedChanged += new System.EventHandler(this.LefCheckBox_CheckedChanged);
            // 
            // StopCheckBox
            // 
            this.StopCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.StopCheckBox.Location = new System.Drawing.Point(12, 176);
            this.StopCheckBox.Name = "StopCheckBox";
            this.StopCheckBox.Size = new System.Drawing.Size(100, 40);
            this.StopCheckBox.TabIndex = 20;
            this.StopCheckBox.Text = "Stop";
            this.StopCheckBox.UseVisualStyleBackColor = false;
            this.StopCheckBox.CheckedChanged += new System.EventHandler(this.StopCheckBox_CheckedChanged);
            // 
            // ResetCheckBox
            // 
            this.ResetCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ResetCheckBox.Location = new System.Drawing.Point(12, 222);
            this.ResetCheckBox.Name = "ResetCheckBox";
            this.ResetCheckBox.Size = new System.Drawing.Size(100, 40);
            this.ResetCheckBox.TabIndex = 21;
            this.ResetCheckBox.Text = "Reset Counter";
            this.ResetCheckBox.UseVisualStyleBackColor = false;
            this.ResetCheckBox.CheckedChanged += new System.EventHandler(this.ResetCheckBox_CheckedChanged);
            // 
            // SpeedCheckBox
            // 
            this.SpeedCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.SpeedCheckBox.Location = new System.Drawing.Point(12, 268);
            this.SpeedCheckBox.Name = "SpeedCheckBox";
            this.SpeedCheckBox.Size = new System.Drawing.Size(100, 40);
            this.SpeedCheckBox.TabIndex = 22;
            this.SpeedCheckBox.Text = "Set Speed";
            this.SpeedCheckBox.UseVisualStyleBackColor = false;
            this.SpeedCheckBox.CheckedChanged += new System.EventHandler(this.SpeedCheckBox_CheckedChanged);
            // 
            // RightCheckBox
            // 
            this.RightCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.RightCheckBox.Location = new System.Drawing.Point(118, 130);
            this.RightCheckBox.Name = "RightCheckBox";
            this.RightCheckBox.Size = new System.Drawing.Size(100, 40);
            this.RightCheckBox.TabIndex = 23;
            this.RightCheckBox.Text = "Right";
            this.RightCheckBox.UseVisualStyleBackColor = false;
            this.RightCheckBox.CheckedChanged += new System.EventHandler(this.RightCheckBox_CheckedChanged);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(960, 488);
            this.Controls.Add(this.RightCheckBox);
            this.Controls.Add(this.SpeedCheckBox);
            this.Controls.Add(this.ResetCheckBox);
            this.Controls.Add(this.StopCheckBox);
            this.Controls.Add(this.LefCheckBox);
            this.Controls.Add(this.ReadCounterCheckBox);
            this.Controls.Add(this.MoveToCheckBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.SpeedInputNrUpDown);
            this.Controls.Add(this.PortComboBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.MoveToInputNrUpDown);
            this.Controls.Add(this.SendButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Connect_ESP";
            ((System.ComponentModel.ISupportInitialize)(this.MoveToInputNrUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedInputNrUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.NumericUpDown MoveToInputNrUpDown;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.ComboBox PortComboBox;
        private System.Windows.Forms.NumericUpDown SpeedInputNrUpDown;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.CheckBox MoveToCheckBox;
        private System.Windows.Forms.CheckBox ReadCounterCheckBox;
        private System.Windows.Forms.CheckBox LefCheckBox;
        private System.Windows.Forms.CheckBox StopCheckBox;
        private System.Windows.Forms.CheckBox ResetCheckBox;
        private System.Windows.Forms.CheckBox SpeedCheckBox;
        private System.Windows.Forms.CheckBox RightCheckBox;
    }
}

