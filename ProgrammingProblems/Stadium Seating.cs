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
    public partial class Stadium_Seating : Form
    {
        public Stadium_Seating()
        {
            InitializeComponent();
        }

        private int classATicket = 15;
        private int classBTicket = 12;
        private int classCTicket = 9;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int classA = int.Parse(soldATextBox.Text) * classATicket;
                int classB = int.Parse(soldBTextBox.Text) * classBTicket;
                int classC = int.Parse(soldCtextBox.Text) * classCTicket;

                revALabel.Text = classA.ToString("c");
                revBLabel.Text = classB.ToString("C");
                revCLabel.Text = classC.ToString("c");
                totalLabel.Text = (classA + classB + classC).ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            revALabel.Text = "";
            revBLabel.Text = "";
            revCLabel.Text = "";
            totalLabel.Text = "";
            soldATextBox.Text = "";
            soldBTextBox.Text = "";
            soldCtextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stadium_Seating_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ticketmaster could never.");
        }
    }
}
