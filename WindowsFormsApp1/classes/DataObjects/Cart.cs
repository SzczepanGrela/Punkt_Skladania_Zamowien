using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.DataObjects
{
    
    public class Cart
    {
        protected Dictionary<Product, int> items = new Dictionary<Product, int>();

        private int ID { get; set; }

        private DateTime createdDate { get; set; }

        private enum BasketStatus
        {
            Active,
            Completed
        }

        private BasketStatus Status { get; set; }

        private int CustomerID { get; set; }

        public Cart()
        {
            
        }





    }
}
