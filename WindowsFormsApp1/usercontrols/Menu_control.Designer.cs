namespace WindowsFormsApp1.usercontrols
{
    partial class Menu_control
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MatchButton = new System.Windows.Forms.Button();
            this.ShopButton = new System.Windows.Forms.Button();
            this.PresentationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(93, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome to Order Hub! ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(72, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Innovating your shopping experience!";
            // 
            // MatchButton
            // 
            this.MatchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MatchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MatchButton.Location = new System.Drawing.Point(135, 393);
            this.MatchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MatchButton.Name = "MatchButton";
            this.MatchButton.Size = new System.Drawing.Size(242, 86);
            this.MatchButton.TabIndex = 7;
            this.MatchButton.Text = "Match a Product";
            this.MatchButton.UseVisualStyleBackColor = true;
            // 
            // ShopButton
            // 
            this.ShopButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShopButton.Location = new System.Drawing.Point(135, 131);
            this.ShopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShopButton.Name = "ShopButton";
            this.ShopButton.Size = new System.Drawing.Size(242, 86);
            this.ShopButton.TabIndex = 5;
            this.ShopButton.Text = "I\'m Buying";
            this.ShopButton.UseVisualStyleBackColor = true;
            this.ShopButton.Click += new System.EventHandler(this.ShopButton_Click);
            // 
            // PresentationButton
            // 
            this.PresentationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PresentationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PresentationButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PresentationButton.Location = new System.Drawing.Point(135, 263);
            this.PresentationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PresentationButton.Name = "PresentationButton";
            this.PresentationButton.Size = new System.Drawing.Size(242, 86);
            this.PresentationButton.TabIndex = 6;
            this.PresentationButton.Text = "Free Presentation";
            this.PresentationButton.UseVisualStyleBackColor = true;
            // 
            // Menu_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MatchButton);
            this.Controls.Add(this.ShopButton);
            this.Controls.Add(this.PresentationButton);
            this.Name = "Menu_control";
            this.Size = new System.Drawing.Size(512, 521);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MatchButton;
        private System.Windows.Forms.Button ShopButton;
        private System.Windows.Forms.Button PresentationButton;
    }
}
