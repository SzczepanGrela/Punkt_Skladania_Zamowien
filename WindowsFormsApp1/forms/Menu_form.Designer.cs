﻿namespace WindowsFormsApp1
{
    partial class MenuForm
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
        public void InitializeComponent()
        {
            this.PresentationButton = new System.Windows.Forms.Button();
            this.ShopButton = new System.Windows.Forms.Button();
            this.MatchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PresentationButton
            // 
            this.PresentationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PresentationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PresentationButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PresentationButton.Location = new System.Drawing.Point(201, 293);
            this.PresentationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PresentationButton.Name = "PresentationButton";
            this.PresentationButton.Size = new System.Drawing.Size(279, 95);
            this.PresentationButton.TabIndex = 1;
            this.PresentationButton.Text = "Free Presentation";
            this.PresentationButton.UseVisualStyleBackColor = true;
            this.PresentationButton.Click += new System.EventHandler(this.PresentationButton_Click);
            // 
            // ShopButton
            // 
            this.ShopButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShopButton.Location = new System.Drawing.Point(201, 156);
            this.ShopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShopButton.Name = "ShopButton";
            this.ShopButton.Size = new System.Drawing.Size(279, 95);
            this.ShopButton.TabIndex = 0;
            this.ShopButton.Text = "I\'m Buying";
            this.ShopButton.UseVisualStyleBackColor = true;
            this.ShopButton.Click += new System.EventHandler(this.ShopButton_Click);
            // 
            // MatchButton
            // 
            this.MatchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MatchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MatchButton.Location = new System.Drawing.Point(201, 440);
            this.MatchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MatchButton.Name = "MatchButton";
            this.MatchButton.Size = new System.Drawing.Size(279, 95);
            this.MatchButton.TabIndex = 2;
            this.MatchButton.Text = "Match a Product";
            this.MatchButton.UseVisualStyleBackColor = true;
            this.MatchButton.Click += new System.EventHandler(this.MatchButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(87, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Innovating your shopping experience!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(121, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Order Hub! ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(665, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MatchButton);
            this.Controls.Add(this.ShopButton);
            this.Controls.Add(this.PresentationButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.Text = "Menu_window";
            this.TransparencyKey = System.Drawing.Color.Gold;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PresentationButton;
        private System.Windows.Forms.Button ShopButton;
        private System.Windows.Forms.Button MatchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}