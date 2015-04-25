using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEntity.Entity
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsInOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public Categories Categories { get; set; }
        public Products()
        {

        }
        public Products(int ProductID)
        {
            this.ProductId = ProductId;
        }
    }
}
