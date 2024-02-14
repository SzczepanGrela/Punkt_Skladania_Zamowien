namespace WindowsFormsApp1.controls.forms
{
    partial class Popup_window_yn
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.yesnoSplit = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.yesnoSplit)).BeginInit();
            this.yesnoSplit.Panel1.SuspendLayout();
            this.yesnoSplit.Panel2.SuspendLayout();
            this.yesnoSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessageLabel.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MessageLabel.Location = new System.Drawing.Point(0, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(480, 175);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = "Message";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.YesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YesButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YesButton.Location = new System.Drawing.Point(25, 25);
            this.YesButton.Margin = new System.Windows.Forms.Padding(0);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(183, 75);
            this.YesButton.TabIndex = 3;
            this.YesButton.Text = "YES";
            this.YesButton.UseVisualStyleBackColor = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NoButton.Location = new System.Drawing.Point(25, 25);
            this.NoButton.Margin = new System.Windows.Forms.Padding(30);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(193, 75);
            this.NoButton.TabIndex = 4;
            this.NoButton.Text = "NO";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // yesnoSplit
            // 
            this.yesnoSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yesnoSplit.Location = new System.Drawing.Point(0, 175);
            this.yesnoSplit.Name = "yesnoSplit";
            // 
            // yesnoSplit.Panel1
            // 
            this.yesnoSplit.Panel1.Controls.Add(this.YesButton);
            this.yesnoSplit.Panel1.Padding = new System.Windows.Forms.Padding(25);
            // 
            // yesnoSplit.Panel2
            // 
            this.yesnoSplit.Panel2.Controls.Add(this.NoButton);
            this.yesnoSplit.Panel2.Padding = new System.Windows.Forms.Padding(25);
            this.yesnoSplit.Size = new System.Drawing.Size(480, 125);
            this.yesnoSplit.SplitterDistance = 233;
            this.yesnoSplit.TabIndex = 5;
            // 
            // Popup_window_yn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.yesnoSplit);
            this.Controls.Add(this.MessageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Popup_window_yn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Popup_window_yn";
            this.TopMost = true;
            this.yesnoSplit.Panel1.ResumeLayout(false);
            this.yesnoSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yesnoSplit)).EndInit();
            this.yesnoSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.SplitContainer yesnoSplit;
    }
}