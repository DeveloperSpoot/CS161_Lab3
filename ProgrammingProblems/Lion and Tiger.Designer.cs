namespace CS161_Lab3.ProgrammingProblems
{
    partial class Lion_and_Tiger
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
            label2 = new Label();
            lionsTextBox = new TextBox();
            tigersTextBox = new TextBox();
            calculateButton = new Button();
            displayLabel = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 36);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 0;
            label1.Text = "Number of Lions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 94);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 1;
            label2.Text = "Number of Tigers";
            // 
            // lionsTextBox
            // 
            lionsTextBox.Location = new Point(267, 38);
            lionsTextBox.Name = "lionsTextBox";
            lionsTextBox.Size = new Size(100, 23);
            lionsTextBox.TabIndex = 2;
            // 
            // tigersTextBox
            // 
            tigersTextBox.Location = new Point(267, 96);
            tigersTextBox.Name = "tigersTextBox";
            tigersTextBox.Size = new Size(100, 23);
            tigersTextBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(140, 217);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 4;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // displayLabel
            // 
            displayLabel.BackColor = SystemColors.ControlLight;
            displayLabel.BorderStyle = BorderStyle.FixedSingle;
            displayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayLabel.Location = new Point(25, 164);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(466, 23);
            displayLabel.TabIndex = 5;
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(267, 217);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Lion_and_Tiger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 268);
            Controls.Add(exitButton);
            Controls.Add(displayLabel);
            Controls.Add(calculateButton);
            Controls.Add(tigersTextBox);
            Controls.Add(lionsTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lion_and_Tiger";
            Text = "Lion_and_Tiger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox lionsTextBox;
        private TextBox tigersTextBox;
        private Button calculateButton;
        private Label displayLabel;
        private Button exitButton;
    }
}