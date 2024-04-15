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
            cityIDTextBox = new TextBox();
            cityNameTextBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // countryAddButton
            // 
            countryAddButton.Location = new Point(94, 204);
            countryAddButton.Name = "countryAddButton";
            countryAddButton.Size = new Size(112, 34);
            countryAddButton.TabIndex = 0;
            countryAddButton.Text = "Add";
            countryAddButton.UseVisualStyleBackColor = true;
            countryAddButton.Click += countryAddButton_Click;
            // 
            // countryUpdateButton
            // 
            countryUpdateButton.Location = new Point(242, 204);
            countryUpdateButton.Name = "countryUpdateButton";
            countryUpdateButton.Size = new Size(112, 34);
            countryUpdateButton.TabIndex = 1;
            countryUpdateButton.Text = "Update";
            countryUpdateButton.UseVisualStyleBackColor = true;
            countryUpdateButton.Click += countryUpdateButton_Click;
            // 
            // countryDeleteButton
            // 
            countryDeleteButton.Location = new Point(380, 204);
            countryDeleteButton.Name = "countryDeleteButton";
            countryDeleteButton.Size = new Size(112, 34);
            countryDeleteButton.TabIndex = 2;
            countryDeleteButton.Text = "Delete";
            countryDeleteButton.UseVisualStyleBackColor = true;
            countryDeleteButton.Click += countryDeleteButton_Click;
            // 
            // cityAddButton
            // 
            cityAddButton.Location = new Point(100, 452);
            cityAddButton.Name = "cityAddButton";
            cityAddButton.Size = new Size(112, 34);
            cityAddButton.TabIndex = 3;
            cityAddButton.Text = "Add";
            cityAddButton.UseVisualStyleBackColor = true;
            cityAddButton.Click += cityAddButton_Click;
            // 
            // cityUpdateButton
            // 
            cityUpdateButton.Location = new Point(240, 452);
            cityUpdateButton.Name = "cityUpdateButton";
            cityUpdateButton.Size = new Size(112, 34);
            cityUpdateButton.TabIndex = 4;
            cityUpdateButton.Text = "Update";
            cityUpdateButton.UseVisualStyleBackColor = true;
            cityUpdateButton.Click += cityUpdateButton_Click;
            // 
            // cityDeleteButton
            // 
            cityDeleteButton.Location = new Point(388, 452);
            cityDeleteButton.Name = "cityDeleteButton";
            cityDeleteButton.Size = new Size(112, 34);
            cityDeleteButton.TabIndex = 5;
            cityDeleteButton.Text = "Delete";
            cityDeleteButton.UseVisualStyleBackColor = true;
            cityDeleteButton.Click += cityDeleteButton_Click;
            // 
            // countryIDTextBox
            // 
            countryIDTextBox.Location = new Point(217, 58);
            countryIDTextBox.Name = "countryIDTextBox";
            countryIDTextBox.Size = new Size(150, 31);
            countryIDTextBox.TabIndex = 6;
            // 
            // countryNameTextBox
            // 
            countryNameTextBox.Location = new Point(217, 113);
            countryNameTextBox.Name = "countryNameTextBox";
            countryNameTextBox.Size = new Size(150, 31);
            countryNameTextBox.TabIndex = 7;
            // 
            // cityIDTextBox
            // 
            cityIDTextBox.Location = new Point(217, 306);
            cityIDTextBox.Name = "cityIDTextBox";
            cityIDTextBox.Size = new Size(150, 31);
            cityIDTextBox.TabIndex = 11;
            // 
            // cityNameTextBox
            // 
            cityNameTextBox.Location = new Point(217, 361);
            cityNameTextBox.Name = "cityNameTextBox";
            cityNameTextBox.Size = new Size(150, 31);
            cityNameTextBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 61);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 14;
            label1.Text = "Country_id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 364);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 16;
            label3.Text = "City_name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 312);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 17;
            label4.Text = "City_id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 119);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 18;
            label5.Text = "Country_name";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 573);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cityNameTextBox);
            Controls.Add(cityIDTextBox);
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
        private TextBox cityIDTextBox;
        private TextBox cityNameTextBox;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}