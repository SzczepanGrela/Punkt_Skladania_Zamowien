namespace WindowsFormsApp1.controls.usercontrols
{
    partial class Testing_cart_screen
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
            this.ReadyLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderTestButton = new System.Windows.Forms.Button();
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
            this.splitContainer1.Size = new System.Drawing.Size(596, 733);
            this.splitContainer1.SplitterDistance = 616;
            this.splitContainer1.TabIndex = 1;
            // 
            // cartPanel
            // 
            this.cartPanel.AutoScroll = true;
            this.cartPanel.BackColor = System.Drawing.Color.LightGray;
            this.cartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartPanel.Location = new System.Drawing.Point(0, 78);
            this.cartPanel.Margin = new System.Windows.Forms.Padding(0);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(596, 538);
            this.cartPanel.TabIndex = 5;
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
            this.needmorePanel.Size = new System.Drawing.Size(596, 78);
            this.needmorePanel.TabIndex = 2;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.Location = new System.Drawing.Point(387, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(191, 52);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear Cart";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // continueSearchButton
            // 
            this.continueSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.continueSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.continueSearchButton.Location = new System.Drawing.Point(18, 12);
            this.continueSearchButton.Name = "continueSearchButton";
            this.continueSearchButton.Size = new System.Drawing.Size(250, 52);
            this.continueSearchButton.TabIndex = 0;
            this.continueSearchButton.Text = "Continue Search";
            this.continueSearchButton.UseVisualStyleBackColor = true;
            this.continueSearchButton.Click += new System.EventHandler(this.continueSearchButton_Click);
            // 
            // totalPricePanel
            // 
            this.totalPricePanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.totalPricePanel.Controls.Add(this.ReadyLabel);
            this.totalPricePanel.Controls.Add(this.panel1);
            this.totalPricePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPricePanel.Location = new System.Drawing.Point(0, 0);
            this.totalPricePanel.Margin = new System.Windows.Forms.Padding(0);
            this.totalPricePanel.Name = "totalPricePanel";
            this.totalPricePanel.Size = new System.Drawing.Size(596, 113);
            this.totalPricePanel.TabIndex = 0;
            // 
            // ReadyLabel
            // 
            this.ReadyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReadyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReadyLabel.Location = new System.Drawing.Point(0, 0);
            this.ReadyLabel.Name = "ReadyLabel";
            this.ReadyLabel.Size = new System.Drawing.Size(383, 113);
            this.ReadyLabel.TabIndex = 2;
            this.ReadyLabel.Text = "Ready for test?";
            this.ReadyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderTestButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(383, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 113);
            this.panel1.TabIndex = 1;
            // 
            // orderTestButton
            // 
            this.orderTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderTestButton.Location = new System.Drawing.Point(36, 30);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(155, 56);
            this.orderTestButton.TabIndex = 0;
            this.orderTestButton.Text = "ORDER";
            this.orderTestButton.UseVisualStyleBackColor = true;
            this.orderTestButton.Click += new System.EventHandler(this.orderTestButton_Click);
            // 
            // Testing_cart_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Testing_cart_screen";
            this.Size = new System.Drawing.Size(596, 733);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button orderTestButton;
        private System.Windows.Forms.Panel needmorePanel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button continueSearchButton;
        private System.Windows.Forms.Label ReadyLabel;
        private System.Windows.Forms.FlowLayoutPanel cartPanel;
    }
}
