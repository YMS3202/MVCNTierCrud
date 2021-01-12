using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class ProductAtrributeMap:BaseMap<ProductAttribute>
    {
        public ProductAtrributeMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new
            {
               x.ProductID,
               x.AttributeID
            });
        }
    }
}
