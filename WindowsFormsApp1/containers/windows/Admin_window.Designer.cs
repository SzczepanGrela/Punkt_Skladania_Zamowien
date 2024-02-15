namespace WindowsFormsApp1.containers.windows
{
    partial class Admin_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddProducts = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveProducts = new System.Windows.Forms.Button();
            this.AddCategory = new System.Windows.Forms.Button();
            this.removeCategory = new System.Windows.Forms.Button();
            this.AddEmployees = new System.Windows.Forms.Button();
            this.RemoveEmployees = new System.Windows.Forms.Button();
            this.screenPanel = new System.Windows.Forms.Panel();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddProducts
            // 
            this.AddProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddProducts.Location = new System.Drawing.Point(20, 20);
            this.AddProducts.Margin = new System.Windows.Forms.Padding(20);
            this.AddProducts.Name = "AddProducts";
            this.AddProducts.Size = new System.Drawing.Size(107, 60);
            this.AddProducts.TabIndex = 0;
            this.AddProducts.Text = "Add Products";
            this.AddProducts.UseVisualStyleBackColor = true;
            this.AddProducts.Click += new System.EventHandler(this.AddProducts_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 6;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.buttonPanel.Controls.Add(this.RemoveEmployees, 5, 0);
            this.buttonPanel.Controls.Add(this.AddEmployees, 4, 0);
            this.buttonPanel.Controls.Add(this.removeCategory, 3, 0);
            this.buttonPanel.Controls.Add(this.AddCategory, 2, 0);
            this.buttonPanel.Controls.Add(this.RemoveProducts, 1, 0);
            this.buttonPanel.Controls.Add(this.AddProducts, 0, 0);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 1;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonPanel.Size = new System.Drawing.Size(886, 100);
            this.buttonPanel.TabIndex = 6;
            // 
            // RemoveProducts
            // 
            this.RemoveProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveProducts.Location = new System.Drawing.Point(167, 20);
            this.RemoveProducts.Margin = new System.Windows.Forms.Padding(20);
            this.RemoveProducts.Name = "RemoveProducts";
            this.RemoveProducts.Size = new System.Drawing.Size(107, 60);
            this.RemoveProducts.TabIndex = 1;
            this.RemoveProducts.Text = "Remove Products";
            this.RemoveProducts.UseVisualStyleBackColor = true;
            this.RemoveProducts.Click += new System.EventHandler(this.RemoveProducts_Click);
            // 
            // AddCategory
            // 
            this.AddCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddCategory.Location = new System.Drawing.Point(314, 20);
            this.AddCategory.Margin = new System.Windows.Forms.Padding(20);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(107, 60);
            this.AddCategory.TabIndex = 2;
            this.AddCategory.Text = "Add Category";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // removeCategory
            // 
            this.removeCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeCategory.Location = new System.Drawing.Point(461, 20);
            this.removeCategory.Margin = new System.Windows.Forms.Padding(20);
            this.removeCategory.Name = "removeCategory";
            this.removeCategory.Size = new System.Drawing.Size(107, 60);
            this.removeCategory.TabIndex = 3;
            this.removeCategory.Text = "Remove Category";
            this.removeCategory.UseVisualStyleBackColor = true;
            this.removeCategory.Click += new System.EventHandler(this.removeCategory_Click);
            // 
            // AddEmployees
            // 
            this.AddEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddEmployees.Location = new System.Drawing.Point(608, 20);
            this.AddEmployees.Margin = new System.Windows.Forms.Padding(20);
            this.AddEmployees.Name = "AddEmployees";
            this.AddEmployees.Size = new System.Drawing.Size(107, 60);
            this.AddEmployees.TabIndex = 4;
            this.AddEmployees.Text = "Add Employee";
            this.AddEmployees.UseVisualStyleBackColor = true;
            this.AddEmployees.Click += new System.EventHandler(this.AddEmployees_Click);
            // 
            // RemoveEmployees
            // 
            this.RemoveEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveEmployees.Location = new System.Drawing.Point(755, 20);
            this.RemoveEmployees.Margin = new System.Windows.Forms.Padding(20);
            this.RemoveEmployees.Name = "RemoveEmployees";
            this.RemoveEmployees.Size = new System.Drawing.Size(111, 60);
            this.RemoveEmployees.TabIndex = 5;
            this.RemoveEmployees.Text = "Remove Employee";
            this.RemoveEmployees.UseVisualStyleBackColor = true;
            this.RemoveEmployees.Click += new System.EventHandler(this.RemoveEmployees_Click);
            // 
            // screenPanel
            // 
            this.screenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenPanel.Location = new System.Drawing.Point(0, 100);
            this.screenPanel.Name = "screenPanel";
            this.screenPanel.Size = new System.Drawing.Size(886, 477);
            this.screenPanel.TabIndex = 7;
            // 
            // Admin_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 577);
            this.Controls.Add(this.screenPanel);
            this.Controls.Add(this.buttonPanel);
            this.Name = "Admin_window";
            this.Text = "Admin_window";
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddProducts;
        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.Button RemoveEmployees;
        private System.Windows.Forms.Button AddEmployees;
        private System.Windows.Forms.Button removeCategory;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.Button RemoveProducts;
        private System.Windows.Forms.Panel screenPanel;
    }
}