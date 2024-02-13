namespace WindowsFormsApp1.containers.usercontrols.controls
{
    partial class Quantity_panel
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
            this.inStockLabel = new System.Windows.Forms.Label();
            this.quantityPanel = new System.Windows.Forms.TableLayoutPanel();
            this.increaseQuantityButton = new System.Windows.Forms.Button();
            this.decreaseQuantityButton = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inStockLabel
            // 
            this.inStockLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inStockLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inStockLabel.Location = new System.Drawing.Point(0, 48);
            this.inStockLabel.Name = "inStockLabel";
            this.inStockLabel.Size = new System.Drawing.Size(184, 22);
            this.inStockLabel.TabIndex = 13;
            this.inStockLabel.Text = "0 items left in Inventory";
            this.inStockLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quantityPanel
            // 
            this.quantityPanel.ColumnCount = 3;
            this.quantityPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.quantityPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.quantityPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.quantityPanel.Controls.Add(this.increaseQuantityButton, 2, 0);
            this.quantityPanel.Controls.Add(this.decreaseQuantityButton, 0, 0);
            this.quantityPanel.Controls.Add(this.quantityLabel, 1, 0);
            this.quantityPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.quantityPanel.Location = new System.Drawing.Point(0, 0);
            this.quantityPanel.Name = "quantityPanel";
            this.quantityPanel.RowCount = 1;
            this.quantityPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.quantityPanel.Size = new System.Drawing.Size(184, 48);
            this.quantityPanel.TabIndex = 12;
            // 
            // increaseQuantityButton
            // 
            this.increaseQuantityButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.increaseQuantityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.increaseQuantityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.increaseQuantityButton.Location = new System.Drawing.Point(141, 3);
            this.increaseQuantityButton.Name = "increaseQuantityButton";
            this.increaseQuantityButton.Size = new System.Drawing.Size(40, 42);
            this.increaseQuantityButton.TabIndex = 3;
            this.increaseQuantityButton.Text = "+";
            this.increaseQuantityButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.increaseQuantityButton.UseVisualStyleBackColor = false;
            this.increaseQuantityButton.Click += new System.EventHandler(this.increaseQuantityButton_Click);
            // 
            // decreaseQuantityButton
            // 
            this.decreaseQuantityButton.AutoSize = true;
            this.decreaseQuantityButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.decreaseQuantityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decreaseQuantityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decreaseQuantityButton.Location = new System.Drawing.Point(3, 3);
            this.decreaseQuantityButton.Name = "decreaseQuantityButton";
            this.decreaseQuantityButton.Size = new System.Drawing.Size(40, 42);
            this.decreaseQuantityButton.TabIndex = 2;
            this.decreaseQuantityButton.Text = "-";
            this.decreaseQuantityButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.decreaseQuantityButton.UseVisualStyleBackColor = false;
            this.decreaseQuantityButton.Click += new System.EventHandler(this.decreaseQuantityButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.SystemColors.Info;
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityLabel.Font = new System.Drawing.Font("Impact", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quantityLabel.Location = new System.Drawing.Point(49, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(86, 48);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "1";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quantity_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inStockLabel);
            this.Controls.Add(this.quantityPanel);
            this.Name = "Quantity_panel";
            this.Size = new System.Drawing.Size(184, 70);
            this.Load += new System.EventHandler(this.Quantity_panel_Load);
            this.quantityPanel.ResumeLayout(false);
            this.quantityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label inStockLabel;
        private System.Windows.Forms.TableLayoutPanel quantityPanel;
        private System.Windows.Forms.Button increaseQuantityButton;
        private System.Windows.Forms.Button decreaseQuantityButton;
        private System.Windows.Forms.Label quantityLabel;
    }
}
