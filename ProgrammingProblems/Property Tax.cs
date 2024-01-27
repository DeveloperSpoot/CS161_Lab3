using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS161_Lab3.ProgrammingProblems
{
    public partial class Property_Tax : Form
    {
        public Property_Tax()
        {
            InitializeComponent();
        }

        private void propertyValueTextBox_TextChanged(object sender, EventArgs e)
        {
            if(propertyValueTextBox.Text == "") { return; }

            try
            {

                decimal tax = decimal.Parse(propertyValueTextBox.Text) / 100 * 0.64m;

                displayLabel.Text = tax.ToString("c");
            }catch (Exception ex)
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
