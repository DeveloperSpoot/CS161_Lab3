namespace CS161_Lab3
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sentanceBuilderButton = new Button();
            insuranceCostButton = new Button();
            LionTigerButton = new Button();
            fruitStandButton = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // sentanceBuilderButton
            // 
            sentanceBuilderButton.Location = new Point(57, 19);
            sentanceBuilderButton.Name = "sentanceBuilderButton";
            sentanceBuilderButton.Size = new Size(127, 23);
            sentanceBuilderButton.TabIndex = 0;
            sentanceBuilderButton.Text = "Sentence Builder";
            sentanceBuilderButton.UseVisualStyleBackColor = true;
            sentanceBuilderButton.Click += sentanceBuilderButton_Click;
            // 
            // insuranceCostButton
            // 
            insuranceCostButton.Location = new Point(57, 80);
            insuranceCostButton.Name = "insuranceCostButton";
            insuranceCostButton.Size = new Size(127, 23);
            insuranceCostButton.TabIndex = 1;
            insuranceCostButton.Text = "Insurance Cost?";
            insuranceCostButton.UseVisualStyleBackColor = true;
            // 
            // LionTigerButton
            // 
            LionTigerButton.Location = new Point(57, 141);
            LionTigerButton.Name = "LionTigerButton";
            LionTigerButton.Size = new Size(127, 23);
            LionTigerButton.TabIndex = 2;
            LionTigerButton.Text = "Lion Tiger %";
            LionTigerButton.UseVisualStyleBackColor = true;
            // 
            // fruitStandButton
            // 
            fruitStandButton.Location = new Point(57, 202);
            fruitStandButton.Name = "fruitStandButton";
            fruitStandButton.Size = new Size(127, 23);
            fruitStandButton.TabIndex = 3;
            fruitStandButton.Text = "Fruit Stand";
            fruitStandButton.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(231, 19);
            button5.Name = "button5";
            button5.Size = new Size(127, 23);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(231, 82);
            button6.Name = "button6";
            button6.Size = new Size(127, 23);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(231, 141);
            button7.Name = "button7";
            button7.Size = new Size(127, 23);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(231, 202);
            button8.Name = "button8";
            button8.Size = new Size(127, 23);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 249);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(fruitStandButton);
            Controls.Add(LionTigerButton);
            Controls.Add(insuranceCostButton);
            Controls.Add(sentanceBuilderButton);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button sentanceBuilderButton;
        private Button insuranceCostButton;
        private Button LionTigerButton;
        private Button fruitStandButton;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
