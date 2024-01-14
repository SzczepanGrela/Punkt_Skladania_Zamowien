using System.Configuration;
namespace WindowsFormsApp1
{
    partial class Main_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_window));
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            MainPanel = new System.Windows.Forms.Panel();
            this.TopBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.Moccasin;
            this.TopBarPanel.Controls.Add(this.HomeButton);
            this.TopBarPanel.Controls.Add(this.LogInButton);
            this.TopBarPanel.Controls.Add(this.ReturnButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(682, 87);
            this.TopBarPanel.TabIndex = 7;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.BurlyWood;
            this.HomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeButton.BackgroundImage")));
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeButton.Location = new System.Drawing.Point(296, 11);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(79, 66);
            this.HomeButton.TabIndex = 8;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.BurlyWood;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogInButton.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInButton.Location = new System.Drawing.Point(552, 13);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(127, 58);
            this.LogInButton.TabIndex = 7;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReturnButton.Location = new System.Drawing.Point(9, 18);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(51, 53);
            this.ReturnButton.TabIndex = 6;
            this.ReturnButton.Text = "< ";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // MainPanel
            // 
            MainPanel.BackColor = System.Drawing.SystemColors.Control;
            MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            MainPanel.Location = new System.Drawing.Point(0, 87);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new System.Drawing.Size(682, 766);
            MainPanel.TabIndex = 8;
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 853);
            this.Controls.Add(MainPanel);
            this.Controls.Add(this.TopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main_window";
            this.Text = "Order Hub";
            this.TopBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button LogInButton;
        public static System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button HomeButton;
    }
}