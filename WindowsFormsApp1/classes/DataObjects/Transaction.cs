using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.DataObjects
{
    internal class Transaction : Object
    {
        protected decimal PriceAtPurchase { get; set; }

        protected int CartID { get; set; }

        protected DateTime TransactionDate { get; set; }





        public static SqlParameter[] MapTransactionToSqlParameters(Transaction transaction)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@PriceAtPurchase", transaction.PriceAtPurchase),
                new SqlParameter("@CartID", transaction.CartID),
                new SqlParameter("@TransactionDate", transaction.TransactionDate)

            };
        }




    }
}
