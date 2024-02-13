using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.Methods
{
    public static class Querry
    {

        public static string ProductsMatchingID(List<int> productIds)
        {
            
            var queryBuilder = new StringBuilder("SELECT * FROM Products WHERE ProductID IN (");

            
            queryBuilder.Append(string.Join(", ", productIds));   // joins all elements with the comma

     
            queryBuilder.Append(");");

           
            return queryBuilder.ToString();
        }



    }
}
