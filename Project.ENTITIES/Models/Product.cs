using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int? CategoryID { get; set; }


        //relational properties
        public virtual Category Category { get; set; }
        public virtual List<ProductAttribute> ProductAttributes { get; set; }

    }
}
