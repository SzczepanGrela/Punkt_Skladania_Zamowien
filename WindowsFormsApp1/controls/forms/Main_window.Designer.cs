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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BottomBarPanel = new System.Windows.Forms.Panel();
            this.EmployeeAccessButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TopBarPanel.SuspendLayout();
            this.BottomBarPanel.SuspendLayout();
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
            this.TopBarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(596, 82);
            this.TopBarPanel.TabIndex = 7;
            this.TopBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopBarPanel_Paint);
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomeButton.BackColor = System.Drawing.Color.BurlyWood;
            this.HomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeButton.BackgroundImage")));
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeButton.Location = new System.Drawing.Point(264, 15);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(59, 54);
            this.HomeButton.TabIndex = 8;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LogInButton.BackColor = System.Drawing.Color.BurlyWood;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogInButton.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInButton.Location = new System.Drawing.Point(498, 17);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(95, 47);
            this.LogInButton.TabIndex = 7;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReturnButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReturnButton.Location = new System.Drawing.Point(9, 21);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(38, 43);
            this.ReturnButton.TabIndex = 6;
            this.ReturnButton.Text = "< ";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.DimGray;
            this.MainPanel.Location = new System.Drawing.Point(0, 86);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(596, 638);
            this.MainPanel.TabIndex = 8;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // BottomBarPanel
            // 
            this.BottomBarPanel.BackColor = System.Drawing.Color.Moccasin;
            this.BottomBarPanel.Controls.Add(this.EmployeeAccessButton);
            this.BottomBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBarPanel.Location = new System.Drawing.Point(0, 728);
            this.BottomBarPanel.Margin = new System.Windows.Forms.Padding(2);
            this.BottomBarPanel.Name = "BottomBarPanel";
            this.BottomBarPanel.Size = new System.Drawing.Size(596, 82);
            this.BottomBarPanel.TabIndex = 8;
            // 
            // EmployeeAccessButton
            // 
            this.EmployeeAccessButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmployeeAccessButton.BackColor = System.Drawing.Color.BurlyWood;
            this.EmployeeAccessButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmployeeAccessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmployeeAccessButton.Location = new System.Drawing.Point(9, 21);
            this.EmployeeAccessButton.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeAccessButton.Name = "EmployeeAccessButton";
            this.EmployeeAccessButton.Size = new System.Drawing.Size(38, 43);
            this.EmployeeAccessButton.TabIndex = 6;
            this.EmployeeAccessButton.Text = "E";
            this.EmployeeAccessButton.UseVisualStyleBackColor = false;
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(596, 810);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BottomBarPanel);
            this.Controls.Add(this.TopBarPanel);
            this.Name = "Main_window";
            this.Text = "Order Hub";
            this.TopBarPanel.ResumeLayout(false);
            this.BottomBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button HomeButton;
        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel BottomBarPanel;
        private System.Windows.Forms.Button EmployeeAccessButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}