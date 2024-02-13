using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.containers.usercontrols.controls
{
    public partial class Quantity_panel : UserControl
    {
        private int Quantity = 1;
        private int InStock = 10;

        public int getQuantity()
        {
            return this.Quantity;
        }

        public Quantity_panel()
        {
            InitializeComponent();

            this.Load += new EventHandler(Quantity_panel_Load);
        }

        public Quantity_panel(int quantity, int inStock)
        {
            InitializeComponent();
            setPanel(quantity, inStock);
        }

        public void setPanel( int inStock, int Quantity=1)
        {
            this.Quantity = Quantity;
            this.InStock = inStock;
            this.quantityLabel.Text = Quantity.ToString(); 
            this.inStockLabel.Text = InStock.ToString() + " items left in stock.";
        }

        private void Quantity_panel_Load(object sender, EventArgs e)
        {
            this.quantityLabel.Text = Quantity.ToString();
            this.inStockLabel.Text = InStock.ToString() + " items left in stock.";
        }

        private void increaseQuantityButton_Click(object sender, EventArgs e)
        {
            if (this.Quantity < this.InStock)
            {
                this.Quantity++;
                this.quantityLabel.Text = Quantity.ToString();
            }
        }

        private void decreaseQuantityButton_Click(object sender, EventArgs e)
        {
            if (this.Quantity > 1)
            {
                this.Quantity--;
                this.quantityLabel.Text = Quantity.ToString();
            }

        }

        private void Quantity_panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quantity: " + Quantity);
        }
    }
}
