namespace WindowsFormsApp1.controls.usercontrols
{
    partial class Items_list_screen
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
            this.filtersItemsSplit = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.filtersItemsSplit)).BeginInit();
            this.filtersItemsSplit.Panel1.SuspendLayout();
            this.filtersItemsSplit.Panel2.SuspendLayout();
            this.filtersItemsSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtersItemsSplit
            // 
            this.filtersItemsSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtersItemsSplit.Location = new System.Drawing.Point(0, 0);
            this.filtersItemsSplit.Name = "filtersItemsSplit";
            this.filtersItemsSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // filtersItemsSplit.Panel1
            // 
            this.filtersItemsSplit.Panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.filtersItemsSplit.Panel1.Controls.Add(this.label1);
            // 
            // filtersItemsSplit.Panel2
            // 
            this.filtersItemsSplit.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.filtersItemsSplit.Panel2.Controls.Add(this.itemsPanel);
            this.filtersItemsSplit.Size = new System.Drawing.Size(600, 640);
            this.filtersItemsSplit.SplitterDistance = 125;
            this.filtersItemsSplit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 125);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILTERS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // itemsPanel
            // 
            this.itemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsPanel.Location = new System.Drawing.Point(0, 0);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(600, 511);
            this.itemsPanel.TabIndex = 0;
            // 
            // Items_list_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filtersItemsSplit);
            this.Name = "Items_list_screen";
            this.Size = new System.Drawing.Size(600, 640);
            this.filtersItemsSplit.Panel1.ResumeLayout(false);
            this.filtersItemsSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filtersItemsSplit)).EndInit();
            this.filtersItemsSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer filtersItemsSplit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel itemsPanel;
    }
}
