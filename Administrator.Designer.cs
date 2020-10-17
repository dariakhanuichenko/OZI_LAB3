namespace OZI_lab1
{
    partial class Administrator
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
            this.changePassword = new System.Windows.Forms.Button();
            this.controlUsers = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.set_password_phrase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changePassword
            // 
            this.changePassword.Location = new System.Drawing.Point(37, 78);
            this.changePassword.Margin = new System.Windows.Forms.Padding(4);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(145, 44);
            this.changePassword.TabIndex = 0;
            this.changePassword.Text = "Change password";
            this.changePassword.UseVisualStyleBackColor = false;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // controlUsers
            // 
            this.controlUsers.Location = new System.Drawing.Point(224, 78);
            this.controlUsers.Margin = new System.Windows.Forms.Padding(4);
            this.controlUsers.Name = "controlUsers";
            this.controlUsers.Size = new System.Drawing.Size(145, 44);
            this.controlUsers.TabIndex = 1;
            this.controlUsers.Text = "User management";
            this.controlUsers.UseVisualStyleBackColor = false;
            this.controlUsers.Click += new System.EventHandler(this.controlUsers_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(141, 229);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(145, 44);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(368, 9);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // set_password_phrase
            // 
            this.set_password_phrase.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.set_password_phrase.Location = new System.Drawing.Point(141, 149);
            this.set_password_phrase.Margin = new System.Windows.Forms.Padding(4);
            this.set_password_phrase.Name = "set_password_phrase";
            this.set_password_phrase.Size = new System.Drawing.Size(145, 50);
            this.set_password_phrase.TabIndex = 8;
            this.set_password_phrase.Text = "Set password phrase";
            this.set_password_phrase.UseVisualStyleBackColor = false;
            this.set_password_phrase.Click += new System.EventHandler(this.set_password_phrase_Click_1);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 297);
            this.Controls.Add(this.set_password_phrase);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.controlUsers);
            this.Controls.Add(this.changePassword);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.Button controlUsers;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button set_password_phrase;
    }
}