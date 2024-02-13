namespace WindowsFormsApp1.controls.usercontrols
{
    partial class Payment_method_screen
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
            this.giftcardTextbox = new System.Windows.Forms.TextBox();
            this.enterCodeLabel = new System.Windows.Forms.Label();
            this.checkCodeButton = new System.Windows.Forms.Button();
            this.totalPricePanel = new System.Windows.Forms.Panel();
            this.priceValueLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.discountCodeTextbox = new System.Windows.Forms.TextBox();
            this.discountButton = new System.Windows.Forms.Button();
            this.totalpriceLabel = new System.Windows.Forms.Label();
            this.totalPricePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // giftcardTextbox
            // 
            this.giftcardTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.giftcardTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.giftcardTextbox.Location = new System.Drawing.Point(317, 405);
            this.giftcardTextbox.Name = "giftcardTextbox";
            this.giftcardTextbox.Size = new System.Drawing.Size(246, 38);
            this.giftcardTextbox.TabIndex = 0;
            // 
            // enterCodeLabel
            // 
            this.enterCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.enterCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enterCodeLabel.Location = new System.Drawing.Point(31, 405);
            this.enterCodeLabel.Name = "enterCodeLabel";
            this.enterCodeLabel.Size = new System.Drawing.Size(257, 31);
            this.enterCodeLabel.TabIndex = 1;
            this.enterCodeLabel.Text = "Enter gift card code:";
            this.enterCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkCodeButton
            // 
            this.checkCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkCodeButton.Location = new System.Drawing.Point(227, 503);
            this.checkCodeButton.Name = "checkCodeButton";
            this.checkCodeButton.Size = new System.Drawing.Size(148, 53);
            this.checkCodeButton.TabIndex = 2;
            this.checkCodeButton.Text = "Enter";
            this.checkCodeButton.UseVisualStyleBackColor = true;
            // 
            // totalPricePanel
            // 
            this.totalPricePanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.totalPricePanel.Controls.Add(this.priceValueLabel);
            this.totalPricePanel.Controls.Add(this.panel1);
            this.totalPricePanel.Controls.Add(this.totalpriceLabel);
            this.totalPricePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.totalPricePanel.Location = new System.Drawing.Point(0, 0);
            this.totalPricePanel.Margin = new System.Windows.Forms.Padding(0);
            this.totalPricePanel.Name = "totalPricePanel";
            this.totalPricePanel.Size = new System.Drawing.Size(600, 182);
            this.totalPricePanel.TabIndex = 3;
            // 
            // priceValueLabel
            // 
            this.priceValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceValueLabel.Location = new System.Drawing.Point(207, 0);
            this.priceValueLabel.Name = "priceValueLabel";
            this.priceValueLabel.Size = new System.Drawing.Size(171, 182);
            this.priceValueLabel.TabIndex = 0;
            this.priceValueLabel.Text = "0zł";
            this.priceValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.discountCodeTextbox);
            this.panel1.Controls.Add(this.discountButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(378, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 182);
            this.panel1.TabIndex = 1;
            // 
            // discountCodeTextbox
            // 
            this.discountCodeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.discountCodeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.discountCodeTextbox.Location = new System.Drawing.Point(14, 61);
            this.discountCodeTextbox.Name = "discountCodeTextbox";
            this.discountCodeTextbox.Size = new System.Drawing.Size(197, 38);
            this.discountCodeTextbox.TabIndex = 1;
            // 
            // discountButton
            // 
            this.discountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.discountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.discountButton.Location = new System.Drawing.Point(47, 124);
            this.discountButton.Name = "discountButton";
            this.discountButton.Size = new System.Drawing.Size(138, 37);
            this.discountButton.TabIndex = 0;
            this.discountButton.Text = "PAY";
            this.discountButton.UseVisualStyleBackColor = true;
            this.discountButton.Click += new System.EventHandler(this.discountButton_Click);
            // 
            // totalpriceLabel
            // 
            this.totalpriceLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.totalpriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalpriceLabel.Location = new System.Drawing.Point(0, 0);
            this.totalpriceLabel.Name = "totalpriceLabel";
            this.totalpriceLabel.Size = new System.Drawing.Size(207, 182);
            this.totalpriceLabel.TabIndex = 1;
            this.totalpriceLabel.Text = "Your total price: ";
            this.totalpriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Payment_method_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.totalPricePanel);
            this.Controls.Add(this.checkCodeButton);
            this.Controls.Add(this.enterCodeLabel);
            this.Controls.Add(this.giftcardTextbox);
            this.Name = "Payment_method_screen";
            this.Size = new System.Drawing.Size(600, 640);
            this.totalPricePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox giftcardTextbox;
        private System.Windows.Forms.Label enterCodeLabel;
        private System.Windows.Forms.Button checkCodeButton;
        private System.Windows.Forms.Panel totalPricePanel;
        private System.Windows.Forms.Label priceValueLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox discountCodeTextbox;
        private System.Windows.Forms.Button discountButton;
        private System.Windows.Forms.Label totalpriceLabel;
    }
}
