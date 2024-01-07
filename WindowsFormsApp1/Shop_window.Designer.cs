namespace WindowsFormsApp1
{
    partial class Shop_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop_window));
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.TextBeforeSearch = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.LightGray;
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchBar.Location = new System.Drawing.Point(0, 54);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(567, 45);
            this.SearchBar.TabIndex = 0;
            // 
            // TextBeforeSearch
            // 
            this.TextBeforeSearch.BackColor = System.Drawing.Color.LightGray;
            this.TextBeforeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBeforeSearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.TextBeforeSearch.Location = new System.Drawing.Point(3, 42);
            this.TextBeforeSearch.Name = "TextBeforeSearch";
            this.TextBeforeSearch.Size = new System.Drawing.Size(567, 57);
            this.TextBeforeSearch.TabIndex = 1;
            this.TextBeforeSearch.Text = "Czego szukasz..?";
            this.TextBeforeSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextBeforeSearch.Click += new System.EventHandler(this.TextBeforeSearch_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DarkGray;
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.Location = new System.Drawing.Point(581, 29);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(88, 79);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.TextBeforeSearch);
            this.panel1.Controls.Add(this.SearchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 155);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 648);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(488, 700);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(135, 128);
            this.button15.TabIndex = 32;
            this.button15.Text = "Kategoria 15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(267, 700);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(135, 128);
            this.button14.TabIndex = 31;
            this.button14.Text = "Kategoria 14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(42, 700);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(135, 128);
            this.button13.TabIndex = 30;
            this.button13.Text = "Kategoria 13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(488, 529);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(135, 128);
            this.button12.TabIndex = 29;
            this.button12.Text = "Kategoria 12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(267, 529);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(135, 128);
            this.button11.TabIndex = 28;
            this.button11.Text = "Kategoria 11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(42, 529);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(135, 128);
            this.button10.TabIndex = 27;
            this.button10.Text = "Kategoria 10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(488, 358);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(135, 128);
            this.button9.TabIndex = 26;
            this.button9.Text = "Kategoria 9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(267, 358);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 128);
            this.button8.TabIndex = 25;
            this.button8.Text = "Kategoria 8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(42, 358);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 128);
            this.button7.TabIndex = 24;
            this.button7.Text = "Kategoria 7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(488, 188);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 128);
            this.button6.TabIndex = 23;
            this.button6.Text = " Kategoria 6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(267, 188);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 128);
            this.button5.TabIndex = 22;
            this.button5.Text = "Kategoria 5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(42, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 128);
            this.button4.TabIndex = 21;
            this.button4.Text = "Kategoria 4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(488, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 128);
            this.button3.TabIndex = 20;
            this.button3.Text = "Kategoria 3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 128);
            this.button1.TabIndex = 19;
            this.button1.Text = "Kategoria 2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 128);
            this.button2.TabIndex = 18;
            this.button2.Text = "Kategoria 1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Shop_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 803);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Shop_window";
            this.Text = "Shop_window";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label TextBeforeSearch;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}