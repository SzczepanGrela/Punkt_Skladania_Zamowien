namespace WindowsFormsApp1.controls.usercontrols
{
    partial class Finalised_purchase_screen
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
            this.totalPricePanel = new System.Windows.Forms.Panel();
            this.thankyouLabel = new System.Windows.Forms.Label();
            this.seeyouLabel = new System.Windows.Forms.Label();
            this.returnMainButton = new System.Windows.Forms.Button();
            this.totalPricePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalPricePanel
            // 
            this.totalPricePanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.totalPricePanel.Controls.Add(this.thankyouLabel);
            this.totalPricePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.totalPricePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalPricePanel.Location = new System.Drawing.Point(0, 0);
            this.totalPricePanel.Margin = new System.Windows.Forms.Padding(0);
            this.totalPricePanel.Name = "totalPricePanel";
            this.totalPricePanel.Size = new System.Drawing.Size(800, 400);
            this.totalPricePanel.TabIndex = 7;
            // 
            // thankyouLabel
            // 
            this.thankyouLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thankyouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.thankyouLabel.Location = new System.Drawing.Point(0, 0);
            this.thankyouLabel.Margin = new System.Windows.Forms.Padding(0);
            this.thankyouLabel.Name = "thankyouLabel";
            this.thankyouLabel.Size = new System.Drawing.Size(800, 400);
            this.thankyouLabel.TabIndex = 0;
            this.thankyouLabel.Text = "Thank you for your purchase";
            this.thankyouLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seeyouLabel
            // 
            this.seeyouLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seeyouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seeyouLabel.Location = new System.Drawing.Point(0, 400);
            this.seeyouLabel.Margin = new System.Windows.Forms.Padding(0);
            this.seeyouLabel.Name = "seeyouLabel";
            this.seeyouLabel.Size = new System.Drawing.Size(800, 388);
            this.seeyouLabel.TabIndex = 8;
            this.seeyouLabel.Text = "Hope we\'ll see you again!";
            this.seeyouLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnMainButton
            // 
            this.returnMainButton.Location = new System.Drawing.Point(291, 674);
            this.returnMainButton.Name = "returnMainButton";
            this.returnMainButton.Size = new System.Drawing.Size(202, 85);
            this.returnMainButton.TabIndex = 9;
            this.returnMainButton.Text = "return";
            this.returnMainButton.UseVisualStyleBackColor = true;
            this.returnMainButton.Click += new System.EventHandler(this.returnMainButton_Click);
            // 
            // Finalised_purchase_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnMainButton);
            this.Controls.Add(this.seeyouLabel);
            this.Controls.Add(this.totalPricePanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Finalised_purchase_screen";
            this.Size = new System.Drawing.Size(800, 788);
            this.totalPricePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel totalPricePanel;
        private System.Windows.Forms.Label thankyouLabel;
        private System.Windows.Forms.Label seeyouLabel;
        private System.Windows.Forms.Button returnMainButton;
    }
}
