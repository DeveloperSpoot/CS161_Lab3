namespace CS161_Lab3.ProgrammingProblems
{
    partial class Automobile_Costs
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            loansTextBox = new TextBox();
            insuranceTextBox = new TextBox();
            gasTextBox = new TextBox();
            oilTextBox = new TextBox();
            tiresTextBox = new TextBox();
            maintenanceTextBox = new TextBox();
            clearButton = new Button();
            exitButton = new Button();
            displayLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 14);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 0;
            label1.Text = "Monthly cost of loans";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 66);
            label2.Name = "label2";
            label2.Size = new Size(208, 21);
            label2.TabIndex = 1;
            label2.Text = "Monthly cost of insurance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 121);
            label3.Name = "label3";
            label3.Size = new Size(160, 21);
            label3.TabIndex = 2;
            label3.Text = "Monthly cost of gas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(98, 178);
            label4.Name = "label4";
            label4.Size = new Size(154, 21);
            label4.TabIndex = 3;
            label4.Text = "Monthly cost of oil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(85, 242);
            label5.Name = "label5";
            label5.Size = new Size(167, 21);
            label5.TabIndex = 4;
            label5.Text = "Monthly cost of tires";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 300);
            label6.Name = "label6";
            label6.Size = new Size(234, 21);
            label6.TabIndex = 5;
            label6.Text = "Monthly cost of maintenance";
            // 
            // loansTextBox
            // 
            loansTextBox.Location = new Point(278, 16);
            loansTextBox.Name = "loansTextBox";
            loansTextBox.Size = new Size(100, 23);
            loansTextBox.TabIndex = 6;
            // 
            // insuranceTextBox
            // 
            insuranceTextBox.Location = new Point(278, 68);
            insuranceTextBox.Name = "insuranceTextBox";
            insuranceTextBox.Size = new Size(100, 23);
            insuranceTextBox.TabIndex = 7;
            // 
            // gasTextBox
            // 
            gasTextBox.Location = new Point(278, 123);
            gasTextBox.Name = "gasTextBox";
            gasTextBox.Size = new Size(100, 23);
            gasTextBox.TabIndex = 8;
            // 
            // oilTextBox
            // 
            oilTextBox.Location = new Point(278, 176);
            oilTextBox.Name = "oilTextBox";
            oilTextBox.Size = new Size(100, 23);
            oilTextBox.TabIndex = 9;
            // 
            // tiresTextBox
            // 
            tiresTextBox.Location = new Point(278, 242);
            tiresTextBox.Name = "tiresTextBox";
            tiresTextBox.Size = new Size(100, 23);
            tiresTextBox.TabIndex = 10;
            // 
            // maintenanceTextBox
            // 
            maintenanceTextBox.Location = new Point(278, 298);
            maintenanceTextBox.Name = "maintenanceTextBox";
            maintenanceTextBox.Size = new Size(100, 23);
            maintenanceTextBox.TabIndex = 11;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(114, 415);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 12;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(214, 415);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 13;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            // 
            // displayLabel
            // 
            displayLabel.BackColor = SystemColors.ControlLight;
            displayLabel.BorderStyle = BorderStyle.FixedSingle;
            displayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayLabel.Location = new Point(44, 350);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(301, 41);
            displayLabel.TabIndex = 14;
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Automobile_Costs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 450);
            Controls.Add(displayLabel);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(maintenanceTextBox);
            Controls.Add(tiresTextBox);
            Controls.Add(oilTextBox);
            Controls.Add(gasTextBox);
            Controls.Add(insuranceTextBox);
            Controls.Add(loansTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Automobile_Costs";
            Text = "Automobile_Costs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox loansTextBox;
        private TextBox insuranceTextBox;
        private TextBox gasTextBox;
        private TextBox oilTextBox;
        private TextBox tiresTextBox;
        private TextBox maintenanceTextBox;
        private Button clearButton;
        private Button exitButton;
        private Label displayLabel;
    }
}