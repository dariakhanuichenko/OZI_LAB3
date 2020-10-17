namespace OZI_lab1
{
    partial class UserControl
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
            this.addUser = new System.Windows.Forms.Button();
            this.blockUser = new System.Windows.Forms.Button();
            this.restrictUser = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(35, 362);
            this.addUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(151, 47);
            this.addUser.TabIndex = 1;
            this.addUser.Text = "Add user";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // blockUser
            // 
            this.blockUser.Location = new System.Drawing.Point(203, 362);
            this.blockUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.blockUser.Name = "blockUser";
            this.blockUser.Size = new System.Drawing.Size(151, 47);
            this.blockUser.TabIndex = 2;
            this.blockUser.Text = "Block";
            this.blockUser.UseVisualStyleBackColor = false;
            this.blockUser.Click += new System.EventHandler(this.blockUser_Click);
            // 
            // restrictUser
            // 
            this.restrictUser.Location = new System.Drawing.Point(362, 363);
            this.restrictUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.restrictUser.Name = "restrictUser";
            this.restrictUser.Size = new System.Drawing.Size(151, 46);
            this.restrictUser.TabIndex = 3;
            this.restrictUser.Text = "Restriction";
            this.restrictUser.UseVisualStyleBackColor = false;
            this.restrictUser.Click += new System.EventHandler(this.restrictUser_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(35, 53);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.Size = new System.Drawing.Size(760, 300);
            this.dataGridViewUsers.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(758, 9);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 421);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.restrictUser);
            this.Controls.Add(this.blockUser);
            this.Controls.Add(this.addUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl";
            this.Text = "UserControl";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button blockUser;
        private System.Windows.Forms.Button restrictUser;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}