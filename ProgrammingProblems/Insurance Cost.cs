namespace CS161_Lab3.ProgrammingProblems
{
    public partial class Insurance_Cost : Form
    {
        public Insurance_Cost()
        {
            InitializeComponent();
        }

        private void costTextBox_TextChanged(object sender, EventArgs e)
        {
            if (costTextBox.Text == "") { return; }

            try
            {

                decimal percentage = decimal.Parse(costTextBox.Text) * .8m;

                displayLabel.Text = percentage.ToString("c");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
