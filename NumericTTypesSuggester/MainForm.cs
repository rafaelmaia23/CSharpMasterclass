namespace NumericTTypesSuggester
{
    partial class Form1
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
            MinValueLabel = new Label();
            MaxValueLabel = new Label();
            MinInput = new TextBox();
            MaxInput = new TextBox();
            IntegralCheckBox = new CheckBox();
            IntegralLabel = new Label();
            PreciseLabel = new Label();
            PreciseCheckBox = new CheckBox();
            SuggestedLabel = new Label();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // MinValueLabel
            // 
            MinValueLabel.AutoSize = true;
            MinValueLabel.Font = new Font("Segoe UI", 20F);
            MinValueLabel.Location = new Point(213, 122);
            MinValueLabel.Name = "MinValueLabel";
            MinValueLabel.Size = new Size(172, 46);
            MinValueLabel.TabIndex = 0;
            MinValueLabel.Text = "Min value:";
            MinValueLabel.Click += label1_Click;
            // 
            // MaxValueLabel
            // 
            MaxValueLabel.AutoSize = true;
            MaxValueLabel.Font = new Font("Segoe UI", 20F);
            MaxValueLabel.Location = new Point(207, 168);
            MaxValueLabel.Name = "MaxValueLabel";
            MaxValueLabel.Size = new Size(178, 46);
            MaxValueLabel.TabIndex = 1;
            MaxValueLabel.Text = "Max value:";
            // 
            // MinInput
            // 
            MinInput.Location = new Point(391, 139);
            MinInput.Name = "MinInput";
            MinInput.Size = new Size(256, 27);
            MinInput.TabIndex = 2;
            MinInput.KeyPress += MinInput_KeyPress;
            // 
            // MaxInput
            // 
            MaxInput.Location = new Point(391, 185);
            MaxInput.Name = "MaxInput";
            MaxInput.Size = new Size(256, 27);
            MaxInput.TabIndex = 3;
            MaxInput.TextChanged += MaxInput_TextChanged;
            MaxInput.KeyPress += MaxInput_KeyPress;
            // 
            // IntegralCheckBox
            // 
            IntegralCheckBox.AutoSize = true;
            IntegralCheckBox.Checked = true;
            IntegralCheckBox.CheckState = CheckState.Checked;
            IntegralCheckBox.Location = new Point(391, 237);
            IntegralCheckBox.Name = "IntegralCheckBox";
            IntegralCheckBox.Size = new Size(18, 17);
            IntegralCheckBox.TabIndex = 4;
            IntegralCheckBox.UseVisualStyleBackColor = true;
            IntegralCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // IntegralLabel
            // 
            IntegralLabel.AutoSize = true;
            IntegralLabel.Font = new Font("Segoe UI", 20F);
            IntegralLabel.Location = new Point(163, 214);
            IntegralLabel.Name = "IntegralLabel";
            IntegralLabel.Size = new Size(222, 46);
            IntegralLabel.TabIndex = 5;
            IntegralLabel.Text = "Integral only?";
            // 
            // PreciseLabel
            // 
            PreciseLabel.AutoSize = true;
            PreciseLabel.Font = new Font("Segoe UI", 20F);
            PreciseLabel.Location = new Point(112, 260);
            PreciseLabel.Name = "PreciseLabel";
            PreciseLabel.Size = new Size(273, 46);
            PreciseLabel.TabIndex = 6;
            PreciseLabel.Text = "Must be precise?";
            PreciseLabel.Visible = false;
            // 
            // PreciseCheckBox
            // 
            PreciseCheckBox.AutoSize = true;
            PreciseCheckBox.Location = new Point(391, 279);
            PreciseCheckBox.Name = "PreciseCheckBox";
            PreciseCheckBox.Size = new Size(18, 17);
            PreciseCheckBox.TabIndex = 7;
            PreciseCheckBox.UseVisualStyleBackColor = true;
            PreciseCheckBox.Visible = false;
            // 
            // SuggestedLabel
            // 
            SuggestedLabel.AutoSize = true;
            SuggestedLabel.Font = new Font("Segoe UI", 20F);
            SuggestedLabel.Location = new Point(124, 306);
            SuggestedLabel.Name = "SuggestedLabel";
            SuggestedLabel.Size = new Size(261, 46);
            SuggestedLabel.TabIndex = 8;
            SuggestedLabel.Text = "Suggested type:";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Segoe UI", 20F);
            ResultLabel.Location = new Point(391, 306);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(90, 46);
            ResultLabel.TabIndex = 9;
            ResultLabel.Text = "Type";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultLabel);
            Controls.Add(SuggestedLabel);
            Controls.Add(PreciseCheckBox);
            Controls.Add(PreciseLabel);
            Controls.Add(IntegralLabel);
            Controls.Add(IntegralCheckBox);
            Controls.Add(MaxInput);
            Controls.Add(MinInput);
            Controls.Add(MaxValueLabel);
            Controls.Add(MinValueLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MinValueLabel;
        private Label MaxValueLabel;
        private TextBox MinInput;
        private TextBox MaxInput;
        private CheckBox IntegralCheckBox;
        private Label IntegralLabel;
        private Label PreciseLabel;
        private CheckBox PreciseCheckBox;
        private Label SuggestedLabel;
        private Label ResultLabel;
    }
}
