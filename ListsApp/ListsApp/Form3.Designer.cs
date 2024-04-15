namespace ListsApp
{
    partial class Form3
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
            label5 = new Label();
            label1 = new Label();
            passwordTextBox1 = new TextBox();
            usernameTextBox = new TextBox();
            loginButton = new Button();
            registerButton = new Button();
            label2 = new Label();
            passwordTextBox2 = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(223, 151);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 22;
            label5.Text = "password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 96);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 21;
            label1.Text = "username";
            // 
            // passwordTextBox1
            // 
            passwordTextBox1.Location = new Point(319, 148);
            passwordTextBox1.Name = "passwordTextBox1";
            passwordTextBox1.Size = new Size(150, 31);
            passwordTextBox1.TabIndex = 20;
            passwordTextBox1.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(319, 93);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(150, 31);
            usernameTextBox.TabIndex = 19;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(252, 266);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(112, 34);
            loginButton.TabIndex = 23;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(413, 266);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(112, 34);
            registerButton.TabIndex = 24;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 208);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 26;
            label2.Text = "repeat password";
            // 
            // passwordTextBox2
            // 
            passwordTextBox2.Location = new Point(319, 202);
            passwordTextBox2.Name = "passwordTextBox2";
            passwordTextBox2.Size = new Size(150, 31);
            passwordTextBox2.TabIndex = 25;
            passwordTextBox2.UseSystemPasswordChar = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(passwordTextBox2);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(passwordTextBox1);
            Controls.Add(usernameTextBox);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private TextBox passwordTextBox1;
        private TextBox usernameTextBox;
        private Button loginButton;
        private Button registerButton;
        private Label label2;
        private TextBox passwordTextBox2;
    }
}