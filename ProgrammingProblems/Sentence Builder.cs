namespace CS161_Lab3.ProgrammingProblems
{
    public partial class Sentence_Builder : Form
    {
        public Sentence_Builder()
        {
            InitializeComponent();
        }

        private void aCapButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + " A";
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + " a";
        }

        private void anCapButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "An";
        }

        private void anButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "an";
        }

        private void theCapButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "The";
        }

        private void theButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "the";
        }

        private void manButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "man";
        }

        private void womanButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "woman";
        }

        private void dogButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "dog";
        }

        private void catButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "cat";
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "car";
        }

        private void bicycleButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "bicycle";
        }

        private void beautifulButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "beautiful";
        }

        private void bigButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "big";
        }

        private void smallButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "small";
        }

        private void strangeButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "strange";
        }

        private void lockedAtButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "locked";
        }

        private void rodeButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "rode";
        }

        private void spokeToButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "spoke";
        }

        private void laughedAtButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "laughed";
        }

        private void droveButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "drove";
        }

        private void spaceButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + " ";
        }

        private void periodButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + ".";
        }

        private void execlaimationButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + "!";
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
