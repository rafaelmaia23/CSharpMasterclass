using System.Numerics;

namespace NumericTypesSuggester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void IntegralCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PreciseCheckBox.Visible = !IntegralCheckBox.Checked;

            RecalculateSuggestedType();
        }

        private void PreciseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RecalculateSuggestedType();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            SetColorOfMaxValueTextField();
            RecalculateSuggestedType();
        }

        private void SetColorOfMaxValueTextField()
        {
            bool isValid = true;
            if (IsInputComplete())
            {
                var minValue = BigInteger.Parse(MinTextBox.Text);
                var maxValue = BigInteger.Parse(MaxTextBox.Text);

                if (maxValue < minValue)
                {
                    isValid = false;
                }
            }

            MaxTextBox.BackColor = isValid ? Color.White : Color.IndianRed;
        }

        private bool IsInputComplete()
        {
            return MinTextBox.Text.Length > 0 &&
                MinTextBox.Text != "-" &&
                MaxTextBox.Text.Length > 0 &&
                MaxTextBox.Text != "-";
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            if (!IsVaLidInput(e.KeyChar, textBox))
            {
                e.Handled = true;
            }
        }

        private static bool IsVaLidInput(char keyChar, TextBox textBox)
        {
            return char.IsControl(keyChar) ||
                char.IsDigit(keyChar) ||
                (keyChar == '-' && textBox.SelectionStart == 0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void RecalculateSuggestedType()
        {
            if(IsInputComplete())
            {
                var minValue = BigInteger.Parse(MinTextBox.Text);
                var maxValue = BigInteger.Parse(MaxTextBox.Text);

                if(maxValue >= minValue)
                {
                    InputLabel.Text = NumericTypeSuggester.GetName(minValue, maxValue, IntegralCheckBox.Checked, PreciseCheckBox.Checked);
                    return;
                }
            }
            InputLabel.Text = "Not enough data";
        }
    }
}
