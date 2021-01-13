using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.MVCUI.Models.VMClasses
{
    public class ProductVM
    {
        //gereksiz property'leri sil!
        public Product Product { get; set; }
        public PAttribute Attribute { get; set; }
        public ProductAttribute ProductAttribute { get; set; }
        public List<Product> Products { get; set; }
        public List<PAttribute> Attributes { get; set; }
        public List<ProductAttribute> ProductAttributes { get; set; }
    }
}