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
            this.cartButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.MainPanel = new WindowsFormsApp1.containers.usercontrols.MainPanel_screen();
            this.TopBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.Moccasin;
            this.TopBarPanel.Controls.Add(this.cartButton);
            this.TopBarPanel.Controls.Add(this.HomeButton);
            this.TopBarPanel.Controls.Add(this.LogInButton);
            this.TopBarPanel.Controls.Add(this.ReturnButton);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(596, 77);
            this.TopBarPanel.TabIndex = 7;
            this.TopBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopBarPanel_Paint);
            // 
            // cartButton
            // 
            this.cartButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cartButton.BackColor = System.Drawing.Color.BurlyWood;
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cartButton.Image = ((System.Drawing.Image)(resources.GetObject("cartButton.Image")));
            this.cartButton.Location = new System.Drawing.Point(458, 12);
            this.cartButton.Margin = new System.Windows.Forms.Padding(0);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(59, 54);
            this.cartButton.TabIndex = 7;
            this.cartButton.UseVisualStyleBackColor = false;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomeButton.BackColor = System.Drawing.Color.BurlyWood;
            this.HomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeButton.BackgroundImage")));
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeButton.Location = new System.Drawing.Point(271, 12);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(59, 54);
            this.HomeButton.TabIndex = 8;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(HomeButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LogInButton.BackColor = System.Drawing.Color.BurlyWood;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogInButton.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInButton.Image = ((System.Drawing.Image)(resources.GetObject("LogInButton.Image")));
            this.LogInButton.Location = new System.Drawing.Point(533, 11);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(52, 54);
            this.LogInButton.TabIndex = 7;
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReturnButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReturnButton.Location = new System.Drawing.Point(9, 18);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(49, 43);
            this.ReturnButton.TabIndex = 6;
            this.ReturnButton.Text = "< ";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(ReturnButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 77);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(596, 733);
            this.MainPanel.TabIndex = 9;
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(596, 810);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopBarPanel);
            this.Name = "Main_window";
            this.Text = "Order Hub";
            this.TopBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button cartButton;
        private containers.usercontrols.MainPanel_screen MainPanel;
    }
}