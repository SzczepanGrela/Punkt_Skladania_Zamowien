namespace WindowsFormsApp1.controls.usercontrols
{
    partial class Shopping_cart_screen
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cartPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.needmorePanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.continueSearchButton = new System.Windows.Forms.Button();
            this.totalPricePanel = new System.Windows.Forms.Panel();
            this.priceValueLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.payButton = new System.Windows.Forms.Button();
            this.totalpriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.needmorePanel.SuspendLayout();
            this.totalPricePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cartPanel);
            this.splitContainer1.Panel1.Controls.Add(this.needmorePanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.totalPricePanel);
            this.splitContainer1.Size = new System.Drawing.Size(800, 788);
            this.splitContainer1.SplitterDistance = 663;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // cartPanel
            // 
            this.cartPanel.BackColor = System.Drawing.Color.LightGray;
            this.cartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartPanel.Location = new System.Drawing.Point(0, 96);
            this.cartPanel.Margin = new System.Windows.Forms.Padding(0);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(800, 567);
            this.cartPanel.TabIndex = 2;
            // 
            // needmorePanel
            // 
            this.needmorePanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.needmorePanel.Controls.Add(this.clearButton);
            this.needmorePanel.Controls.Add(this.continueSearchButton);
            this.needmorePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.needmorePanel.Location = new System.Drawing.Point(0, 0);
            this.needmorePanel.Margin = new System.Windows.Forms.Padding(0);
            this.needmorePanel.Name = "needmorePanel";
            this.needmorePanel.Size = new System.Drawing.Size(800, 96);
            this.needmorePanel.TabIndex = 1;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.Location = new System.Drawing.Point(516, 15);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(255, 64);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear Cart";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // continueSearchButton
            // 
            this.continueSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.continueSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.continueSearchButton.Location = new System.Drawing.Point(24, 15);
            this.continueSearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.continueSearchButton.Name = "continueSearchButton";
            this.continueSearchButton.Size = new System.Drawing.Size(339, 64);
            this.continueSearchButton.TabIndex = 0;
            this.continueSearchButton.Text = "Continue Search";
            this.continueSearchButton.UseVisualStyleBackColor = true;
            this.continueSearchButton.Click += new System.EventHandler(this.continueSearchButton_Click);
            // 
            // totalPricePanel
            // 
            this.totalPricePanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.totalPricePanel.Controls.Add(this.priceValueLabel);
            this.totalPricePanel.Controls.Add(this.panel1);
            this.totalPricePanel.Controls.Add(this.totalpriceLabel);
            this.totalPricePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPricePanel.Location = new System.Drawing.Point(0, 0);
            this.totalPricePanel.Margin = new System.Windows.Forms.Padding(0);
            this.totalPricePanel.Name = "totalPricePanel";
            this.totalPricePanel.Size = new System.Drawing.Size(800, 120);
            this.totalPricePanel.TabIndex = 0;
            // 
            // priceValueLabel
            // 
            this.priceValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceValueLabel.Location = new System.Drawing.Point(272, 0);
            this.priceValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceValueLabel.Name = "priceValueLabel";
            this.priceValueLabel.Size = new System.Drawing.Size(244, 120);
            this.priceValueLabel.TabIndex = 0;
            this.priceValueLabel.Text = "0zł";
            this.priceValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.payButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(516, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 120);
            this.panel1.TabIndex = 1;
            // 
            // payButton
            // 
            this.payButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.payButton.Location = new System.Drawing.Point(48, 38);
            this.payButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(207, 50);
            this.payButton.TabIndex = 0;
            this.payButton.Text = "PAY";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // totalpriceLabel
            // 
            this.totalpriceLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.totalpriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalpriceLabel.Location = new System.Drawing.Point(0, 0);
            this.totalpriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalpriceLabel.Name = "totalpriceLabel";
            this.totalpriceLabel.Size = new System.Drawing.Size(272, 120);
            this.totalpriceLabel.TabIndex = 1;
            this.totalpriceLabel.Text = "Your total price: ";
            this.totalpriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Shopping_cart_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Shopping_cart_screen";
            this.Size = new System.Drawing.Size(800, 788);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.needmorePanel.ResumeLayout(false);
            this.totalPricePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel totalPricePanel;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label totalpriceLabel;
        private System.Windows.Forms.Label priceValueLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel cartPanel;
        private System.Windows.Forms.Panel needmorePanel;
        private System.Windows.Forms.Button continueSearchButton;
        private System.Windows.Forms.Button clearButton;
    }
}
