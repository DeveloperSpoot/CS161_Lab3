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
            autoMobileButton = new Button();
            paintJobButton = new Button();
            propertyTaxButton = new Button();
            standiumSeatingButton = new Button();
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
            insuranceCostButton.Click += insuranceCostButton_Click;
            // 
            // LionTigerButton
            // 
            LionTigerButton.Location = new Point(57, 141);
            LionTigerButton.Name = "LionTigerButton";
            LionTigerButton.Size = new Size(127, 23);
            LionTigerButton.TabIndex = 2;
            LionTigerButton.Text = "Lion Tiger %";
            LionTigerButton.UseVisualStyleBackColor = true;
            LionTigerButton.Click += LionTigerButton_Click;
            // 
            // fruitStandButton
            // 
            fruitStandButton.Location = new Point(57, 202);
            fruitStandButton.Name = "fruitStandButton";
            fruitStandButton.Size = new Size(127, 23);
            fruitStandButton.TabIndex = 3;
            fruitStandButton.Text = "Fruit Stand";
            fruitStandButton.UseVisualStyleBackColor = true;
            fruitStandButton.Click += fruitStandButton_Click;
            // 
            // autoMobileButton
            // 
            autoMobileButton.Location = new Point(231, 19);
            autoMobileButton.Name = "autoMobileButton";
            autoMobileButton.Size = new Size(127, 23);
            autoMobileButton.TabIndex = 4;
            autoMobileButton.Text = "Automobile Costs";
            autoMobileButton.UseVisualStyleBackColor = true;
            autoMobileButton.Click += autoMobileButton_Click;
            // 
            // paintJobButton
            // 
            paintJobButton.Location = new Point(231, 82);
            paintJobButton.Name = "paintJobButton";
            paintJobButton.Size = new Size(127, 23);
            paintJobButton.TabIndex = 5;
            paintJobButton.Text = "Paint Job Estimator";
            paintJobButton.UseVisualStyleBackColor = true;
            paintJobButton.Click += paintJobButton_Click;
            // 
            // propertyTaxButton
            // 
            propertyTaxButton.Location = new Point(231, 141);
            propertyTaxButton.Name = "propertyTaxButton";
            propertyTaxButton.Size = new Size(127, 23);
            propertyTaxButton.TabIndex = 6;
            propertyTaxButton.Text = "Property Tax";
            propertyTaxButton.UseVisualStyleBackColor = true;
            propertyTaxButton.Click += propertyTaxButton_Click;
            // 
            // standiumSeatingButton
            // 
            standiumSeatingButton.Location = new Point(231, 202);
            standiumSeatingButton.Name = "standiumSeatingButton";
            standiumSeatingButton.Size = new Size(127, 23);
            standiumSeatingButton.TabIndex = 7;
            standiumSeatingButton.Text = "Stadium Seating";
            standiumSeatingButton.UseVisualStyleBackColor = true;
            standiumSeatingButton.Click += standiumSeatingButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 249);
            Controls.Add(standiumSeatingButton);
            Controls.Add(propertyTaxButton);
            Controls.Add(paintJobButton);
            Controls.Add(autoMobileButton);
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
        private Button autoMobileButton;
        private Button paintJobButton;
        private Button propertyTaxButton;
        private Button standiumSeatingButton;
    }
}
