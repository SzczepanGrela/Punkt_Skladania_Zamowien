using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.DataObjects
{
    internal class Promotion : Object
    {
        
       
        private string Description { get; set;}
        private decimal Value { get; set;}
        private int DiscountType { get; set; }



        public decimal calculateDiscount(decimal price)
        {
            if (DiscountType == 1)   // percental discount
            {
                return price - (price * Value / 100);
               
            }
            else if (DiscountType == 2)  // fixed discount
            {
                 return (price - Value)<0 ? 0 : price - Value;
            }
            else
            {
                throw new Exception("Invalid discount type");
            }
        }

        public static Promotion MaptoDiscount(SqlDataReader reader)
        {
            return new Promotion
            {
                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? null : reader.GetString(reader.GetOrdinal("Name")),
                Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description")),
                DiscountType=reader.IsDBNull(reader.GetOrdinal("DiscountTypeId")) ? 0 : reader.GetInt32(reader.GetOrdinal("DiscountTypeId")),
                Value = reader.IsDBNull(reader.GetOrdinal("Discount")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Discount"))
            };
        }

    }


}
