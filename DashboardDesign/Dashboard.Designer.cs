namespace DashboardDesign
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UserButton = new System.Windows.Forms.Button();
            this.ContactsButton = new System.Windows.Forms.Button();
            this.NotificationButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(61)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.NotificationButton);
            this.panel1.Controls.Add(this.ContactsButton);
            this.panel1.Controls.Add(this.UserButton);
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 49);
            this.panel1.TabIndex = 0;
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(61)))), ((int)(((byte)(96)))));
            this.MenuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuButton.BackgroundImage")));
            this.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Location = new System.Drawing.Point(217, 0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(51, 49);
            this.MenuButton.TabIndex = 1;
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 552);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(217, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 42);
            this.panel3.TabIndex = 2;
            // 
            // UserButton
            // 
            this.UserButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserButton.BackgroundImage")));
            this.UserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserButton.FlatAppearance.BorderSize = 0;
            this.UserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserButton.Location = new System.Drawing.Point(1150, 5);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(41, 41);
            this.UserButton.TabIndex = 2;
            this.UserButton.UseVisualStyleBackColor = true;
            // 
            // ContactsButton
            // 
            this.ContactsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContactsButton.BackgroundImage")));
            this.ContactsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContactsButton.FlatAppearance.BorderSize = 0;
            this.ContactsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactsButton.Location = new System.Drawing.Point(1092, 5);
            this.ContactsButton.Name = "ContactsButton";
            this.ContactsButton.Size = new System.Drawing.Size(52, 41);
            this.ContactsButton.TabIndex = 3;
            this.ContactsButton.UseVisualStyleBackColor = true;
            // 
            // NotificationButton
            // 
            this.NotificationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NotificationButton.BackgroundImage")));
            this.NotificationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NotificationButton.FlatAppearance.BorderSize = 0;
            this.NotificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotificationButton.Location = new System.Drawing.Point(1040, 5);
            this.NotificationButton.Name = "NotificationButton";
            this.NotificationButton.Size = new System.Drawing.Size(46, 41);
            this.NotificationButton.TabIndex = 4;
            this.NotificationButton.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1203, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button ContactsButton;
        private System.Windows.Forms.Button NotificationButton;
    }
}