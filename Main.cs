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
    }
}