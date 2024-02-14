namespace WindowsFormsApp1.controls.usercontrols
{
    partial class Test_decision_screen
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
            this.cartPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.needmorePanel = new System.Windows.Forms.Panel();
            this.continueSearchButton = new System.Windows.Forms.Button();
            this.totalPricePanel = new System.Windows.Forms.Panel();
            this.DecisionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
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
            // cartPanel
            // 
            this.cartPanel.BackColor = System.Drawing.Color.LightGray;
            this.cartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartPanel.Location = new System.Drawing.Point(0, 96);
            this.cartPanel.Margin = new System.Windows.Forms.Padding(0);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(800, 520);
            this.cartPanel.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer1.SplitterDistance = 616;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // needmorePanel
            // 
            this.needmorePanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.needmorePanel.Controls.Add(this.continueSearchButton);
            this.needmorePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.needmorePanel.Location = new System.Drawing.Point(0, 0);
            this.needmorePanel.Margin = new System.Windows.Forms.Padding(0);
            this.needmorePanel.Name = "needmorePanel";
            this.needmorePanel.Size = new System.Drawing.Size(800, 96);
            this.needmorePanel.TabIndex = 2;
            // 
            // continueSearchButton
            // 
            this.continueSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.continueSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.continueSearchButton.Location = new System.Drawing.Point(24, 15);
            this.continueSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.continueSearchButton.Name = "continueSearchButton";
            this.continueSearchButton.Size = new System.Drawing.Size(331, 64);
            this.continueSearchButton.TabIndex = 0;
            this.continueSearchButton.Text = "Continue Search";
            this.continueSearchButton.UseVisualStyleBackColor = true;
            // 
            // totalPricePanel
            // 
            this.totalPricePanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.totalPricePanel.Controls.Add(this.DecisionLabel);
            this.totalPricePanel.Controls.Add(this.panel1);
            this.totalPricePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPricePanel.Location = new System.Drawing.Point(0, 0);
            this.totalPricePanel.Margin = new System.Windows.Forms.Padding(0);
            this.totalPricePanel.Name = "totalPricePanel";
            this.totalPricePanel.Size = new System.Drawing.Size(800, 167);
            this.totalPricePanel.TabIndex = 0;
            // 
            // DecisionLabel
            // 
            this.DecisionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DecisionLabel.Location = new System.Drawing.Point(0, 0);
            this.DecisionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DecisionLabel.Name = "DecisionLabel";
            this.DecisionLabel.Size = new System.Drawing.Size(516, 167);
            this.DecisionLabel.TabIndex = 2;
            this.DecisionLabel.Text = "Would you be interested in buying some of these items?";
            this.DecisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.orderTestButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(516, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 167);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(20, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "No, thank you";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // orderTestButton
            // 
            this.orderTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderTestButton.Location = new System.Drawing.Point(20, 18);
            this.orderTestButton.Margin = new System.Windows.Forms.Padding(4);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(247, 66);
            this.orderTestButton.TabIndex = 0;
            this.orderTestButton.Text = "Buy selected";
            this.orderTestButton.UseVisualStyleBackColor = true;
            // 
            // Test_decision_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Test_decision_screen";
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

        private System.Windows.Forms.FlowLayoutPanel cartPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel needmorePanel;
        private System.Windows.Forms.Button continueSearchButton;
        private System.Windows.Forms.Panel totalPricePanel;
        private System.Windows.Forms.Label DecisionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button orderTestButton;
    }
}
