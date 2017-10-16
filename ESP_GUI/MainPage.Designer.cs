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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.MoveToInputNrUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedInputNrUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendButton.Enabled = false;
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(424, 3);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(95, 65);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MoveToInputNrUpDown
            // 
            this.MoveToInputNrUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveToInputNrUpDown.Enabled = false;
            this.MoveToInputNrUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveToInputNrUpDown.Location = new System.Drawing.Point(3, 3);
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
            this.MoveToInputNrUpDown.Size = new System.Drawing.Size(364, 26);
            this.MoveToInputNrUpDown.TabIndex = 2;
            this.MoveToInputNrUpDown.Tag = "kick";
            this.MoveToInputNrUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MoveToInputNrUpDown.ValueChanged += new System.EventHandler(this.MoveStepInputNrUpDown_ValueChanged);
            // 
            // PortLabel
            // 
            this.PortLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.Location = new System.Drawing.Point(3, 0);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(409, 21);
            this.PortLabel.TabIndex = 4;
            this.PortLabel.Text = "USB Port";
            this.PortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PortComboBox
            // 
            this.PortComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortComboBox.FormattingEnabled = true;
            this.PortComboBox.Location = new System.Drawing.Point(3, 24);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(409, 24);
            this.PortComboBox.TabIndex = 5;
            this.PortComboBox.SelectedIndexChanged += new System.EventHandler(this.PortComboBox_SelectedIndexChanged);
            this.PortComboBox.Click += new System.EventHandler(this.PortComboBox_Click);
            // 
            // SpeedInputNrUpDown
            // 
            this.SpeedInputNrUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpeedInputNrUpDown.Enabled = false;
            this.SpeedInputNrUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedInputNrUpDown.Location = new System.Drawing.Point(3, 153);
            this.SpeedInputNrUpDown.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.SpeedInputNrUpDown.Name = "SpeedInputNrUpDown";
            this.SpeedInputNrUpDown.Size = new System.Drawing.Size(364, 26);
            this.SpeedInputNrUpDown.TabIndex = 15;
            this.SpeedInputNrUpDown.TabStop = false;
            this.SpeedInputNrUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpeedInputNrUpDown.ValueChanged += new System.EventHandler(this.SpeedInputNrUpDown_ValueChanged);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(3, 42);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(409, 23);
            this.OutputLabel.TabIndex = 16;
            this.OutputLabel.Text = "XX-XX-XX-XX-XX-XX-XX-XX-XX";
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoveToCheckBox
            // 
            this.MoveToCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.MoveToCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoveToCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveToCheckBox.Location = new System.Drawing.Point(3, 3);
            this.MoveToCheckBox.Name = "MoveToCheckBox";
            this.MoveToCheckBox.Size = new System.Drawing.Size(134, 24);
            this.MoveToCheckBox.TabIndex = 17;
            this.MoveToCheckBox.Text = "Move To";
            this.MoveToCheckBox.UseVisualStyleBackColor = false;
            this.MoveToCheckBox.CheckedChanged += new System.EventHandler(this.MoveToCheckBox_CheckedChanged);
            // 
            // ReadCounterCheckBox
            // 
            this.ReadCounterCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ReadCounterCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReadCounterCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadCounterCheckBox.Location = new System.Drawing.Point(3, 33);
            this.ReadCounterCheckBox.Name = "ReadCounterCheckBox";
            this.ReadCounterCheckBox.Size = new System.Drawing.Size(134, 24);
            this.ReadCounterCheckBox.TabIndex = 18;
            this.ReadCounterCheckBox.Text = "Read Counter";
            this.ReadCounterCheckBox.UseVisualStyleBackColor = false;
            this.ReadCounterCheckBox.CheckedChanged += new System.EventHandler(this.ReadCounterCheckBox_CheckedChanged);
            // 
            // LefCheckBox
            // 
            this.LefCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.LefCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LefCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LefCheckBox.Location = new System.Drawing.Point(3, 63);
            this.LefCheckBox.Name = "LefCheckBox";
            this.LefCheckBox.Size = new System.Drawing.Size(134, 24);
            this.LefCheckBox.TabIndex = 19;
            this.LefCheckBox.Text = "Left";
            this.LefCheckBox.UseVisualStyleBackColor = false;
            this.LefCheckBox.CheckedChanged += new System.EventHandler(this.LefCheckBox_CheckedChanged);
            // 
            // StopCheckBox
            // 
            this.StopCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.StopCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopCheckBox.Location = new System.Drawing.Point(3, 93);
            this.StopCheckBox.Name = "StopCheckBox";
            this.StopCheckBox.Size = new System.Drawing.Size(134, 24);
            this.StopCheckBox.TabIndex = 20;
            this.StopCheckBox.Text = "Stop";
            this.StopCheckBox.UseVisualStyleBackColor = false;
            this.StopCheckBox.CheckedChanged += new System.EventHandler(this.StopCheckBox_CheckedChanged);
            // 
            // ResetCheckBox
            // 
            this.ResetCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ResetCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResetCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetCheckBox.Location = new System.Drawing.Point(3, 123);
            this.ResetCheckBox.Name = "ResetCheckBox";
            this.ResetCheckBox.Size = new System.Drawing.Size(134, 24);
            this.ResetCheckBox.TabIndex = 21;
            this.ResetCheckBox.Text = "Reset Counter";
            this.ResetCheckBox.UseVisualStyleBackColor = false;
            this.ResetCheckBox.CheckedChanged += new System.EventHandler(this.ResetCheckBox_CheckedChanged);
            // 
            // SpeedCheckBox
            // 
            this.SpeedCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.SpeedCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpeedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedCheckBox.Location = new System.Drawing.Point(3, 153);
            this.SpeedCheckBox.Name = "SpeedCheckBox";
            this.SpeedCheckBox.Size = new System.Drawing.Size(134, 24);
            this.SpeedCheckBox.TabIndex = 22;
            this.SpeedCheckBox.Text = "Set Speed";
            this.SpeedCheckBox.UseVisualStyleBackColor = false;
            this.SpeedCheckBox.CheckedChanged += new System.EventHandler(this.SpeedCheckBox_CheckedChanged);
            // 
            // RightCheckBox
            // 
            this.RightCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.RightCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightCheckBox.Location = new System.Drawing.Point(3, 63);
            this.RightCheckBox.Name = "RightCheckBox";
            this.RightCheckBox.Size = new System.Drawing.Size(364, 24);
            this.RightCheckBox.TabIndex = 23;
            this.RightCheckBox.Text = "Right";
            this.RightCheckBox.UseVisualStyleBackColor = false;
            this.RightCheckBox.CheckedChanged += new System.EventHandler(this.RightCheckBox_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(528, 272);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.96935F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.03065F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(522, 189);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.MoveToCheckBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LefCheckBox, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.ReadCounterCheckBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.StopCheckBox, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.ResetCheckBox, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.SpeedCheckBox, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(140, 183);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.MoveToInputNrUpDown, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.RightCheckBox, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.SpeedInputNrUpDown, 0, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(149, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(370, 183);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.71279F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.28721F));
            this.tableLayoutPanel5.Controls.Add(this.SendButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 198);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(522, 71);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.PortLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.OutputLabel, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.PortComboBox, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(415, 65);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(528, 272);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "Connect_ESP";
            ((System.ComponentModel.ISupportInitialize)(this.MoveToInputNrUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedInputNrUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}

