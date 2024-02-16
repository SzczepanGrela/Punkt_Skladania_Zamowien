using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.DataObjects
{
    internal class GiftCard : Object
    {
        
        private string Code { get; set; }

        public decimal Debit { get; private set; }






        public static GiftCard MapToGiftCard(SqlDataReader reader)
        {
            return new GiftCard
            {
                ID = reader.IsDBNull(reader.GetOrdinal("ID")) ? 0 : reader.GetInt32(reader.GetOrdinal("ID")),
                Debit =  reader.IsDBNull(reader.GetOrdinal("Value")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Value")),
                

            };
        }


        



    }

}
