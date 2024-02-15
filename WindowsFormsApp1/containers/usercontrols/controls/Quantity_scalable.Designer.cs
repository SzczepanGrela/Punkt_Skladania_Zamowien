namespace WindowsFormsApp1.containers.usercontrols.controls
{
    partial class Quantity_scalable
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
            this.inStockLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inStockLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inStockLabel.Location = new System.Drawing.Point(0, 34);
            this.inStockLabel.Name = "inStockLabel";
            this.inStockLabel.Size = new System.Drawing.Size(119, 31);
            this.inStockLabel.TabIndex = 30;
            this.inStockLabel.Text = "0 items left in Inventory";
            this.inStockLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quantityPanel
            // 
            this.quantityPanel.ColumnCount = 3;
            this.quantityPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.7074F));
            this.quantityPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.26366F));
            this.quantityPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.02894F));
            this.quantityPanel.Controls.Add(this.increaseQuantityButton, 2, 0);
            this.quantityPanel.Controls.Add(this.decreaseQuantityButton, 0, 0);
            this.quantityPanel.Controls.Add(this.quantityLabel, 1, 0);
            this.quantityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityPanel.Location = new System.Drawing.Point(0, 0);
            this.quantityPanel.Name = "quantityPanel";
            this.quantityPanel.RowCount = 1;
            this.quantityPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.quantityPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.quantityPanel.Size = new System.Drawing.Size(119, 34);
            this.quantityPanel.TabIndex = 31;
            // 
            // increaseQuantityButton
            // 
            this.increaseQuantityButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.increaseQuantityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.increaseQuantityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.increaseQuantityButton.Location = new System.Drawing.Point(81, 0);
            this.increaseQuantityButton.Margin = new System.Windows.Forms.Padding(0);
            this.increaseQuantityButton.Name = "increaseQuantityButton";
            this.increaseQuantityButton.Size = new System.Drawing.Size(38, 34);
            this.increaseQuantityButton.TabIndex = 3;
            this.increaseQuantityButton.Text = "+";
            this.increaseQuantityButton.UseVisualStyleBackColor = false;
            this.increaseQuantityButton.Click += new System.EventHandler(this.increaseQuantityButton_Click);
            // 
            // decreaseQuantityButton
            // 
            this.decreaseQuantityButton.AutoSize = true;
            this.decreaseQuantityButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.decreaseQuantityButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decreaseQuantityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decreaseQuantityButton.Location = new System.Drawing.Point(0, 0);
            this.decreaseQuantityButton.Margin = new System.Windows.Forms.Padding(0);
            this.decreaseQuantityButton.Name = "decreaseQuantityButton";
            this.decreaseQuantityButton.Size = new System.Drawing.Size(36, 34);
            this.decreaseQuantityButton.TabIndex = 2;
            this.decreaseQuantityButton.Text = "-";
            this.decreaseQuantityButton.UseVisualStyleBackColor = false;
            this.decreaseQuantityButton.Click += new System.EventHandler(this.decreaseQuantityButton_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.SystemColors.Info;
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityLabel.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quantityLabel.Location = new System.Drawing.Point(39, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(39, 34);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "1";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quantity_scalable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.quantityPanel);
            this.Controls.Add(this.inStockLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Quantity_scalable";
            this.Size = new System.Drawing.Size(119, 65);
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
