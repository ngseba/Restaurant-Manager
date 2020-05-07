namespace RestaurantManagerClient
{
    partial class LoginForm
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
            this.usernameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.loginSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.statusLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // usernameTextbox
            // 
            // 
            // 
            // 
            this.usernameTextbox.CustomButton.Image = null;
            this.usernameTextbox.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.usernameTextbox.CustomButton.Name = "";
            this.usernameTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usernameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameTextbox.CustomButton.TabIndex = 1;
            this.usernameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameTextbox.CustomButton.UseSelectable = true;
            this.usernameTextbox.CustomButton.Visible = false;
            this.usernameTextbox.Lines = new string[] {
        "eatingestablishment"};
            this.usernameTextbox.Location = new System.Drawing.Point(115, 164);
            this.usernameTextbox.MaxLength = 32767;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.PasswordChar = '\0';
            this.usernameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTextbox.SelectedText = "";
            this.usernameTextbox.SelectionLength = 0;
            this.usernameTextbox.SelectionStart = 0;
            this.usernameTextbox.ShortcutsEnabled = true;
            this.usernameTextbox.Size = new System.Drawing.Size(116, 23);
            this.usernameTextbox.TabIndex = 0;
            this.usernameTextbox.Text = "eatingestablishment";
            this.usernameTextbox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameTextbox.UseSelectable = true;
            this.usernameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernameTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordTextbox
            // 
            // 
            // 
            // 
            this.passwordTextbox.CustomButton.Image = null;
            this.passwordTextbox.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.passwordTextbox.CustomButton.Name = "";
            this.passwordTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextbox.CustomButton.TabIndex = 1;
            this.passwordTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextbox.CustomButton.UseSelectable = true;
            this.passwordTextbox.CustomButton.Visible = false;
            this.passwordTextbox.Lines = new string[] {
        "abc123"};
            this.passwordTextbox.Location = new System.Drawing.Point(115, 209);
            this.passwordTextbox.MaxLength = 32767;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextbox.SelectedText = "";
            this.passwordTextbox.SelectionLength = 0;
            this.passwordTextbox.SelectionStart = 0;
            this.passwordTextbox.ShortcutsEnabled = true;
            this.passwordTextbox.Size = new System.Drawing.Size(116, 23);
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.Text = "abc123";
            this.passwordTextbox.UseSelectable = true;
            this.passwordTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 164);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Username";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(41, 209);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.loginButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(94, 295);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(84, 33);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Log in";
            this.loginButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginSpinner
            // 
            this.loginSpinner.Enabled = false;
            this.loginSpinner.EnsureVisible = false;
            this.loginSpinner.Location = new System.Drawing.Point(115, 347);
            this.loginSpinner.Maximum = 100;
            this.loginSpinner.Name = "loginSpinner";
            this.loginSpinner.Size = new System.Drawing.Size(45, 45);
            this.loginSpinner.Speed = 2F;
            this.loginSpinner.TabIndex = 2;
            this.loginSpinner.UseSelectable = true;
            this.loginSpinner.Value = 30;
            this.loginSpinner.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(41, 253);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(83, 19);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "metroLabel3";
            this.statusLabel.UseCustomForeColor = true;
            this.statusLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 439);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.loginSpinner);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox usernameTextbox;
        private MetroFramework.Controls.MetroTextBox passwordTextbox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroProgressSpinner loginSpinner;
        private MetroFramework.Controls.MetroLabel statusLabel;
    }
}