using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.classes.FileOperations;
using WindowsFormsApp1.classes.Methods;

namespace WindowsFormsApp1.containers.usercontrols.controls
{
    public partial class Testing_cart_item_slice : UserControl
    {
        private string name { get; set; }
        private decimal price { get; set; }
        private byte[] image { get; set; }
        private int iD { get; set; }

        public bool Checked
        {
            get { return SelectcheckBox.Checked; }
            private set
            {
                SelectcheckBox.Checked = value;
            }
        }

        public Testing_cart_item_slice()
        {
            InitializeComponent();
        }

        public Testing_cart_item_slice(string name, decimal price, byte[] image, int iD)
        {
            InitializeComponent();
            this.price = price;
            this.image = image;
            this.iD = iD;
            this.name = name;
        }

        internal static List<Testing_cart_item_slice> createCart_item_slices(List<int> productIDs)
        {
            DatabaseManager dbm = DatabaseManager.GetInstance();

            string query = Querry.ProductsMatchingID(productIDs);  // the result is querry with condition |where ID in *List of IDs*| 


            List<Product> products = dbm.ExecuteQuery<Product>(query, Product.MaptoSlice);

            List<Testing_cart_item_slice> slices = new List<Testing_cart_item_slice>();

            foreach (Product product in products)
            {
                Testing_cart_item_slice slice = new Testing_cart_item_slice(product.Name, product.Price, product.Image, product.ID);
                slices.Add(slice);

            }

            return slices;
        }

        

        
    }
}
