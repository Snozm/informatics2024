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
            profileButton = new Button();
            usersButton = new Button();
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
            hobbiesGroupBox.Location = new Point(416, 116);
            hobbiesGroupBox.Margin = new Padding(2);
            hobbiesGroupBox.Name = "hobbiesGroupBox";
            hobbiesGroupBox.Padding = new Padding(2);
            hobbiesGroupBox.Size = new Size(210, 175);
            hobbiesGroupBox.TabIndex = 0;
            hobbiesGroupBox.TabStop = false;
            hobbiesGroupBox.Text = "Hobbies";
            // 
            // sleepCheckBox
            // 
            sleepCheckBox.AutoSize = true;
            sleepCheckBox.Location = new Point(40, 148);
            sleepCheckBox.Margin = new Padding(2);
            sleepCheckBox.Name = "sleepCheckBox";
            sleepCheckBox.Size = new Size(71, 19);
            sleepCheckBox.TabIndex = 6;
            sleepCheckBox.Text = "Sleeping";
            sleepCheckBox.UseVisualStyleBackColor = true;
            sleepCheckBox.CheckedChanged += sleepCheckBox_CheckedChanged;
            // 
            // readCheckBox
            // 
            readCheckBox.AutoSize = true;
            readCheckBox.Location = new Point(40, 127);
            readCheckBox.Margin = new Padding(2);
            readCheckBox.Name = "readCheckBox";
            readCheckBox.Size = new Size(69, 19);
            readCheckBox.TabIndex = 5;
            readCheckBox.Text = "Reading";
            readCheckBox.UseVisualStyleBackColor = true;
            readCheckBox.CheckedChanged += readCheckBox_CheckedChanged;
            // 
            // gamesCheckBox
            // 
            gamesCheckBox.AutoSize = true;
            gamesCheckBox.Location = new Point(40, 106);
            gamesCheckBox.Margin = new Padding(2);
            gamesCheckBox.Name = "gamesCheckBox";
            gamesCheckBox.Size = new Size(103, 19);
            gamesCheckBox.TabIndex = 4;
            gamesCheckBox.Text = "Playing games";
            gamesCheckBox.UseVisualStyleBackColor = true;
            gamesCheckBox.CheckedChanged += gamesCheckBox_CheckedChanged;
            // 
            // musicCheckBox
            // 
            musicCheckBox.AutoSize = true;
            musicCheckBox.Location = new Point(40, 85);
            musicCheckBox.Margin = new Padding(2);
            musicCheckBox.Name = "musicCheckBox";
            musicCheckBox.Size = new Size(123, 19);
            musicCheckBox.TabIndex = 3;
            musicCheckBox.Text = "Listening to music";
            musicCheckBox.UseVisualStyleBackColor = true;
            musicCheckBox.CheckedChanged += musicCheckBox_CheckedChanged;
            // 
            // chessCheckBox
            // 
            chessCheckBox.AutoSize = true;
            chessCheckBox.Location = new Point(40, 64);
            chessCheckBox.Margin = new Padding(2);
            chessCheckBox.Name = "chessCheckBox";
            chessCheckBox.Size = new Size(97, 19);
            chessCheckBox.TabIndex = 2;
            chessCheckBox.Text = "Playing chess";
            chessCheckBox.UseVisualStyleBackColor = true;
            chessCheckBox.CheckedChanged += chessCheckBox_CheckedChanged;
            // 
            // guitarCheckBox
            // 
            guitarCheckBox.AutoSize = true;
            guitarCheckBox.Location = new Point(40, 43);
            guitarCheckBox.Margin = new Padding(2);
            guitarCheckBox.Name = "guitarCheckBox";
            guitarCheckBox.Size = new Size(99, 19);
            guitarCheckBox.TabIndex = 1;
            guitarCheckBox.Text = "Playing guitar";
            guitarCheckBox.UseVisualStyleBackColor = true;
            guitarCheckBox.CheckedChanged += guitarCheckBox_CheckedChanged;
            // 
            // swimmingCheckBox
            // 
            swimmingCheckBox.AutoSize = true;
            swimmingCheckBox.Location = new Point(40, 22);
            swimmingCheckBox.Margin = new Padding(2);
            swimmingCheckBox.Name = "swimmingCheckBox";
            swimmingCheckBox.Size = new Size(83, 19);
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
            timeGroupBox.Location = new Point(717, 116);
            timeGroupBox.Margin = new Padding(2);
            timeGroupBox.Name = "timeGroupBox";
            timeGroupBox.Padding = new Padding(2);
            timeGroupBox.Size = new Size(210, 175);
            timeGroupBox.TabIndex = 1;
            timeGroupBox.TabStop = false;
            timeGroupBox.Text = "Time";
            // 
            // eveningRadioButton
            // 
            eveningRadioButton.AutoSize = true;
            eveningRadioButton.Location = new Point(60, 127);
            eveningRadioButton.Margin = new Padding(2);
            eveningRadioButton.Name = "eveningRadioButton";
            eveningRadioButton.Size = new Size(67, 19);
            eveningRadioButton.TabIndex = 2;
            eveningRadioButton.TabStop = true;
            eveningRadioButton.Text = "Evening";
            eveningRadioButton.UseVisualStyleBackColor = true;
            eveningRadioButton.CheckedChanged += eveningRadioButton_CheckedChanged;
            // 
            // afternoonRadioButton
            // 
            afternoonRadioButton.AutoSize = true;
            afternoonRadioButton.Location = new Point(60, 77);
            afternoonRadioButton.Margin = new Padding(2);
            afternoonRadioButton.Name = "afternoonRadioButton";
            afternoonRadioButton.Size = new Size(79, 19);
            afternoonRadioButton.TabIndex = 1;
            afternoonRadioButton.TabStop = true;
            afternoonRadioButton.Text = "Afternoon";
            afternoonRadioButton.UseVisualStyleBackColor = true;
            afternoonRadioButton.CheckedChanged += afternoonRadioButton_CheckedChanged;
            // 
            // morningRadioButton
            // 
            morningRadioButton.AutoSize = true;
            morningRadioButton.Location = new Point(60, 26);
            morningRadioButton.Margin = new Padding(2);
            morningRadioButton.Name = "morningRadioButton";
            morningRadioButton.Size = new Size(71, 19);
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
            countryComboBox.Location = new Point(162, 150);
            countryComboBox.Margin = new Padding(2);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(129, 23);
            countryComboBox.TabIndex = 2;
            countryComboBox.Text = "Choose a country";
            countryComboBox.SelectedIndexChanged += countryComboBox_SelectedIndexChanged;
            // 
            // cityComboBox
            // 
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(162, 375);
            cityComboBox.Margin = new Padding(2);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(129, 23);
            cityComboBox.TabIndex = 3;
            cityComboBox.Text = "Choose a city";
            cityComboBox.SelectedIndexChanged += cityComboBox_SelectedIndexChanged;
            // 
            // initialListBox
            // 
            initialListBox.FormattingEnabled = true;
            initialListBox.ItemHeight = 15;
            initialListBox.Location = new Point(456, 342);
            initialListBox.Margin = new Padding(2);
            initialListBox.Name = "initialListBox";
            initialListBox.Size = new Size(127, 79);
            initialListBox.TabIndex = 4;
            // 
            // finalListBox
            // 
            finalListBox.FormattingEnabled = true;
            finalListBox.ItemHeight = 15;
            finalListBox.Location = new Point(759, 342);
            finalListBox.Margin = new Padding(2);
            finalListBox.Name = "finalListBox";
            finalListBox.Size = new Size(127, 79);
            finalListBox.TabIndex = 5;
            // 
            // addHobbiesButton
            // 
            addHobbiesButton.Location = new Point(659, 342);
            addHobbiesButton.Margin = new Padding(2);
            addHobbiesButton.Name = "addHobbiesButton";
            addHobbiesButton.Size = new Size(34, 20);
            addHobbiesButton.TabIndex = 6;
            addHobbiesButton.Text = ">>";
            addHobbiesButton.UseVisualStyleBackColor = true;
            addHobbiesButton.Click += addHobbiesButton_Click;
            // 
            // removeHobbiesButton
            // 
            removeHobbiesButton.Location = new Point(659, 399);
            removeHobbiesButton.Margin = new Padding(2);
            removeHobbiesButton.Name = "removeHobbiesButton";
            removeHobbiesButton.Size = new Size(34, 20);
            removeHobbiesButton.TabIndex = 7;
            removeHobbiesButton.Text = "<<";
            removeHobbiesButton.UseVisualStyleBackColor = true;
            removeHobbiesButton.Click += removeHobbiesButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(481, 545);
            submitButton.Margin = new Padding(2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(78, 20);
            submitButton.TabIndex = 8;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // adminButton
            // 
            adminButton.Location = new Point(373, 500);
            adminButton.Margin = new Padding(2);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(78, 20);
            adminButton.TabIndex = 9;
            adminButton.Text = "Admin";
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Visible = false;
            adminButton.Click += adminButton_Click;
            // 
            // profileButton
            // 
            profileButton.Location = new Point(484, 497);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(75, 23);
            profileButton.TabIndex = 10;
            profileButton.Text = "Profile";
            profileButton.UseVisualStyleBackColor = true;
            profileButton.Click += profileButton_Click;
            // 
            // usersButton
            // 
            usersButton.Location = new Point(594, 497);
            usersButton.Name = "usersButton";
            usersButton.Size = new Size(75, 23);
            usersButton.TabIndex = 11;
            usersButton.Text = "Users";
            usersButton.UseVisualStyleBackColor = true;
            usersButton.Visible = false;
            usersButton.Click += usersButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 637);
            Controls.Add(usersButton);
            Controls.Add(profileButton);
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
            Margin = new Padding(2);
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
        private Button profileButton;
        private Button usersButton;
    }
}