namespace CurrencyApp
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
            BGNtoEURRadio = new RadioButton();
            EURtoBGNRadio = new RadioButton();
            amountLabel = new Label();
            convertedLabel = new Label();
            amountTextBox = new TextBox();
            convertedTextBox = new TextBox();
            convertButton = new Button();
            invalidLabel = new Label();
            SuspendLayout();
            // 
            // BGNtoEURRadio
            // 
            BGNtoEURRadio.AutoSize = true;
            BGNtoEURRadio.Location = new Point(110, 49);
            BGNtoEURRadio.Name = "BGNtoEURRadio";
            BGNtoEURRadio.Size = new Size(131, 29);
            BGNtoEURRadio.TabIndex = 0;
            BGNtoEURRadio.TabStop = true;
            BGNtoEURRadio.Text = "BGN to EUR";
            BGNtoEURRadio.UseVisualStyleBackColor = true;
            BGNtoEURRadio.Click += BGNtoEURRadio_Click;
            // 
            // EURtoBGNRadio
            // 
            EURtoBGNRadio.AutoSize = true;
            EURtoBGNRadio.Location = new Point(108, 92);
            EURtoBGNRadio.Name = "EURtoBGNRadio";
            EURtoBGNRadio.Size = new Size(131, 29);
            EURtoBGNRadio.TabIndex = 1;
            EURtoBGNRadio.TabStop = true;
            EURtoBGNRadio.Text = "EUR to BGN";
            EURtoBGNRadio.UseVisualStyleBackColor = true;
            EURtoBGNRadio.Click += EURtoBGNRadio_Click;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(95, 146);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(81, 25);
            amountLabel.TabIndex = 2;
            amountLabel.Text = "Amount:";
            // 
            // convertedLabel
            // 
            convertedLabel.AutoSize = true;
            convertedLabel.Location = new Point(92, 186);
            convertedLabel.Name = "convertedLabel";
            convertedLabel.Size = new Size(98, 25);
            convertedLabel.TabIndex = 3;
            convertedLabel.Text = "Converted:";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(201, 148);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(150, 31);
            amountTextBox.TabIndex = 4;
            // 
            // convertedTextBox
            // 
            convertedTextBox.Location = new Point(203, 195);
            convertedTextBox.Name = "convertedTextBox";
            convertedTextBox.Size = new Size(150, 31);
            convertedTextBox.TabIndex = 5;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(374, 301);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(112, 34);
            convertButton.TabIndex = 6;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += Convert;
            // 
            // invalidLabel
            // 
            invalidLabel.AutoSize = true;
            invalidLabel.Location = new Point(360, 250);
            invalidLabel.Name = "invalidLabel";
            invalidLabel.Size = new Size(0, 25);
            invalidLabel.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(invalidLabel);
            Controls.Add(convertButton);
            Controls.Add(convertedTextBox);
            Controls.Add(amountTextBox);
            Controls.Add(convertedLabel);
            Controls.Add(amountLabel);
            Controls.Add(EURtoBGNRadio);
            Controls.Add(BGNtoEURRadio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton BGNtoEURRadio;
        private RadioButton EURtoBGNRadio;
        private Label amountLabel;
        private Label convertedLabel;
        private TextBox amountTextBox;
        private TextBox convertedTextBox;
        private Button convertButton;
        private Label invalidLabel;
    }
}