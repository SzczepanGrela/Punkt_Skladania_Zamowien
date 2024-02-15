namespace WindowsFormsApp1.controls.usercontrols
{
    partial class Product_details_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_details_screen));
            this.decisionChangeSplit = new System.Windows.Forms.SplitContainer();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.imageAndDataPanel = new System.Windows.Forms.Panel();
            this.imageDataSplit = new System.Windows.Forms.SplitContainer();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.PriceBuyingSplit = new System.Windows.Forms.SplitContainer();
            this.priceLabel = new System.Windows.Forms.Label();
            this.buyingQuantitySplit = new System.Windows.Forms.SplitContainer();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.CartButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.ChangeLabelChangeButtonSplit = new System.Windows.Forms.SplitContainer();
            this.ChangeOfHeartLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.quantity_panel = new WindowsFormsApp1.containers.usercontrols.controls.Quantity_scalable();
            ((System.ComponentModel.ISupportInitialize)(this.decisionChangeSplit)).BeginInit();
            this.decisionChangeSplit.Panel1.SuspendLayout();
            this.decisionChangeSplit.Panel2.SuspendLayout();
            this.decisionChangeSplit.SuspendLayout();
            this.imageAndDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataSplit)).BeginInit();
            this.imageDataSplit.Panel1.SuspendLayout();
            this.imageDataSplit.Panel2.SuspendLayout();
            this.imageDataSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceBuyingSplit)).BeginInit();
            this.PriceBuyingSplit.Panel1.SuspendLayout();
            this.PriceBuyingSplit.Panel2.SuspendLayout();
            this.PriceBuyingSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyingQuantitySplit)).BeginInit();
            this.buyingQuantitySplit.Panel1.SuspendLayout();
            this.buyingQuantitySplit.Panel2.SuspendLayout();
            this.buyingQuantitySplit.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeLabelChangeButtonSplit)).BeginInit();
            this.ChangeLabelChangeButtonSplit.Panel1.SuspendLayout();
            this.ChangeLabelChangeButtonSplit.Panel2.SuspendLayout();
            this.ChangeLabelChangeButtonSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // decisionChangeSplit
            // 
            this.decisionChangeSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decisionChangeSplit.Location = new System.Drawing.Point(0, 0);
            this.decisionChangeSplit.Name = "decisionChangeSplit";
            this.decisionChangeSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // decisionChangeSplit.Panel1
            // 
            this.decisionChangeSplit.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.decisionChangeSplit.Panel1.Controls.Add(this.descriptionTextBox);
            this.decisionChangeSplit.Panel1.Controls.Add(this.descLabel);
            this.decisionChangeSplit.Panel1.Controls.Add(this.nameLabel);
            this.decisionChangeSplit.Panel1.Controls.Add(this.imageAndDataPanel);
            // 
            // decisionChangeSplit.Panel2
            // 
            this.decisionChangeSplit.Panel2.Controls.Add(this.ChangeLabelChangeButtonSplit);
            this.decisionChangeSplit.Size = new System.Drawing.Size(596, 733);
            this.decisionChangeSplit.SplitterDistance = 636;
            this.decisionChangeSplit.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(0, 419);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(596, 217);
            this.descriptionTextBox.TabIndex = 10;
            this.descriptionTextBox.Text = resources.GetString("descriptionTextBox.Text");
            this.descriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descLabel
            // 
            this.descLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.descLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descLabel.Location = new System.Drawing.Point(0, 385);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(596, 34);
            this.descLabel.TabIndex = 9;
            this.descLabel.Text = "Description";
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(0, 351);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(596, 34);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Product Name";
            // 
            // imageAndDataPanel
            // 
            this.imageAndDataPanel.Controls.Add(this.imageDataSplit);
            this.imageAndDataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageAndDataPanel.Location = new System.Drawing.Point(0, 0);
            this.imageAndDataPanel.Name = "imageAndDataPanel";
            this.imageAndDataPanel.Size = new System.Drawing.Size(596, 351);
            this.imageAndDataPanel.TabIndex = 0;
            // 
            // imageDataSplit
            // 
            this.imageDataSplit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.imageDataSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageDataSplit.Location = new System.Drawing.Point(0, 0);
            this.imageDataSplit.Name = "imageDataSplit";
            // 
            // imageDataSplit.Panel1
            // 
            this.imageDataSplit.Panel1.Controls.Add(this.ProductImage);
            // 
            // imageDataSplit.Panel2
            // 
            this.imageDataSplit.Panel2.Controls.Add(this.PriceBuyingSplit);
            this.imageDataSplit.Size = new System.Drawing.Size(596, 351);
            this.imageDataSplit.SplitterDistance = 351;
            this.imageDataSplit.TabIndex = 10;
            // 
            // ProductImage
            // 
            this.ProductImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductImage.Image = ((System.Drawing.Image)(resources.GetObject("ProductImage.Image")));
            this.ProductImage.Location = new System.Drawing.Point(0, 0);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(351, 351);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductImage.TabIndex = 0;
            this.ProductImage.TabStop = false;
            // 
            // PriceBuyingSplit
            // 
            this.PriceBuyingSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceBuyingSplit.Location = new System.Drawing.Point(0, 0);
            this.PriceBuyingSplit.Name = "PriceBuyingSplit";
            this.PriceBuyingSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // PriceBuyingSplit.Panel1
            // 
            this.PriceBuyingSplit.Panel1.Controls.Add(this.priceLabel);
            // 
            // PriceBuyingSplit.Panel2
            // 
            this.PriceBuyingSplit.Panel2.Controls.Add(this.buyingQuantitySplit);
            this.PriceBuyingSplit.Size = new System.Drawing.Size(241, 351);
            this.PriceBuyingSplit.SplitterDistance = 127;
            this.PriceBuyingSplit.TabIndex = 0;
            // 
            // priceLabel
            // 
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceLabel.Location = new System.Drawing.Point(0, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(241, 127);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = " 10.29zł";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buyingQuantitySplit
            // 
            this.buyingQuantitySplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buyingQuantitySplit.Location = new System.Drawing.Point(0, 0);
            this.buyingQuantitySplit.Name = "buyingQuantitySplit";
            this.buyingQuantitySplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // buyingQuantitySplit.Panel1
            // 
            this.buyingQuantitySplit.Panel1.Controls.Add(this.quantity_panel);
            // 
            // buyingQuantitySplit.Panel2
            // 
            this.buyingQuantitySplit.Panel2.Controls.Add(this.buttonPanel);
            this.buyingQuantitySplit.Size = new System.Drawing.Size(241, 220);
            this.buyingQuantitySplit.SplitterDistance = 110;
            this.buyingQuantitySplit.TabIndex = 0;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.CartButton);
            this.buttonPanel.Controls.Add(this.buyButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(241, 106);
            this.buttonPanel.TabIndex = 0;
            // 
            // CartButton
            // 
            this.CartButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CartButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CartButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CartButton.Location = new System.Drawing.Point(0, 56);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(241, 50);
            this.CartButton.TabIndex = 0;
            this.CartButton.Text = "Cart";
            this.CartButton.UseVisualStyleBackColor = false;
            this.CartButton.Click += new System.EventHandler(this.CartButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.buyButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buyButton.Location = new System.Drawing.Point(0, 0);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(241, 50);
            this.buyButton.TabIndex = 0;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = false;
            
            // 
            // ChangeLabelChangeButtonSplit
            // 
            this.ChangeLabelChangeButtonSplit.BackColor = System.Drawing.SystemColors.GrayText;
            this.ChangeLabelChangeButtonSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeLabelChangeButtonSplit.Location = new System.Drawing.Point(0, 0);
            this.ChangeLabelChangeButtonSplit.Name = "ChangeLabelChangeButtonSplit";
            // 
            // ChangeLabelChangeButtonSplit.Panel1
            // 
            this.ChangeLabelChangeButtonSplit.Panel1.Controls.Add(this.ChangeOfHeartLabel);
            // 
            // ChangeLabelChangeButtonSplit.Panel2
            // 
            this.ChangeLabelChangeButtonSplit.Panel2.Controls.Add(this.changeButton);
            this.ChangeLabelChangeButtonSplit.Size = new System.Drawing.Size(596, 93);
            this.ChangeLabelChangeButtonSplit.SplitterDistance = 374;
            this.ChangeLabelChangeButtonSplit.TabIndex = 0;
            // 
            // ChangeOfHeartLabel
            // 
            this.ChangeOfHeartLabel.BackColor = System.Drawing.Color.ForestGreen;
            this.ChangeOfHeartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeOfHeartLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChangeOfHeartLabel.Location = new System.Drawing.Point(0, 0);
            this.ChangeOfHeartLabel.Name = "ChangeOfHeartLabel";
            this.ChangeOfHeartLabel.Size = new System.Drawing.Size(374, 93);
            this.ChangeOfHeartLabel.TabIndex = 0;
            this.ChangeOfHeartLabel.Text = "Changed your mind?";
            this.ChangeOfHeartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeButton
            // 
            this.changeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.changeButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeButton.Location = new System.Drawing.Point(40, 18);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(143, 58);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            // 
            // quantity_panel
            // 
            this.quantity_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantity_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.quantity_panel.Location = new System.Drawing.Point(35, 12);
            this.quantity_panel.Margin = new System.Windows.Forms.Padding(2);
            this.quantity_panel.Name = "quantity_panel";
            this.quantity_panel.Size = new System.Drawing.Size(171, 87);
            this.quantity_panel.TabIndex = 11;
            // 
            // Product_details_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.decisionChangeSplit);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Product_details_screen";
            this.Size = new System.Drawing.Size(596, 733);
            this.decisionChangeSplit.Panel1.ResumeLayout(false);
            this.decisionChangeSplit.Panel1.PerformLayout();
            this.decisionChangeSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.decisionChangeSplit)).EndInit();
            this.decisionChangeSplit.ResumeLayout(false);
            this.imageAndDataPanel.ResumeLayout(false);
            this.imageDataSplit.Panel1.ResumeLayout(false);
            this.imageDataSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageDataSplit)).EndInit();
            this.imageDataSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.PriceBuyingSplit.Panel1.ResumeLayout(false);
            this.PriceBuyingSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PriceBuyingSplit)).EndInit();
            this.PriceBuyingSplit.ResumeLayout(false);
            this.buyingQuantitySplit.Panel1.ResumeLayout(false);
            this.buyingQuantitySplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buyingQuantitySplit)).EndInit();
            this.buyingQuantitySplit.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.ChangeLabelChangeButtonSplit.Panel1.ResumeLayout(false);
            this.ChangeLabelChangeButtonSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChangeLabelChangeButtonSplit)).EndInit();
            this.ChangeLabelChangeButtonSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer decisionChangeSplit;
        private System.Windows.Forms.Label ChangeOfHeartLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.SplitContainer ChangeLabelChangeButtonSplit;
        private System.Windows.Forms.Panel imageAndDataPanel;
        private System.Windows.Forms.SplitContainer imageDataSplit;
        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.SplitContainer PriceBuyingSplit;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.SplitContainer buyingQuantitySplit;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.Panel buttonPanel;
        private containers.usercontrols.controls.Quantity_scalable quantity_panel;
    }
}
