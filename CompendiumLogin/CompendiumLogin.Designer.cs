namespace CompendiumLogin
{
    partial class CompendiumLogin
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
            this.Login = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.grpCredentials = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.grpCredentials.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 92);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(260, 50);
            this.Login.TabIndex = 0;
            this.Login.Text = "&Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(70, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(184, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // grpCredentials
            // 
            this.grpCredentials.Controls.Add(this.txtPassword);
            this.grpCredentials.Controls.Add(this.lblPassword);
            this.grpCredentials.Controls.Add(this.lblUsername);
            this.grpCredentials.Controls.Add(this.txtUsername);
            this.grpCredentials.Location = new System.Drawing.Point(12, 12);
            this.grpCredentials.Name = "grpCredentials";
            this.grpCredentials.Size = new System.Drawing.Size(260, 74);
            this.grpCredentials.TabIndex = 2;
            this.grpCredentials.TabStop = false;
            this.grpCredentials.Text = "Credentials";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(70, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(184, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 48);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            // 
            // CompendiumLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 154);
            this.Controls.Add(this.grpCredentials);
            this.Controls.Add(this.Login);
            this.Name = "CompendiumLogin";
            this.Text = "Compendium Login";
            this.grpCredentials.ResumeLayout(false);
            this.grpCredentials.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox grpCredentials;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
    }
}

