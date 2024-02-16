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
    public partial class Quantity_scalable : UserControl
    {
        private int Quantity = 1;
        private int InStock = 10;

        public int GetQuantity()
        {
            return this.Quantity;
        }
        public void SetQuantity(int quantity)
        {
            this.Quantity = quantity;

            OnQuantityChanged();
        }

        public Quantity_scalable()
        {
            InitializeComponent();

            this.Load += new EventHandler(Quantity_panel_Load);

        }

        public Quantity_scalable(int quantity, int inStock)
        {
            InitializeComponent();
            SetPanel(quantity, inStock);
        }

        public void SetPanel(int inStock, int Quantity = 1)
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
                SetQuantity(GetQuantity() + 1);
                this.quantityLabel.Text = Quantity.ToString();
            }
        }

        private void decreaseQuantityButton_Click(object sender, EventArgs e)
        {
            if (this.Quantity > 0)
            {
                SetQuantity(GetQuantity() - 1);
                this.quantityLabel.Text = Quantity.ToString();
            }

        }



        public event EventHandler QuantityChanged;


        protected virtual void OnQuantityChanged()
        {


            if (QuantityChanged != null)
            {
                QuantityChanged(this, EventArgs.Empty);
            }
        }
    }
}
