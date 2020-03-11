using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NorthwindSystem.Entities
{
    [Table("Products")]
    class Products
    {
        [Key] //could use Column(order=n) where n is the number of the key. So if you have a compound key here, this one would be order=1, next one would be order=2 to make up a compound key
        //we would use DataBaseGenerated(DatabaseGeneratedOption.None) IF we name the property to end with ID AND that maps to the actual name in the database itself
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int? SupplierID { get; set; }

        public int? CategoryID { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }
        public Int16? UnitsInStock { get; set; }
        public Int16? UnitsOnorder { get; set; }
        public Int16? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        [NotMapped] //read only property to concatenate a couple columns
        public string ProductandID
        {
            get { return ProductName + "(" + ProductID + ")"; }
        }
    }
}
