namespace WindowsFormsApp1.controls.usercontrols.controls
{
    partial class Product_button
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_button));
            this.split = new System.Windows.Forms.SplitContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pricenamesplit = new System.Windows.Forms.SplitContainer();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricenamesplit)).BeginInit();
            this.pricenamesplit.Panel1.SuspendLayout();
            this.pricenamesplit.Panel2.SuspendLayout();
            this.pricenamesplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(0, 0);
            this.split.Name = "split";
            this.split.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split.Panel1
            // 
            this.split.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.split.Panel1.Controls.Add(this.pictureBox);
            // 
            // split.Panel2
            // 
            this.split.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.split.Panel2.Controls.Add(this.pricenamesplit);
            this.split.Size = new System.Drawing.Size(185, 249);
            this.split.SplitterDistance = 174;
            this.split.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(100);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Padding = new System.Windows.Forms.Padding(100);
            this.pictureBox.Size = new System.Drawing.Size(185, 174);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // pricenamesplit
            // 
            this.pricenamesplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pricenamesplit.Location = new System.Drawing.Point(0, 0);
            this.pricenamesplit.Margin = new System.Windows.Forms.Padding(2);
            this.pricenamesplit.Name = "pricenamesplit";
            this.pricenamesplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // pricenamesplit.Panel1
            // 
            this.pricenamesplit.Panel1.Controls.Add(this.nameLabel);
            // 
            // pricenamesplit.Panel2
            // 
            this.pricenamesplit.Panel2.Controls.Add(this.priceLabel);
            this.pricenamesplit.Size = new System.Drawing.Size(185, 71);
            this.pricenamesplit.SplitterDistance = 31;
            this.pricenamesplit.SplitterWidth = 3;
            this.pricenamesplit.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(185, 31);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Item Name Example ddddddddddddddddddddddd";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceLabel
            // 
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceLabel.ForeColor = System.Drawing.Color.Black;
            this.priceLabel.Location = new System.Drawing.Point(0, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(185, 37);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "$420.69";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Item_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.split);
            this.Name = "Item_view";
            this.Size = new System.Drawing.Size(185, 249);
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.pricenamesplit.Panel1.ResumeLayout(false);
            this.pricenamesplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pricenamesplit)).EndInit();
            this.pricenamesplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.SplitContainer pricenamesplit;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
    }
}
