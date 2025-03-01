namespace login_assignment
{
    partial class Form1
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
            this.Alert = new System.Windows.Forms.Label();
            this.Mylink = new System.Windows.Forms.LinkLabel();
            this.Login = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Alert
            // 
            this.Alert.AutoSize = true;
            this.Alert.Location = new System.Drawing.Point(93, 251);
            this.Alert.Name = "Alert";
            this.Alert.Size = new System.Drawing.Size(0, 13);
            this.Alert.TabIndex = 13;
            // 
            // Mylink
            // 
            this.Mylink.AutoSize = true;
            this.Mylink.LinkColor = System.Drawing.Color.Black;
            this.Mylink.Location = new System.Drawing.Point(93, 210);
            this.Mylink.Name = "Mylink";
            this.Mylink.Size = new System.Drawing.Size(84, 13);
            this.Mylink.TabIndex = 12;
            this.Mylink.TabStop = true;
            this.Mylink.Text = "Reset Password";
            this.Mylink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Mylink_LinkClicked);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(96, 172);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(170, 23);
            this.Login.TabIndex = 11;
            this.Login.Text = "Submit";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(93, 118);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(93, 82);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "Username";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(166, 115);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 8;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(166, 79);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 7;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Alert);
            this.Controls.Add(this.Mylink);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Alert;
        private System.Windows.Forms.LinkLabel Mylink;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
    }
}

