using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.DataObjects
{
    public class localCart : Cart
    {
        

        // double singleton 

       private static localCart Shopping = null;
       private static localCart Testing = null;


        public void AddtoCart(int itemID, int quantity)
        {


            if (ProductsList.ContainsKey(itemID))
            {
                ProductsList[itemID] += quantity;

            }
            else ProductsList.Add(itemID, quantity);

        }

        public void RemovefromCart(int itemID)
        {
            if (ProductsList.ContainsKey(itemID))
            {
                ProductsList.Remove(itemID);
                
            }
        }

        public void UpdateCart(int itemID, int quantity)
        {
            if (ProductsList.ContainsKey(itemID))
            {
                if (quantity == 0)
                {
                    ProductsList.Remove(itemID);
                }
                else
                {
                    ProductsList[itemID] = quantity;
                }
                
            }
            else
            {
                ProductsList.Add(itemID, quantity);
            }
        }

        public Dictionary<int, int> GetProducts()
        {
            return ProductsList;
        }

        public void ClearCart()
        {
            ProductsList.Clear();
        }

        public void ReplaceProducts(Dictionary<int,int> newCart)
        {
            ProductsList = newCart;
        }

        public static localCart GetTestingCart()
        {
            if (Testing == null)
            {
                Testing = new localCart();
            }
            return Testing;
        }

        public static localCart GetShoppingCart()
        {
            if (Shopping == null)
            {
                Shopping = new localCart();
            }
            return Shopping;
        }

        internal static void ClearCarts()
        {
            Testing.ClearCart();
            Shopping.ClearCart();
        }
    }
}
