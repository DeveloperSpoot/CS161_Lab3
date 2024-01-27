using CS161_Lab3.ProgrammingProblems;

namespace CS161_Lab3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void sentanceBuilderButton_Click(object sender, EventArgs e)
        {
            Sentence_Builder form = new Sentence_Builder();
            form.Show();
        }

        private void insuranceCostButton_Click(object sender, EventArgs e)
        {
            Insurance_Cost form = new Insurance_Cost();
            form.Show();
        }

        private void LionTigerButton_Click(object sender, EventArgs e)
        {
            Lion_and_Tiger form = new Lion_and_Tiger();
            form.Show();
        }

        private void fruitStandButton_Click(object sender, EventArgs e)
        {
            Fruit_Stand form = new Fruit_Stand();
            form.Show();
        }

        private void autoMobileButton_Click(object sender, EventArgs e)
        {
            Automobile_Costs form = new Automobile_Costs();
            form.Show();
        }

        private void paintJobButton_Click(object sender, EventArgs e)
        {
            Paint_Job_Estimator form = new Paint_Job_Estimator();
            form.Show();
        }

        private void propertyTaxButton_Click(object sender, EventArgs e)
        {

        }

        private void standiumSeatingButton_Click(object sender, EventArgs e)
        {

        }
    }
}
