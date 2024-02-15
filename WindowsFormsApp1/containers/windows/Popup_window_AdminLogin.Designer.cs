namespace WindowsFormsApp1.containers.windows
{
    partial class Popup_window_AdminLogin
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.leaveButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.CardIDTextbox = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // leaveButton
            // 
            this.leaveButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leaveButton.Location = new System.Drawing.Point(227, 455);
            this.leaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(101, 45);
            this.leaveButton.TabIndex = 11;
            this.leaveButton.Text = "Cancel";
            this.leaveButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.Location = new System.Drawing.Point(186, 349);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(181, 92);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Enter";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // CardIDTextbox
            // 
            this.CardIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CardIDTextbox.Location = new System.Drawing.Point(67, 189);
            this.CardIDTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.CardIDTextbox.Name = "CardIDTextbox";
            this.CardIDTextbox.Size = new System.Drawing.Size(420, 45);
            this.CardIDTextbox.TabIndex = 9;
            this.CardIDTextbox.UseSystemPasswordChar = true;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("SimSun-ExtB", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(157, 37);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(248, 40);
            this.welcomeLabel.TabIndex = 8;
            this.welcomeLabel.Text = "Admin panel";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTextbox.Location = new System.Drawing.Point(67, 288);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(420, 45);
            this.PasswordTextbox.TabIndex = 12;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // Popup_window_AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.CardIDTextbox);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Popup_window_AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox CardIDTextbox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TextBox PasswordTextbox;
    }
}
