namespace WindowsFormsApp1
{
    partial class Popup_window_EmployeeLogin
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
            this.CardIDTextbox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("SimSun-ExtB", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(27, 112);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(646, 50);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Enter your Employee Card";
            // 
            // CardIDTextbox
            // 
            this.CardIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CardIDTextbox.Location = new System.Drawing.Point(72, 256);
            this.CardIDTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CardIDTextbox.Name = "CardIDTextbox";
            this.CardIDTextbox.Size = new System.Drawing.Size(559, 55);
            this.CardIDTextbox.TabIndex = 4;
            this.CardIDTextbox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.Location = new System.Drawing.Point(236, 383);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(241, 113);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Enter";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // leaveButton
            // 
            this.leaveButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leaveButton.Location = new System.Drawing.Point(284, 547);
            this.leaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(135, 55);
            this.leaveButton.TabIndex = 7;
            this.leaveButton.Text = "Cancel";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // Popup_window_EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 629);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.CardIDTextbox);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Popup_window_EmployeeLogin";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.login_window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TextBox CardIDTextbox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button leaveButton;
    }
}