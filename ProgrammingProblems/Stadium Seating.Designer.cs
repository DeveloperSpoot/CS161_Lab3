namespace CS161_Lab3.ProgrammingProblems
{
    partial class Stadium_Seating
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            soldCtextBox = new TextBox();
            label4 = new Label();
            soldBTextBox = new TextBox();
            label3 = new Label();
            soldATextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            totalLabel = new Label();
            revCLabel = new Label();
            revALabel = new Label();
            revBLabel = new Label();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(soldCtextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(soldBTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(soldATextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tickets Sold";
            // 
            // soldCtextBox
            // 
            soldCtextBox.Location = new Point(77, 119);
            soldCtextBox.Name = "soldCtextBox";
            soldCtextBox.Size = new Size(100, 23);
            soldCtextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 123);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 5;
            label4.Text = "Class C:";
            // 
            // soldBTextBox
            // 
            soldBTextBox.Location = new Point(77, 90);
            soldBTextBox.Name = "soldBTextBox";
            soldBTextBox.Size = new Size(100, 23);
            soldBTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 94);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "Class B:";
            // 
            // soldATextBox
            // 
            soldATextBox.Location = new Point(77, 61);
            soldATextBox.Name = "soldATextBox";
            soldATextBox.Size = new Size(100, 23);
            soldATextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 65);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Class A:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(235, 39);
            label1.TabIndex = 0;
            label1.Text = "Enter the number of tickets sold for each class of seats.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(totalLabel);
            groupBox2.Controls.Add(revCLabel);
            groupBox2.Controls.Add(revALabel);
            groupBox2.Controls.Add(revBLabel);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(278, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(251, 160);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Revenue Generated";
            // 
            // totalLabel
            // 
            totalLabel.BackColor = SystemColors.ControlLight;
            totalLabel.Location = new Point(72, 115);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(100, 23);
            totalLabel.TabIndex = 17;
            // 
            // revCLabel
            // 
            revCLabel.BackColor = SystemColors.ControlLight;
            revCLabel.Location = new Point(72, 86);
            revCLabel.Name = "revCLabel";
            revCLabel.Size = new Size(100, 23);
            revCLabel.TabIndex = 16;
            // 
            // revALabel
            // 
            revALabel.BackColor = SystemColors.ControlLight;
            revALabel.Location = new Point(72, 28);
            revALabel.Name = "revALabel";
            revALabel.Size = new Size(100, 23);
            revALabel.TabIndex = 14;
            // 
            // revBLabel
            // 
            revBLabel.BackColor = SystemColors.ControlLight;
            revBLabel.Location = new Point(72, 57);
            revBLabel.Name = "revBLabel";
            revBLabel.Size = new Size(100, 23);
            revBLabel.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 119);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 13;
            label8.Text = "Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 90);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 11;
            label5.Text = "Class C:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 32);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 7;
            label7.Text = "Class A:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 61);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 9;
            label6.Text = "Class B:";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(548, 21);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(548, 85);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(548, 149);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Stadium_Seating
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 185);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Stadium_Seating";
            Text = "Stadium_Seating";
            Load += Stadium_Seating_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox soldCtextBox;
        private Label label4;
        private TextBox soldBTextBox;
        private Label label3;
        private TextBox soldATextBox;
        private Label label2;
        private Label label8;
        private Label label5;
        private Label label7;
        private Label label6;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private Label totalLabel;
        private Label revCLabel;
        private Label revALabel;
        private Label revBLabel;
    }
}