namespace WindowsFormsApp1
{
    partial class Popup_window_CustomerAccount
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeLabel.Font = new System.Drawing.Font("SimSun-ExtB", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(534, 154);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Hi (name)";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.Location = new System.Drawing.Point(187, 308);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(136, 67);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Log out";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // leaveButton
            // 
            this.leaveButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leaveButton.Location = new System.Drawing.Point(204, 406);
            this.leaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(101, 45);
            this.leaveButton.TabIndex = 7;
            this.leaveButton.Text = "Cancel";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // Popup_window_CustomerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Popup_window_CustomerAccount";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.login_window_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button leaveButton;
    }
}