namespace CS161_Lab3.ProgrammingProblems
{
    partial class Fruit_Stand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fruit_Stand));
            bannaPictueBox = new PictureBox();
            applePictueBox = new PictureBox();
            pearPictueBox = new PictureBox();
            orangePictueBox = new PictureBox();
            label1 = new Label();
            totalDisplayLabel = new Label();
            resetButton = new Button();
            exitButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)bannaPictueBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)applePictueBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pearPictueBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orangePictueBox).BeginInit();
            SuspendLayout();
            // 
            // bannaPictueBox
            // 
            bannaPictueBox.Image = (Image)resources.GetObject("bannaPictueBox.Image");
            bannaPictueBox.Location = new Point(23, 23);
            bannaPictueBox.Name = "bannaPictueBox";
            bannaPictueBox.Size = new Size(138, 131);
            bannaPictueBox.SizeMode = PictureBoxSizeMode.StretchImage;
            bannaPictueBox.TabIndex = 0;
            bannaPictueBox.TabStop = false;
            bannaPictueBox.Click += bannaPictueBox_Click;
            // 
            // applePictueBox
            // 
            applePictueBox.Image = (Image)resources.GetObject("applePictueBox.Image");
            applePictueBox.Location = new Point(187, 23);
            applePictueBox.Name = "applePictueBox";
            applePictueBox.Size = new Size(138, 131);
            applePictueBox.SizeMode = PictureBoxSizeMode.StretchImage;
            applePictueBox.TabIndex = 1;
            applePictueBox.TabStop = false;
            applePictueBox.Click += applePictueBox_Click;
            // 
            // pearPictueBox
            // 
            pearPictueBox.Image = (Image)resources.GetObject("pearPictueBox.Image");
            pearPictueBox.Location = new Point(187, 195);
            pearPictueBox.Name = "pearPictueBox";
            pearPictueBox.Size = new Size(138, 131);
            pearPictueBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pearPictueBox.TabIndex = 3;
            pearPictueBox.TabStop = false;
            pearPictueBox.Click += pearPictueBox_Click;
            // 
            // orangePictueBox
            // 
            orangePictueBox.Image = (Image)resources.GetObject("orangePictueBox.Image");
            orangePictueBox.Location = new Point(23, 195);
            orangePictueBox.Name = "orangePictueBox";
            orangePictueBox.Size = new Size(138, 131);
            orangePictueBox.SizeMode = PictureBoxSizeMode.StretchImage;
            orangePictueBox.TabIndex = 2;
            orangePictueBox.TabStop = false;
            orangePictueBox.Click += orangePictueBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(400, 23);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 4;
            label1.Text = "Total";
            // 
            // totalDisplayLabel
            // 
            totalDisplayLabel.BackColor = SystemColors.ControlLight;
            totalDisplayLabel.BorderStyle = BorderStyle.FixedSingle;
            totalDisplayLabel.Location = new Point(364, 58);
            totalDisplayLabel.Name = "totalDisplayLabel";
            totalDisplayLabel.Size = new Size(120, 23);
            totalDisplayLabel.TabIndex = 5;
            totalDisplayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(383, 241);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 6;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(383, 281);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 148);
            label2.Name = "label2";
            label2.Size = new Size(138, 23);
            label2.TabIndex = 8;
            label2.Text = "65¢ per lb";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = Color.White;
            label3.Location = new Point(187, 148);
            label3.Name = "label3";
            label3.Size = new Size(138, 23);
            label3.TabIndex = 9;
            label3.Text = "$1.35 per lb";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 318);
            label4.Name = "label4";
            label4.Size = new Size(138, 23);
            label4.TabIndex = 10;
            label4.Text = "$1.60 per lb";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = Color.White;
            label5.Location = new Point(187, 318);
            label5.Name = "label5";
            label5.Size = new Size(138, 23);
            label5.TabIndex = 11;
            label5.Text = "$1.20 per lb";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fruit_Stand
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 379);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exitButton);
            Controls.Add(resetButton);
            Controls.Add(totalDisplayLabel);
            Controls.Add(label1);
            Controls.Add(pearPictueBox);
            Controls.Add(orangePictueBox);
            Controls.Add(applePictueBox);
            Controls.Add(bannaPictueBox);
            Name = "Fruit_Stand";
            Text = "Fruit_Stand";
            ((System.ComponentModel.ISupportInitialize)bannaPictueBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)applePictueBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pearPictueBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)orangePictueBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bannaPictueBox;
        private PictureBox applePictueBox;
        private PictureBox pearPictueBox;
        private PictureBox orangePictueBox;
        private Label label1;
        private Label totalDisplayLabel;
        private Button resetButton;
        private Button exitButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}