namespace WindowsFormsApp1.usercontrols
{
    partial class Menu_screen
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
            this.UpperTextLabel = new System.Windows.Forms.Label();
            this.BottomTextLabel = new System.Windows.Forms.Label();
            this.MatchButton = new System.Windows.Forms.Button();
            this.ShopButton = new System.Windows.Forms.Button();
            this.PresentationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpperTextLabel
            // 
            this.UpperTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpperTextLabel.AutoSize = true;
            this.UpperTextLabel.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpperTextLabel.Location = new System.Drawing.Point(79, 24);
            this.UpperTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.UpperTextLabel.Name = "UpperTextLabel";
            this.UpperTextLabel.Size = new System.Drawing.Size(362, 40);
            this.UpperTextLabel.TabIndex = 8;
            this.UpperTextLabel.Text = "Welcome to Order Hub! ";
            // 
            // BottomTextLabel
            // 
            this.BottomTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BottomTextLabel.AutoSize = true;
            this.BottomTextLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BottomTextLabel.Location = new System.Drawing.Point(69, 76);
            this.BottomTextLabel.Name = "BottomTextLabel";
            this.BottomTextLabel.Size = new System.Drawing.Size(372, 26);
            this.BottomTextLabel.TabIndex = 9;
            this.BottomTextLabel.Text = "Innovating your shopping experience!";
            // 
            // MatchButton
            // 
            this.MatchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MatchButton.Location = new System.Drawing.Point(132, 425);
            this.MatchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MatchButton.Name = "MatchButton";
            this.MatchButton.Size = new System.Drawing.Size(245, 86);
            this.MatchButton.TabIndex = 7;
            this.MatchButton.Text = "Match a Product";
            this.MatchButton.UseVisualStyleBackColor = true;
            // 
            // ShopButton
            // 
            this.ShopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShopButton.Location = new System.Drawing.Point(132, 153);
            this.ShopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShopButton.Name = "ShopButton";
            this.ShopButton.Size = new System.Drawing.Size(245, 86);
            this.ShopButton.TabIndex = 5;
            this.ShopButton.Text = "I\'m Buying";
            this.ShopButton.UseVisualStyleBackColor = true;
            this.ShopButton.Click += new System.EventHandler(this.ShopButton_Click);
            // 
            // PresentationButton
            // 
            this.PresentationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PresentationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PresentationButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PresentationButton.Location = new System.Drawing.Point(132, 291);
            this.PresentationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PresentationButton.Name = "PresentationButton";
            this.PresentationButton.Size = new System.Drawing.Size(245, 86);
            this.PresentationButton.TabIndex = 6;
            this.PresentationButton.Text = "Free Presentation";
            this.PresentationButton.UseVisualStyleBackColor = true;
            this.PresentationButton.Click += new System.EventHandler(this.PresentationButton_Click);
            // 
            // Menu_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.UpperTextLabel);
            this.Controls.Add(this.BottomTextLabel);
            this.Controls.Add(this.MatchButton);
            this.Controls.Add(this.ShopButton);
            this.Controls.Add(this.PresentationButton);
            this.Name = "Menu_screen";
            this.Size = new System.Drawing.Size(500, 540);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpperTextLabel;
        private System.Windows.Forms.Label BottomTextLabel;
        private System.Windows.Forms.Button MatchButton;
        private System.Windows.Forms.Button ShopButton;
        private System.Windows.Forms.Button PresentationButton;
    }
}
