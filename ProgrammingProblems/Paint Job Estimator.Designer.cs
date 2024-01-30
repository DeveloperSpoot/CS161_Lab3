namespace CS161_Lab3.ProgrammingProblems
{
    partial class Paint_Job_Estimator
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
            label1 = new Label();
            wallSpaceTextBox = new TextBox();
            groupBox1 = new GroupBox();
            gallonsLabel = new Label();
            groupBox2 = new GroupBox();
            laborLabel = new Label();
            groupBox3 = new GroupBox();
            paintLabel = new Label();
            groupBox4 = new GroupBox();
            laborChargesLabel = new Label();
            groupBox5 = new GroupBox();
            totalLabel = new Label();
            exitButton = new Button();
            paintPerGalTextBox = new TextBox();
            label2 = new Label();
            calculateButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "Sq Ft of Wall Space";
            // 
            // wallSpaceTextBox
            // 
            wallSpaceTextBox.Location = new Point(189, 19);
            wallSpaceTextBox.Name = "wallSpaceTextBox";
            wallSpaceTextBox.Size = new Size(100, 23);
            wallSpaceTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gallonsLabel);
            groupBox1.Location = new Point(54, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 51);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gallons of Paint Req.";
            // 
            // gallonsLabel
            // 
            gallonsLabel.BackColor = SystemColors.ControlLight;
            gallonsLabel.Location = new Point(6, 19);
            gallonsLabel.Name = "gallonsLabel";
            gallonsLabel.Size = new Size(188, 23);
            gallonsLabel.TabIndex = 0;
            gallonsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(laborLabel);
            groupBox2.Location = new Point(54, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 51);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hours of Labor Req.";
            // 
            // laborLabel
            // 
            laborLabel.BackColor = SystemColors.ControlLight;
            laborLabel.Location = new Point(6, 19);
            laborLabel.Name = "laborLabel";
            laborLabel.Size = new Size(188, 23);
            laborLabel.TabIndex = 0;
            laborLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(paintLabel);
            groupBox3.Location = new Point(54, 225);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 51);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cost of Paint";
            // 
            // paintLabel
            // 
            paintLabel.BackColor = SystemColors.ControlLight;
            paintLabel.Location = new Point(6, 19);
            paintLabel.Name = "paintLabel";
            paintLabel.Size = new Size(188, 23);
            paintLabel.TabIndex = 0;
            paintLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(laborChargesLabel);
            groupBox4.Location = new Point(54, 282);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 51);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Labor Charges";
            // 
            // laborChargesLabel
            // 
            laborChargesLabel.BackColor = SystemColors.ControlLight;
            laborChargesLabel.Location = new Point(6, 19);
            laborChargesLabel.Name = "laborChargesLabel";
            laborChargesLabel.Size = new Size(188, 23);
            laborChargesLabel.TabIndex = 0;
            laborChargesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(totalLabel);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(54, 339);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 51);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Total Cost";
            // 
            // totalLabel
            // 
            totalLabel.BackColor = SystemColors.ControlLight;
            totalLabel.Location = new Point(6, 19);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(188, 23);
            totalLabel.TabIndex = 0;
            totalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(159, 406);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // paintPerGalTextBox
            // 
            paintPerGalTextBox.Location = new Point(189, 64);
            paintPerGalTextBox.Name = "paintPerGalTextBox";
            paintPerGalTextBox.Size = new Size(100, 23);
            paintPerGalTextBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 63);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 8;
            label2.Text = "Cost of Paint per Gal";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(69, 407);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 10;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // Paint_Job_Estimator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 450);
            Controls.Add(calculateButton);
            Controls.Add(paintPerGalTextBox);
            Controls.Add(label2);
            Controls.Add(exitButton);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(wallSpaceTextBox);
            Controls.Add(label1);
            Name = "Paint_Job_Estimator";
            Text = "Paint_Job_Estimator";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox wallSpaceTextBox;
        private GroupBox groupBox1;
        private Label gallonsLabel;
        private GroupBox groupBox2;
        private Label laborLabel;
        private GroupBox groupBox3;
        private Label paintLabel;
        private GroupBox groupBox4;
        private Label laborChargesLabel;
        private GroupBox groupBox5;
        private Label totalLabel;
        private Button exitButton;
        private TextBox paintPerGalTextBox;
        private Label label2;
        private Button calculateButton;
    }
}