using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.classes.FileOperations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.classes.DataObjects
{
    public class CartItem : Product
    {
       
        public int Quantity { get; protected set; }

        public int CartID { get; protected set; }

        public int ProductID { get; protected set; }

        public decimal TotalPrice { get { return Price * Quantity; }}


        public CartItem(Product product, int quantity=1)
        {
            ProductID = product.ID;
            Name = product.Name;
            Price = product.Price;
            StockQuantity = product.StockQuantity;
            Image = product.Image;
            Quantity = quantity;
            CartID = localCart.GetShoppingCart().ID;
            CategoryID = product.CategoryID;
        }

        private CartItem()  // cant be created from outside
        {
        }


        public void newQuantity(int quantity)
        {
            if (quantity >= 0) this.Quantity = quantity;
           
        }



        public void addToCart(int cartID)
        {
            this.CartID = cartID;
        }



        public static CartItem MapToCartItem(SqlDataReader reader)
        {
            return new CartItem
            {
                
                ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? null : reader.GetString(reader.GetOrdinal("Name")),
                Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Price")),
                Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description")),
                CartID = reader.GetInt32(reader.GetOrdinal("CartID")),
                CategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID")),
                StockQuantity = reader.GetInt32(reader.GetOrdinal("StockQuantity")),
                Image = reader.IsDBNull(reader.GetOrdinal("Image")) ? null : (byte[])reader["Image"],
                Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"))


            };
        }


        public static SqlParameter[] MapCartItemToSqlParameters(CartItem cartItem)
        {
            return new SqlParameter[]
            {                  
                      new SqlParameter("@CartID", cartItem.CartID),                    
                      new SqlParameter("@ProductID", cartItem.ProductID),
                      new SqlParameter("@Quantity", cartItem.Quantity),
                      new SqlParameter("@AddedDate", DateTime.Now)
            };
        }




        public static void UpdateItemsinDB()
        {
            DatabaseManager dbm = DatabaseManager.GetInstance();

            CartItem[] ItemList = localCart.GetShoppingCart().GetProducts().Values.ToArray();

            if(ItemList.Length == 0) return;  // if no items in cart, no need to update db

            dbm.DeleteObject("CartItems","CartID", localCart.GetShoppingCart().ID);

            foreach( CartItem item in ItemList)
            {
                dbm.InsertObject(item, "CartItems", MapCartItemToSqlParameters);
            }   


        }

       
    }
}
