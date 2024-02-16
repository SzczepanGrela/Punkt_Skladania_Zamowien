using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.classes.FileOperations;

namespace WindowsFormsApp1.classes.DataObjects
{
    
    public class Cart : Object
    {
        
       

        

        protected Dictionary<int, CartItem> ProductsList = new Dictionary<int, CartItem>();

        protected DateTime CreatedDate { get; set; }

        protected string Status { get; set; }

        protected int CustomerID { get; set; }  





        public Cart()
        {
        }

        public Cart(int customerID)  // coonstructor for getting the active cart of the customer form database
        {
            DatabaseManager dbm = DatabaseManager.GetInstance();
            string query =$"select * from Carts where CustomerID = {customerID} and Status = 'Active' order by CreatedDate desc";
            List<Cart> cart = dbm.ExecuteQuery<Cart>(query, MapToCart);  
            if (cart.Count == 1)
            {
                ID = cart[0].ID;
                CustomerID = cart[0].CustomerID;
                CreatedDate = cart[0].CreatedDate;
                Status = cart[0].Status;

                query =$"select * from CartItems inner join products on CartItems.ProductID = Products.ID where CartID = {ID}";

                List<CartItem>  Items = dbm.ExecuteQuery<CartItem>(query, CartItem.MapToCartItem);

                ProductsList = Items.ToDictionary(item => item.ProductID);

            }
            else if (cart.Count > 1)
            {
                throw new ApplicationException("Multiple active carts found for the same customer");
                
            }
            else
            {
                CustomerID = customerID;
                CreatedDate = DateTime.Now;
                Status = "Active";
                ID=dbm.InsertObjectGetID(this, "Carts", MapCartToSqlParameters);
            }
        }

      
        public static Cart MapToCart(SqlDataReader reader)
        {
            return new Cart
            {
                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                CustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate")),
                Status = reader.GetString(reader.GetOrdinal("Status"))

            };
        }



        public static SqlParameter[] MapCartToSqlParameters(Cart cart)
        {
            return new SqlParameter[]
            {
                      new SqlParameter("@CustomerID", cart.CustomerID),
                      new SqlParameter("@CreatedDate", cart.CreatedDate),
                      new SqlParameter("@Status", cart.Status)
            };
        }



        public Dictionary<int, CartItem> GetProducts()
        {
            return ProductsList;
        }

        internal void RemoveItemsFromStock()
        {
          DatabaseManager dbm = DatabaseManager.GetInstance();

            foreach(KeyValuePair<int,CartItem> item in this.ProductsList)
            {
                dbm.ExecuteCommand(true, "Products", new string[] { "StockQuantity" }, new string[] { $"StockQuantity - {item.Value.Quantity}" }, $"ID = {item.Value.ProductID}");
            }
        }
    }
}
