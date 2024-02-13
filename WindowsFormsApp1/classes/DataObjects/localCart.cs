using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.DataObjects
{
    public static class localCart
    {
        private static Dictionary<int, int> items = new Dictionary<int, int>();

        public static void AddItem(int item, int quantity)
        {


            if (items.ContainsKey(item))
            {
                items[item] += quantity;

            }
            else items.Add(item, quantity);

        }

        public static void RemoveItem(int item)
        {
            if (items.ContainsKey(item))
            {
                items.Remove(item);
            }
        }

        public static void UpdateItem(int item, int quantity)
        {
            if (items.ContainsKey(item))
            {
                items[item] = quantity;
            }
        }

        public static Dictionary<int, int> GetItems()
        {
            return items;
        }

        public static void ClearCart()
        {
            items.Clear();
        }



    }
}
