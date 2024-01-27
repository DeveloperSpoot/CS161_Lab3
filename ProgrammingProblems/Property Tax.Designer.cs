namespace CS161_Lab3.ProgrammingProblems
{
    partial class Property_Tax
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
            groupBox1 = new GroupBox();
            propertyValueTextBox = new TextBox();
            displayLabel = new Label();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(propertyValueTextBox);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(22, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 60);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Property Value";
            // 
            // propertyValueTextBox
            // 
            propertyValueTextBox.Location = new Point(6, 25);
            propertyValueTextBox.Name = "propertyValueTextBox";
            propertyValueTextBox.Size = new Size(188, 29);
            propertyValueTextBox.TabIndex = 0;
            propertyValueTextBox.TextChanged += propertyValueTextBox_TextChanged;
            // 
            // displayLabel
            // 
            displayLabel.BackColor = SystemColors.ControlLight;
            displayLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            displayLabel.Location = new Point(28, 93);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(188, 35);
            displayLabel.TabIndex = 2;
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(81, 143);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Property_Tax
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 182);
            Controls.Add(exitButton);
            Controls.Add(displayLabel);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Property_Tax";
            Text = "Property_Tax";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox propertyValueTextBox;
        private Label displayLabel;
        private Button exitButton;
    }
}