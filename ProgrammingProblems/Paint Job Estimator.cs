namespace CS161_Lab3.ProgrammingProblems
{
    public partial class Paint_Job_Estimator : Form
    {
        public Paint_Job_Estimator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal laborPerSqFt = 8.00m/115.00m;
            decimal laborCostPerSqFt = (20.00m * 8.00m)/115.00m;

            try
            {
                decimal wallSpace = decimal.Parse(wallSpaceTextBox.Text);
                decimal paintPerGal = decimal.Parse(paintPerGalTextBox.Text);

                gallonsLabel.Text = (wallSpace / 115.00m).ToString("f");
                laborLabel.Text = (wallSpace * laborPerSqFt).ToString("f");
                paintLabel.Text = (wallSpace * (paintPerGal/ 115.00m)).ToString("c");
                laborChargesLabel.Text = (laborCostPerSqFt * wallSpace).ToString("c");
                totalLabel.Text = ((laborCostPerSqFt * wallSpace) + (wallSpace * (paintPerGal/115.00m))).ToString("c");

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
