using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.MVCUI.Models.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class ProductController : Controller
    {


        ProductRepository _prep;
        AttributeRepository _arep;
        ProductAttributeRepository _parep; 

        public ProductController()
        {
            _prep = new ProductRepository();
            _arep = new AttributeRepository();
            _parep = new ProductAttributeRepository();

        }
        // GET: Product
        public ActionResult AdminPanel()
        {

            
            return View();
        }


        public ActionResult AddProduct()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            _prep.Add(product);
            return RedirectToAction("AddProduct");

        }

        public ActionResult AddAttribute()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult AddAttribute(PAttribute attribute)
        {
            _arep.Add(attribute);
            return RedirectToAction("AddAttribute");
        }

        public ActionResult AddAttributeToProduct()
        {
            ProductVM pvm = new ProductVM()
            {
                
                Products = _prep.GetActives(),
                Attributes= _arep.GetActives()

            };

            return View(pvm);
        }

        [HttpPost]
        public ActionResult AddAttributeToProduct(ProductAttribute productAttribute)
        {

            _parep.Add(productAttribute);
            return RedirectToAction("AddAttributeToProduct");
        }

        public ActionResult ProductAndAttributeList(int? id)
        {
            ProductVM pvm = new ProductVM()
            {

                ProductAttributes = id == null ? _parep.GetActives() : _parep.Where(x => x.ProductID == id),
                Products = _prep.GetActives()

            };

            return View(pvm);
        }









    }
}