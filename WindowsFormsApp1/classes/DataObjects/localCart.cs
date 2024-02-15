using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.DataObjects
{
    public abstract class localCart
    {
        private static Dictionary<int, int> ShopItems = new Dictionary<int, int>();

        private static List<int> TestItemIDs = new List<int>();



        public static void AddToShopping(int itemID, int quantity)
        {


            if (ShopItems.ContainsKey(itemID))
            {
                ShopItems[itemID] += quantity;

            }
            else ShopItems.Add(itemID, quantity);

        }

        public static void RemoveFromShopping(int itemID)
        {
            if (ShopItems.ContainsKey(itemID))
            {
                ShopItems.Remove(itemID);
                
            }
        }

        public static void UpdateShopping(int itemID, int quantity)
        {
            if (ShopItems.ContainsKey(itemID))
            {
                if (quantity == 0)
                {
                    ShopItems.Remove(itemID);
                }
                else
                {
                    ShopItems[itemID] = quantity;
                }
                
            }
            else
            {
                ShopItems.Add(itemID, quantity);
            }
        }

        public static Dictionary<int, int> GetShoppingItems()
        {
            return ShopItems;
        }

        public static void ClearCart(int whichCart)
        {
            if (whichCart == 0)
                ShopItems.Clear();

            else if (whichCart == 1)
                TestItemIDs.Clear();

            else

            {
                ShopItems.Clear();
                TestItemIDs.Clear();
            }
        }



        public static void AddToTesting(int itemID)
        {


            if (TestItemIDs.Contains(itemID))
            {

                return;
            }

            TestItemIDs.Add(itemID);
        }

        public static void RemoveFromTesting(int itemID)
        {
            if (TestItemIDs.Contains(itemID))
            {
                TestItemIDs.Remove(itemID);

            }
        }


        public static List<int> GetTestingItems()
        {
            return TestItemIDs;
        }


        public static void ReplaceTestingCart(List<int> newCart)
        {
            TestItemIDs = newCart;
        }



    }
}
