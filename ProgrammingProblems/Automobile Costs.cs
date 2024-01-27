namespace CS161_Lab3.ProgrammingProblems
{
    public partial class Automobile_Costs : Form
    {
        public Automobile_Costs()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double insurance = double.Parse(insuranceTextBox.Text);
                double loan = double.Parse(loansTextBox.Text);
                double gas = double.Parse(gasTextBox.Text);
                double oil = double.Parse(oilTextBox.Text);
                double tires = double.Parse(tiresTextBox.Text);
                double maintenance = double.Parse(maintenanceTextBox.Text);
                double monthlyTotal = insurance + loan + gas + oil + tires;
                double yearlyTotal = monthlyTotal * 12;

                displayLabel.Text = $"Monthly Cost: {monthlyTotal.ToString("c")} | Yearly Cost: {yearlyTotal.ToString("c")}";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "";
            insuranceTextBox.Text = "0.00";
            gasTextBox.Text = "0.00";
            oilTextBox.Text = "0.00";
            loansTextBox.Text = "0.00";
            tiresTextBox.Text = "0.00";
            maintenanceTextBox.Text = "0.00";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
