namespace CS161_Lab3.ProgrammingProblems
{
    partial class Insurance_Cost
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
            clearButton = new Button();
            exitButton = new Button();
            enterButton = new Label();
            costTextBox = new TextBox();
            displayLabel = new Label();
            SuspendLayout();
            // 
            // clearButton
            // 
            clearButton.Location = new Point(79, 134);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 0;
            clearButton.Text = "Clear ";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(215, 134);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // enterButton
            // 
            enterButton.AutoSize = true;
            enterButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterButton.Location = new Point(41, 37);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(172, 21);
            enterButton.TabIndex = 2;
            enterButton.Text = "Enter Cost To Rebuild";
            // 
            // costTextBox
            // 
            costTextBox.Location = new Point(226, 37);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(100, 23);
            costTextBox.TabIndex = 3;
            costTextBox.TextChanged += costTextBox_TextChanged;
            // 
            // displayLabel
            // 
            displayLabel.BackColor = SystemColors.ControlLight;
            displayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayLabel.Location = new Point(41, 95);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(285, 23);
            displayLabel.TabIndex = 4;
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Insurance_Cost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 195);
            Controls.Add(displayLabel);
            Controls.Add(costTextBox);
            Controls.Add(enterButton);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Name = "Insurance_Cost";
            Text = "Insurance_Cost";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clearButton;
        private Button exitButton;
        private Label enterButton;
        private TextBox costTextBox;
        private Label displayLabel;
    }
}