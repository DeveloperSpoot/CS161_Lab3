namespace CS161_Lab3.ProgrammingProblems
{
    public partial class Fruit_Stand : Form
    {
        public Fruit_Stand()
        {
            InitializeComponent();
        }
        decimal totalPrice;

        private void resetButton_Click(object sender, EventArgs e)
        {
            totalPrice = 0m;
            totalDisplayLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bannaPictueBox_Click(object sender, EventArgs e)
        {
            totalPrice = totalPrice + .65m;
            totalDisplayLabel.Text = totalPrice.ToString("c");
        }

        private void applePictueBox_Click(object sender, EventArgs e)
        {
            totalPrice = totalPrice + 1.35m;
            totalDisplayLabel.Text = totalPrice.ToString("c");
        }

        private void orangePictueBox_Click(object sender, EventArgs e)
        {
            totalPrice = totalPrice + 1.60m;
            totalDisplayLabel.Text = totalPrice.ToString("c");
        }

        private void pearPictueBox_Click(object sender, EventArgs e)
        {
            totalPrice = totalPrice + 1.20m;
            totalDisplayLabel.Text = totalPrice.ToString("c");
        }
    }
}
