using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ProductAttribute:BaseEntity
    {
        public string Value { get; set; }
        public int ProductID { get; set; }
        public int AttributeID { get; set; }


        //relational properties
        public virtual Product Product { get; set; }
        public virtual PAttribute Attribute { get; set; }

    }
}
