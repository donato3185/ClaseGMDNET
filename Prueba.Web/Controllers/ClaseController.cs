using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Web.Controllers
{
    public class ClaseController : Controller
    {
        public ClaseController()
        {
            // instanciamos la Clase Services que esta en BL
        }

        // GET: Clase
        public ActionResult Index()
        {
            /*List <Clase> lista = new List<Clase>();
            Clase cl1 = new Clase() { ClaseId = 1, Nombre = "Clase1", Comentario = "Hola" };
            Clase cl2 = new Clase() { ClaseId = 1, Nombre = "Clase2", Comentario = "Hola" };
            Clase cl3 = new Clase() { ClaseId = 1, Nombre = "Clase3", Comentario = "Hola" };
            lista.Add(cl1);
            lista.Add(cl2);
            lista.Add(cl3);*/

            List<>

            return View(lista);
        }
    }
}