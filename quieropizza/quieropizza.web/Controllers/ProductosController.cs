using quieropizza.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quieropizza.web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            ProductoModel a = new ProductoModel();
            a.Id = 101;
            a.descripcion = "pizza hawaina";

            ProductoModel b = new ProductoModel();
            b.Id = 102;
            b.descripcion = "pizza tres quesos";

            ProductoModel c = new ProductoModel();
            c.Id = 103;
            c.descripcion = "pizza artesanal";

            List<ProductoModel> productos = new List<ProductoModel>();
            productos.Add(a);
            productos.Add(b);
            productos.Add(c);


            return View(productos);
        }
    }
}