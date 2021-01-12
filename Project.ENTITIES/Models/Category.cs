using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }

        //relational properties
        public virtual List<Product> Products { get; set; }

    }
}
