namespace NumericTTypesSuggester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PreciseLabel.Visible = !PreciseLabel.Visible;
            PreciseCheckBox.Visible = !PreciseCheckBox.Visible;
        }

        private void MinInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsValid(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool IsValid(char keyChar)
        {
            return char.IsControl(keyChar) ||
                (char.IsDigit(keyChar));
        }

        private void MaxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsValid(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
