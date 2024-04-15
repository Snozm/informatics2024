namespace ListsApp
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
            countryComboBox = new ComboBox();
            cityComboBox = new ComboBox();
            adminButton = new Button();
            SuspendLayout();
            // 
            // countryComboBox
            // 
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Items.AddRange(new object[] { "Bulgaria", "Greece", "The Netherlands" });
            countryComboBox.Location = new Point(134, 109);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(182, 33);
            countryComboBox.TabIndex = 2;
            countryComboBox.Text = "Countries";
            // 
            // cityComboBox
            // 
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(538, 109);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(182, 33);
            cityComboBox.TabIndex = 3;
            cityComboBox.Text = "Cities";
            // 
            // adminButton
            // 
            adminButton.Location = new Point(359, 243);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(112, 34);
            adminButton.TabIndex = 9;
            adminButton.Text = "Admin";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Visible = false;
            adminButton.Click += adminButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 441);
            Controls.Add(adminButton);
            Controls.Add(cityComboBox);
            Controls.Add(countryComboBox);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Enter += Form1_Enter;
            ResumeLayout(false);
        }

        #endregion
        private ComboBox countryComboBox;
        private ComboBox cityComboBox;
        private Button adminButton;
    }
}