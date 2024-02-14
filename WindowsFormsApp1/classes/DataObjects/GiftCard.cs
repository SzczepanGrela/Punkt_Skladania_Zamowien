using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.DataObjects
{
    internal class GiftCard
    {
        private int ID { get; set; }
        private string Code { get; set; }

        public decimal Debit { get; private set; }




        public static GiftCard MapToGiftCard(SqlDataReader reader)
        {
            return new GiftCard
            {
                ID = reader.IsDBNull(reader.GetOrdinal("GiftCardID")) ? 0 : reader.GetInt32(reader.GetOrdinal("GiftCardID")),
                Debit =  reader.IsDBNull(reader.GetOrdinal("Value")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Value")),
                //Code = reader.IsDBNull(reader.GetOrdinal("Code")) ? null : reader.GetString(reader.GetOrdinal("Gift"))

               

            };
        }


        



    }

}
