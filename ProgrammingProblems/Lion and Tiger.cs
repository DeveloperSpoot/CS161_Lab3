namespace CS161_Lab3.ProgrammingProblems
{
    public partial class Lion_and_Tiger : Form
    {
        public Lion_and_Tiger()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal lions = decimal.Parse(lionsTextBox.Text);
                decimal tigers = decimal.Parse(tigersTextBox.Text);

                displayLabel.Text = $"{(lions / (lions + tigers)).ToString("p")} are Lions, {(tigers / (lions + tigers)).ToString("p")} are Tigers.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
