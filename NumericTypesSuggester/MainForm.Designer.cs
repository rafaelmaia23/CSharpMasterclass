namespace NumericTypesSuggester
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IntegralCheckBox = new CheckBox();
            PreciseCheckBox = new CheckBox();
            MinValueLabel = new Label();
            MaxValueLabel = new Label();
            SuggestedLabel = new Label();
            InputLabel = new Label();
            MinTextBox = new TextBox();
            MaxTextBox = new TextBox();
            SuspendLayout();
            // 
            // IntegralCheckBox
            // 
            IntegralCheckBox.AutoSize = true;
            IntegralCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            IntegralCheckBox.Checked = true;
            IntegralCheckBox.CheckState = CheckState.Checked;
            IntegralCheckBox.Font = new Font("Segoe UI", 20F);
            IntegralCheckBox.Location = new Point(95, 172);
            IntegralCheckBox.Name = "IntegralCheckBox";
            IntegralCheckBox.Size = new Size(250, 50);
            IntegralCheckBox.TabIndex = 0;
            IntegralCheckBox.Text = "Integral Only?";
            IntegralCheckBox.UseVisualStyleBackColor = true;
            IntegralCheckBox.CheckedChanged += IntegralCheckBox_CheckedChanged;
            // 
            // PreciseCheckBox
            // 
            PreciseCheckBox.AutoSize = true;
            PreciseCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            PreciseCheckBox.Font = new Font("Segoe UI", 20F);
            PreciseCheckBox.Location = new Point(95, 228);
            PreciseCheckBox.Name = "PreciseCheckBox";
            PreciseCheckBox.Size = new Size(295, 50);
            PreciseCheckBox.TabIndex = 1;
            PreciseCheckBox.Text = "Must be precise?";
            PreciseCheckBox.UseVisualStyleBackColor = true;
            PreciseCheckBox.Visible = false;
            PreciseCheckBox.CheckedChanged += PreciseCheckBox_CheckedChanged;
            // 
            // MinValueLabel
            // 
            MinValueLabel.AutoSize = true;
            MinValueLabel.Font = new Font("Segoe UI", 20F);
            MinValueLabel.Location = new Point(95, 74);
            MinValueLabel.Name = "MinValueLabel";
            MinValueLabel.Size = new Size(168, 46);
            MinValueLabel.TabIndex = 2;
            MinValueLabel.Text = "Min Value";
            // 
            // MaxValueLabel
            // 
            MaxValueLabel.AutoSize = true;
            MaxValueLabel.Font = new Font("Segoe UI", 20F);
            MaxValueLabel.Location = new Point(95, 123);
            MaxValueLabel.Name = "MaxValueLabel";
            MaxValueLabel.Size = new Size(174, 46);
            MaxValueLabel.TabIndex = 3;
            MaxValueLabel.Text = "Max Value";
            // 
            // SuggestedLabel
            // 
            SuggestedLabel.AutoSize = true;
            SuggestedLabel.Font = new Font("Segoe UI", 20F);
            SuggestedLabel.Location = new Point(95, 341);
            SuggestedLabel.Name = "SuggestedLabel";
            SuggestedLabel.Size = new Size(261, 46);
            SuggestedLabel.TabIndex = 4;
            SuggestedLabel.Text = "Suggested type:";
            // 
            // InputLabel
            // 
            InputLabel.AutoSize = true;
            InputLabel.Font = new Font("Segoe UI", 20F);
            InputLabel.Location = new Point(362, 341);
            InputLabel.Name = "InputLabel";
            InputLabel.Size = new Size(276, 46);
            InputLabel.TabIndex = 5;
            InputLabel.Text = "Not enough data";
            // 
            // MinTextBox
            // 
            MinTextBox.Location = new Point(265, 91);
            MinTextBox.Name = "MinTextBox";
            MinTextBox.Size = new Size(246, 27);
            MinTextBox.TabIndex = 6;
            MinTextBox.TextChanged += TextBox_TextChanged;
            MinTextBox.KeyPress += TextBox_KeyPress;
            // 
            // MaxTextBox
            // 
            MaxTextBox.Location = new Point(265, 140);
            MaxTextBox.Name = "MaxTextBox";
            MaxTextBox.Size = new Size(246, 27);
            MaxTextBox.TabIndex = 7;
            MaxTextBox.TextChanged += TextBox_TextChanged;
            MaxTextBox.KeyPress += TextBox_KeyPress;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(993, 450);
            Controls.Add(MaxTextBox);
            Controls.Add(MinTextBox);
            Controls.Add(InputLabel);
            Controls.Add(SuggestedLabel);
            Controls.Add(MaxValueLabel);
            Controls.Add(MinValueLabel);
            Controls.Add(PreciseCheckBox);
            Controls.Add(IntegralCheckBox);
            Name = "MainForm";
            Text = "Type";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox IntegralCheckBox;
        private CheckBox PreciseCheckBox;
        private Label MinValueLabel;
        private Label MaxValueLabel;
        private Label SuggestedLabel;
        private Label InputLabel;
        private TextBox MinTextBox;
        private TextBox MaxTextBox;
    }
}
