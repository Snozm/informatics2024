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
            hobbiesGroupBox = new GroupBox();
            sleepCheckBox = new CheckBox();
            readCheckBox = new CheckBox();
            gamesCheckBox = new CheckBox();
            musicCheckBox = new CheckBox();
            chessCheckBox = new CheckBox();
            guitarCheckBox = new CheckBox();
            swimmingCheckBox = new CheckBox();
            timeGroupBox = new GroupBox();
            eveningRadioButton = new RadioButton();
            afternoonRadioButton = new RadioButton();
            morningRadioButton = new RadioButton();
            countryComboBox = new ComboBox();
            cityComboBox = new ComboBox();
            initialListBox = new ListBox();
            finalListBox = new ListBox();
            addHobbiesButton = new Button();
            removeHobbiesButton = new Button();
            submitButton = new Button();
            adminButton = new Button();
            hobbiesGroupBox.SuspendLayout();
            timeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // hobbiesGroupBox
            // 
            hobbiesGroupBox.Controls.Add(sleepCheckBox);
            hobbiesGroupBox.Controls.Add(readCheckBox);
            hobbiesGroupBox.Controls.Add(gamesCheckBox);
            hobbiesGroupBox.Controls.Add(musicCheckBox);
            hobbiesGroupBox.Controls.Add(chessCheckBox);
            hobbiesGroupBox.Controls.Add(guitarCheckBox);
            hobbiesGroupBox.Controls.Add(swimmingCheckBox);
            hobbiesGroupBox.Location = new Point(594, 193);
            hobbiesGroupBox.Name = "hobbiesGroupBox";
            hobbiesGroupBox.Size = new Size(300, 292);
            hobbiesGroupBox.TabIndex = 0;
            hobbiesGroupBox.TabStop = false;
            hobbiesGroupBox.Text = "Hobbies";
            // 
            // sleepCheckBox
            // 
            sleepCheckBox.AutoSize = true;
            sleepCheckBox.Location = new Point(57, 247);
            sleepCheckBox.Name = "sleepCheckBox";
            sleepCheckBox.Size = new Size(106, 29);
            sleepCheckBox.TabIndex = 6;
            sleepCheckBox.Text = "Sleeping";
            sleepCheckBox.UseVisualStyleBackColor = true;
            sleepCheckBox.CheckedChanged += sleepCheckBox_CheckedChanged;
            // 
            // readCheckBox
            // 
            readCheckBox.AutoSize = true;
            readCheckBox.Location = new Point(57, 212);
            readCheckBox.Name = "readCheckBox";
            readCheckBox.Size = new Size(102, 29);
            readCheckBox.TabIndex = 5;
            readCheckBox.Text = "Reading";
            readCheckBox.UseVisualStyleBackColor = true;
            readCheckBox.CheckedChanged += readCheckBox_CheckedChanged;
            // 
            // gamesCheckBox
            // 
            gamesCheckBox.AutoSize = true;
            gamesCheckBox.Location = new Point(57, 177);
            gamesCheckBox.Name = "gamesCheckBox";
            gamesCheckBox.Size = new Size(153, 29);
            gamesCheckBox.TabIndex = 4;
            gamesCheckBox.Text = "Playing games";
            gamesCheckBox.UseVisualStyleBackColor = true;
            gamesCheckBox.CheckedChanged += gamesCheckBox_CheckedChanged;
            // 
            // musicCheckBox
            // 
            musicCheckBox.AutoSize = true;
            musicCheckBox.Location = new Point(57, 142);
            musicCheckBox.Name = "musicCheckBox";
            musicCheckBox.Size = new Size(181, 29);
            musicCheckBox.TabIndex = 3;
            musicCheckBox.Text = "Listening to music";
            musicCheckBox.UseVisualStyleBackColor = true;
            musicCheckBox.CheckedChanged += musicCheckBox_CheckedChanged;
            // 
            // chessCheckBox
            // 
            chessCheckBox.AutoSize = true;
            chessCheckBox.Location = new Point(57, 107);
            chessCheckBox.Name = "chessCheckBox";
            chessCheckBox.Size = new Size(143, 29);
            chessCheckBox.TabIndex = 2;
            chessCheckBox.Text = "Playing chess";
            chessCheckBox.UseVisualStyleBackColor = true;
            chessCheckBox.CheckedChanged += chessCheckBox_CheckedChanged;
            // 
            // guitarCheckBox
            // 
            guitarCheckBox.AutoSize = true;
            guitarCheckBox.Location = new Point(57, 72);
            guitarCheckBox.Name = "guitarCheckBox";
            guitarCheckBox.Size = new Size(146, 29);
            guitarCheckBox.TabIndex = 1;
            guitarCheckBox.Text = "Playing guitar";
            guitarCheckBox.UseVisualStyleBackColor = true;
            guitarCheckBox.CheckedChanged += guitarCheckBox_CheckedChanged;
            // 
            // swimmingCheckBox
            // 
            swimmingCheckBox.AutoSize = true;
            swimmingCheckBox.Location = new Point(57, 37);
            swimmingCheckBox.Name = "swimmingCheckBox";
            swimmingCheckBox.Size = new Size(122, 29);
            swimmingCheckBox.TabIndex = 0;
            swimmingCheckBox.Text = "Swimming";
            swimmingCheckBox.UseVisualStyleBackColor = true;
            swimmingCheckBox.CheckedChanged += swimmingCheckBox_CheckedChanged;
            // 
            // timeGroupBox
            // 
            timeGroupBox.Controls.Add(eveningRadioButton);
            timeGroupBox.Controls.Add(afternoonRadioButton);
            timeGroupBox.Controls.Add(morningRadioButton);
            timeGroupBox.Location = new Point(1024, 193);
            timeGroupBox.Name = "timeGroupBox";
            timeGroupBox.Size = new Size(300, 292);
            timeGroupBox.TabIndex = 1;
            timeGroupBox.TabStop = false;
            timeGroupBox.Text = "Time";
            // 
            // eveningRadioButton
            // 
            eveningRadioButton.AutoSize = true;
            eveningRadioButton.Location = new Point(85, 212);
            eveningRadioButton.Name = "eveningRadioButton";
            eveningRadioButton.Size = new Size(99, 29);
            eveningRadioButton.TabIndex = 2;
            eveningRadioButton.TabStop = true;
            eveningRadioButton.Text = "Evening";
            eveningRadioButton.UseVisualStyleBackColor = true;
            eveningRadioButton.CheckedChanged += eveningRadioButton_CheckedChanged;
            // 
            // afternoonRadioButton
            // 
            afternoonRadioButton.AutoSize = true;
            afternoonRadioButton.Location = new Point(85, 128);
            afternoonRadioButton.Name = "afternoonRadioButton";
            afternoonRadioButton.Size = new Size(118, 29);
            afternoonRadioButton.TabIndex = 1;
            afternoonRadioButton.TabStop = true;
            afternoonRadioButton.Text = "Afternoon";
            afternoonRadioButton.UseVisualStyleBackColor = true;
            afternoonRadioButton.CheckedChanged += afternoonRadioButton_CheckedChanged;
            // 
            // morningRadioButton
            // 
            morningRadioButton.AutoSize = true;
            morningRadioButton.Location = new Point(85, 44);
            morningRadioButton.Name = "morningRadioButton";
            morningRadioButton.Size = new Size(105, 29);
            morningRadioButton.TabIndex = 0;
            morningRadioButton.TabStop = true;
            morningRadioButton.Text = "Morning";
            morningRadioButton.UseVisualStyleBackColor = true;
            morningRadioButton.CheckedChanged += morningRadioButton_CheckedChanged;
            // 
            // countryComboBox
            // 
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Items.AddRange(new object[] { "Bulgaria", "Greece", "The Netherlands" });
            countryComboBox.Location = new Point(232, 250);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(182, 33);
            countryComboBox.TabIndex = 2;
            countryComboBox.Text = "Choose a country";
            countryComboBox.SelectedIndexChanged += countryComboBox_SelectedIndexChanged;
            // 
            // cityComboBox
            // 
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(232, 625);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(182, 33);
            cityComboBox.TabIndex = 3;
            cityComboBox.Text = "Choose a city";
            cityComboBox.SelectedIndexChanged += cityComboBox_SelectedIndexChanged;
            // 
            // initialListBox
            // 
            initialListBox.FormattingEnabled = true;
            initialListBox.ItemHeight = 25;
            initialListBox.Location = new Point(651, 570);
            initialListBox.Name = "initialListBox";
            initialListBox.Size = new Size(180, 129);
            initialListBox.TabIndex = 4;
            // 
            // finalListBox
            // 
            finalListBox.FormattingEnabled = true;
            finalListBox.ItemHeight = 25;
            finalListBox.Location = new Point(1084, 570);
            finalListBox.Name = "finalListBox";
            finalListBox.Size = new Size(180, 129);
            finalListBox.TabIndex = 5;
            // 
            // addHobbiesButton
            // 
            addHobbiesButton.Location = new Point(941, 570);
            addHobbiesButton.Name = "addHobbiesButton";
            addHobbiesButton.Size = new Size(48, 34);
            addHobbiesButton.TabIndex = 6;
            addHobbiesButton.Text = ">>";
            addHobbiesButton.UseVisualStyleBackColor = true;
            addHobbiesButton.Click += addHobbiesButton_Click;
            // 
            // removeHobbiesButton
            // 
            removeHobbiesButton.Location = new Point(941, 665);
            removeHobbiesButton.Name = "removeHobbiesButton";
            removeHobbiesButton.Size = new Size(48, 34);
            removeHobbiesButton.TabIndex = 7;
            removeHobbiesButton.Text = "<<";
            removeHobbiesButton.UseVisualStyleBackColor = true;
            removeHobbiesButton.Click += removeHobbiesButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(688, 855);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(112, 34);
            submitButton.TabIndex = 8;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // adminButton
            // 
            adminButton.Location = new Point(688, 929);
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
            ClientSize = new Size(1578, 1144);
            Controls.Add(adminButton);
            Controls.Add(submitButton);
            Controls.Add(removeHobbiesButton);
            Controls.Add(addHobbiesButton);
            Controls.Add(finalListBox);
            Controls.Add(initialListBox);
            Controls.Add(cityComboBox);
            Controls.Add(countryComboBox);
            Controls.Add(timeGroupBox);
            Controls.Add(hobbiesGroupBox);
            Name = "Form1";
            Text = "Vacation";
            Activated += Form1_Activated;
            Enter += Form1_Enter;
            hobbiesGroupBox.ResumeLayout(false);
            hobbiesGroupBox.PerformLayout();
            timeGroupBox.ResumeLayout(false);
            timeGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox hobbiesGroupBox;
        private GroupBox timeGroupBox;
        private ComboBox countryComboBox;
        private ComboBox cityComboBox;
        private ListBox initialListBox;
        private ListBox finalListBox;
        private Button addHobbiesButton;
        private Button removeHobbiesButton;
        private Button submitButton;
        private RadioButton eveningRadioButton;
        private RadioButton afternoonRadioButton;
        private RadioButton morningRadioButton;
        private CheckBox sleepCheckBox;
        private CheckBox readCheckBox;
        private CheckBox gamesCheckBox;
        private CheckBox musicCheckBox;
        private CheckBox chessCheckBox;
        private CheckBox guitarCheckBox;
        private CheckBox swimmingCheckBox;
        private Button adminButton;
    }
}