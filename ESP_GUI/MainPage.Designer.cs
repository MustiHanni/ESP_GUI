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
            this.InputLabel = new System.Windows.Forms.Label();
            this.InputNrUpDown = new System.Windows.Forms.NumericUpDown();
            this.Output = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.InputNrUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(426, 236);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(100, 41);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // InputLabel
            // 
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(12, 36);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(75, 21);
            this.InputLabel.TabIndex = 1;
            this.InputLabel.Text = "Input";
            // 
            // InputNrUpDown
            // 
            this.InputNrUpDown.Location = new System.Drawing.Point(135, 38);
            this.InputNrUpDown.Name = "InputNrUpDown";
            this.InputNrUpDown.Size = new System.Drawing.Size(165, 20);
            this.InputNrUpDown.TabIndex = 2;
            this.InputNrUpDown.ValueChanged += new System.EventHandler(this.InputNrUpDown1_ValueChanged);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(426, 192);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(100, 41);
            this.Output.TabIndex = 3;
            this.Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.Location = new System.Drawing.Point(12, 77);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(76, 20);
            this.PortLabel.TabIndex = 4;
            this.PortLabel.Text = "USB Port";
            // 
            // PortComboBox
            // 
            this.PortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.Location = new System.Drawing.Point(135, 76);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(165, 21);
            this.PortComboBox.TabIndex = 5;
            this.PortComboBox.SelectedIndexChanged += new System.EventHandler(this.PortComboBox_SelectedIndexChanged);
            this.PortComboBox.Click += new System.EventHandler(this.PortComboBox_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(538, 289);
            this.Controls.Add(this.PortComboBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.InputNrUpDown);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.SendButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Connect_ESP";
            ((System.ComponentModel.ISupportInitialize)(this.InputNrUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.NumericUpDown InputNrUpDown;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.ComboBox PortComboBox;
    }
}

