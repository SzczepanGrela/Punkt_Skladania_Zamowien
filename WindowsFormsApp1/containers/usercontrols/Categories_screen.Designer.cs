namespace WindowsFormsApp1.controls.usercontrols
{
    partial class Categories_screen
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
            this.lookinforLabel = new System.Windows.Forms.Label();
            this.categoriesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lookinforLabel
            // 
            this.lookinforLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lookinforLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lookinforLabel.Location = new System.Drawing.Point(0, 0);
            this.lookinforLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lookinforLabel.Name = "lookinforLabel";
            this.lookinforLabel.Size = new System.Drawing.Size(800, 204);
            this.lookinforLabel.TabIndex = 1;
            this.lookinforLabel.Text = "What are you looking for?";
            this.lookinforLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lookinforLabel.Click += new System.EventHandler(this.lookinforLabel_Click);
            // 
            // categoriesPanel
            // 
            this.categoriesPanel.AutoScroll = true;
            this.categoriesPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.categoriesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesPanel.Location = new System.Drawing.Point(0, 204);
            this.categoriesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.categoriesPanel.Name = "categoriesPanel";
            this.categoriesPanel.Size = new System.Drawing.Size(800, 584);
            this.categoriesPanel.TabIndex = 2;
            // 
            // Categories_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categoriesPanel);
            this.Controls.Add(this.lookinforLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Categories_screen";
            this.Size = new System.Drawing.Size(800, 788);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lookinforLabel;
        private System.Windows.Forms.FlowLayoutPanel categoriesPanel;
    }
}
