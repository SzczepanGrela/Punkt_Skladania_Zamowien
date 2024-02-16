using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.classes.FileOperations;

namespace WindowsFormsApp1.classes.DataObjects
{
    public class localCart : Cart
    {
        private localCart()   // cant be createed from outside
        {


        }

        // double singleton 

       private static localCart Shopping = null;
        
       private static localCart Testing = null;

       


        private static DatabaseManager dbm = DatabaseManager.GetInstance();


        public void AddtoCart(CartItem item)
        {
           

            if (ProductsList.ContainsKey(item.ProductID))
            {
                ProductsList[item.ProductID].newQuantity(item.Quantity);

            }
            else ProductsList.Add(item.ProductID, item);

        }
        public void AddtoCart(Product product, int quantity)
        {
            AddtoCart(new CartItem(product, quantity));
        }




        public void RemovefromCart(CartItem item)
        {
            if (ProductsList.ContainsKey(item.ProductID))
            {
                ProductsList.Remove(item.ProductID);
                
            }
        }

        public void RemovefromCart(int productID)
        {
            if (ProductsList.ContainsKey(productID))
            {
                ProductsList.Remove(productID);
            }
        }




        public void UpdateCart(CartItem item)
        {
            if (ProductsList.ContainsKey(item.ProductID))
            {
                if (item.Quantity<=0)
                {
                    ProductsList.Remove(item.ProductID);
                }
                else
                {
                    ProductsList[item.ProductID].newQuantity(item.Quantity);
                }
                
            }
            else
            {
                ProductsList.Add(item.ProductID, item);
            }
        }

       

        public void ClearCart()
        {
            ProductsList.Clear();
        }

        public void ReplaceProducts(Dictionary<int, CartItem> newCart)
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
            if (Testing != null) Testing.ClearCart();
            if(Shopping != null) Shopping.ClearCart();
        }

        internal static void MergeShoppingCarts(Cart cart)
        {
            foreach(var item in cart.GetProducts())
            {
                Shopping.AddtoCart(item.Value);
            }
        }

        public static int GetShoppingCartID()
        {
            return Shopping.ID;
        }

       
        public static void Login(int CustomerID)
        {
            GetShoppingCart();   // creates a new cart if it doesnt exist

            Shopping.CustomerID = CustomerID;

            Cart recentCart = new Cart(CustomerID);

            Shopping.ID = recentCart.ID;

            localCart.MergeShoppingCarts(recentCart);
            

        }


       

    }
}
