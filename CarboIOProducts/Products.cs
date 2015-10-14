using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarboIOProducts
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductCost { get; set; }
        public string ProductCategory { get; set; }
        public bool ProductForSale { get; set; }

        public Products()
        {
            ProductID = 0;
            ProductName = "";
        }

        public static List<Products> getGenericProductList(bool getAll)
        {
            List<Products> prodList = new List<Products>
            {
                new Products { ProductID = 1 , ProductName = "Lightsaber", ProductCost = 100.00m, ProductCategory = "Mech", ProductForSale = true},
                new Products { ProductID = 2 , ProductName = "Bowcaster", ProductCost = 300.00m, ProductCategory = "Merc", ProductForSale = false}
            };
            
            return prodList;
        }
    }
}
