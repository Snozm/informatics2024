namespace ListsApp
{
    partial class Form2
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
            countryAddButton = new Button();
            countryUpdateButton = new Button();
            countryDeleteButton = new Button();
            cityAddButton = new Button();
            cityUpdateButton = new Button();
            cityDeleteButton = new Button();
            countryIDTextBox = new TextBox();
            countryNameTextBox = new TextBox();
            countryCodeTextBox = new TextBox();
            countryCurrencyTextBox = new TextBox();
            capitalIDTextBox = new TextBox();
            cityIDTextBox = new TextBox();
            cityNameTextBox = new TextBox();
            cityCountryIDTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // countryAddButton
            // 
            countryAddButton.Location = new Point(318, 374);
            countryAddButton.Name = "countryAddButton";
            countryAddButton.Size = new Size(112, 34);
            countryAddButton.TabIndex = 0;
            countryAddButton.Text = "Add";
            countryAddButton.UseVisualStyleBackColor = true;
            countryAddButton.Click += countryAddButton_Click;
            // 
            // countryUpdateButton
            // 
            countryUpdateButton.Location = new Point(318, 483);
            countryUpdateButton.Name = "countryUpdateButton";
            countryUpdateButton.Size = new Size(112, 34);
            countryUpdateButton.TabIndex = 1;
            countryUpdateButton.Text = "Update";
            countryUpdateButton.UseVisualStyleBackColor = true;
            countryUpdateButton.Click += countryUpdateButton_Click;
            // 
            // countryDeleteButton
            // 
            countryDeleteButton.Location = new Point(318, 590);
            countryDeleteButton.Name = "countryDeleteButton";
            countryDeleteButton.Size = new Size(112, 34);
            countryDeleteButton.TabIndex = 2;
            countryDeleteButton.Text = "Delete";
            countryDeleteButton.UseVisualStyleBackColor = true;
            countryDeleteButton.Click += countryDeleteButton_Click;
            // 
            // cityAddButton
            // 
            cityAddButton.Location = new Point(948, 372);
            cityAddButton.Name = "cityAddButton";
            cityAddButton.Size = new Size(112, 34);
            cityAddButton.TabIndex = 3;
            cityAddButton.Text = "Add";
            cityAddButton.UseVisualStyleBackColor = true;
            cityAddButton.Click += cityAddButton_Click;
            // 
            // cityUpdateButton
            // 
            cityUpdateButton.Location = new Point(948, 483);
            cityUpdateButton.Name = "cityUpdateButton";
            cityUpdateButton.Size = new Size(112, 34);
            cityUpdateButton.TabIndex = 4;
            cityUpdateButton.Text = "Update";
            cityUpdateButton.UseVisualStyleBackColor = true;
            cityUpdateButton.Click += cityUpdateButton_Click;
            // 
            // cityDeleteButton
            // 
            cityDeleteButton.Location = new Point(948, 590);
            cityDeleteButton.Name = "cityDeleteButton";
            cityDeleteButton.Size = new Size(112, 34);
            cityDeleteButton.TabIndex = 5;
            cityDeleteButton.Text = "Delete";
            cityDeleteButton.UseVisualStyleBackColor = true;
            cityDeleteButton.Click += cityDeleteButton_Click;
            // 
            // countryIDTextBox
            // 
            countryIDTextBox.Location = new Point(301, 63);
            countryIDTextBox.Name = "countryIDTextBox";
            countryIDTextBox.Size = new Size(150, 31);
            countryIDTextBox.TabIndex = 6;
            // 
            // countryNameTextBox
            // 
            countryNameTextBox.Location = new Point(301, 118);
            countryNameTextBox.Name = "countryNameTextBox";
            countryNameTextBox.Size = new Size(150, 31);
            countryNameTextBox.TabIndex = 7;
            // 
            // countryCodeTextBox
            // 
            countryCodeTextBox.Location = new Point(301, 173);
            countryCodeTextBox.Name = "countryCodeTextBox";
            countryCodeTextBox.Size = new Size(150, 31);
            countryCodeTextBox.TabIndex = 8;
            // 
            // countryCurrencyTextBox
            // 
            countryCurrencyTextBox.Location = new Point(301, 226);
            countryCurrencyTextBox.Name = "countryCurrencyTextBox";
            countryCurrencyTextBox.Size = new Size(150, 31);
            countryCurrencyTextBox.TabIndex = 9;
            // 
            // capitalIDTextBox
            // 
            capitalIDTextBox.Location = new Point(301, 281);
            capitalIDTextBox.Name = "capitalIDTextBox";
            capitalIDTextBox.Size = new Size(150, 31);
            capitalIDTextBox.TabIndex = 10;
            // 
            // cityIDTextBox
            // 
            cityIDTextBox.Location = new Point(925, 115);
            cityIDTextBox.Name = "cityIDTextBox";
            cityIDTextBox.Size = new Size(150, 31);
            cityIDTextBox.TabIndex = 11;
            // 
            // cityNameTextBox
            // 
            cityNameTextBox.Location = new Point(925, 170);
            cityNameTextBox.Name = "cityNameTextBox";
            cityNameTextBox.Size = new Size(150, 31);
            cityNameTextBox.TabIndex = 12;
            // 
            // cityCountryIDTextBox
            // 
            cityCountryIDTextBox.Location = new Point(925, 223);
            cityCountryIDTextBox.Name = "cityCountryIDTextBox";
            cityCountryIDTextBox.Size = new Size(150, 31);
            cityCountryIDTextBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 66);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 14;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(802, 226);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 15;
            label2.Text = "Country_ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(860, 173);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 16;
            label3.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(872, 118);
            label4.Name = "label4";
            label4.Size = new Size(30, 25);
            label4.TabIndex = 17;
            label4.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 121);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 18;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(226, 176);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 19;
            label6.Text = "Code";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(199, 229);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 20;
            label7.Text = "Currency";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(189, 284);
            label8.Name = "label8";
            label8.Size = new Size(91, 25);
            label8.TabIndex = 21;
            label8.Text = "Capital_ID";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 739);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cityCountryIDTextBox);
            Controls.Add(cityNameTextBox);
            Controls.Add(cityIDTextBox);
            Controls.Add(capitalIDTextBox);
            Controls.Add(countryCurrencyTextBox);
            Controls.Add(countryCodeTextBox);
            Controls.Add(countryNameTextBox);
            Controls.Add(countryIDTextBox);
            Controls.Add(cityDeleteButton);
            Controls.Add(cityUpdateButton);
            Controls.Add(cityAddButton);
            Controls.Add(countryDeleteButton);
            Controls.Add(countryUpdateButton);
            Controls.Add(countryAddButton);
            Name = "Form2";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button countryAddButton;
        private Button countryUpdateButton;
        private Button countryDeleteButton;
        private Button cityAddButton;
        private Button cityUpdateButton;
        private Button cityDeleteButton;
        private TextBox countryIDTextBox;
        private TextBox countryNameTextBox;
        private TextBox countryCodeTextBox;
        private TextBox countryCurrencyTextBox;
        private TextBox capitalIDTextBox;
        private TextBox cityIDTextBox;
        private TextBox cityNameTextBox;
        private TextBox cityCountryIDTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}