namespace FirstApp
{
    partial class Form1
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
            label1 = new Label();
            guessTextBox = new TextBox();
            guessButton = new Button();
            responseLabel = new Label();
            label3 = new Label();
            triesLabel = new Label();
            easyButton = new Button();
            mediumButton = new Button();
            hardButton = new Button();
            difficultyLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 54);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 0;
            label1.Text = "Your Guess:";
            // 
            // guessTextBox
            // 
            guessTextBox.Location = new Point(297, 54);
            guessTextBox.Name = "guessTextBox";
            guessTextBox.Size = new Size(319, 31);
            guessTextBox.TabIndex = 1;
            // 
            // guessButton
            // 
            guessButton.Location = new Point(348, 172);
            guessButton.Name = "guessButton";
            guessButton.Size = new Size(112, 34);
            guessButton.TabIndex = 2;
            guessButton.Text = "Guess";
            guessButton.UseVisualStyleBackColor = true;
            guessButton.Click += GuessClick;
            // 
            // responseLabel
            // 
            responseLabel.AutoSize = true;
            responseLabel.Location = new Point(338, 226);
            responseLabel.Name = "responseLabel";
            responseLabel.Size = new Size(0, 25);
            responseLabel.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 111);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 5;
            label3.Text = "Remaining Tries:";
            // 
            // triesLabel
            // 
            triesLabel.AutoSize = true;
            triesLabel.Location = new Point(297, 111);
            triesLabel.Name = "triesLabel";
            triesLabel.Size = new Size(22, 25);
            triesLabel.TabIndex = 6;
            triesLabel.Text = "0";
            // 
            // easyButton
            // 
            easyButton.Location = new Point(170, 310);
            easyButton.Name = "easyButton";
            easyButton.Size = new Size(112, 34);
            easyButton.TabIndex = 7;
            easyButton.Text = "Easy";
            easyButton.UseVisualStyleBackColor = true;
            easyButton.Click += DiffE;
            // 
            // mediumButton
            // 
            mediumButton.Location = new Point(348, 310);
            mediumButton.Name = "mediumButton";
            mediumButton.Size = new Size(112, 34);
            mediumButton.TabIndex = 8;
            mediumButton.Text = "Medium";
            mediumButton.UseVisualStyleBackColor = true;
            mediumButton.Click += DiffM;
            // 
            // hardButton
            // 
            hardButton.Location = new Point(524, 310);
            hardButton.Name = "hardButton";
            hardButton.Size = new Size(112, 34);
            hardButton.TabIndex = 9;
            hardButton.Text = "Hard";
            hardButton.UseVisualStyleBackColor = true;
            hardButton.Click += DiffH;
            // 
            // difficultyLabel
            // 
            difficultyLabel.AutoSize = true;
            difficultyLabel.Location = new Point(338, 261);
            difficultyLabel.Name = "difficultyLabel";
            difficultyLabel.Size = new Size(133, 25);
            difficultyLabel.TabIndex = 10;
            difficultyLabel.Text = "Select Difficulty";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(difficultyLabel);
            Controls.Add(hardButton);
            Controls.Add(mediumButton);
            Controls.Add(easyButton);
            Controls.Add(triesLabel);
            Controls.Add(label3);
            Controls.Add(responseLabel);
            Controls.Add(guessButton);
            Controls.Add(guessTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox guessTextBox;
        private Button guessButton;
        private Label responseLabel;
        private Label label3;
        private Label triesLabel;
        private Button easyButton;
        private Button mediumButton;
        private Button hardButton;
        private Label difficultyLabel;
    }
}