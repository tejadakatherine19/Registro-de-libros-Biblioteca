using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExamLibro.Models;
using Rotativa;

namespace ExamLibro.Controllers
{
    public class LibrosController : Controller
    {

        GuardarLibro lib = new GuardarLibro();
        // GET: Libros
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AgregarLibro()
        {
            Libro model = new Libro();
            return View(model);
        }


        [HttpPost]
        public ActionResult AgregarLibro(Libro model)
        {
            if (ModelState.IsValid)
            {
                lib.Guardar(model);
                return View("Enviado");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult MostrarLibro()
        {
            string contenido = lib.Leer();
            ViewData["lib"] = contenido;

            return View();

        }


        public ActionResult Imprimir()
        {
            string contenido = lib.Leer();
            ViewData["lib"] = contenido;

            return new ViewAsPdf("PDF")
            {
                PageSize = Rotativa.Options.Size.A4,
                PageMargins = new Rotativa.Options.Margins(20,10,20,10),
                FileName = "Biblioteca.pdf"
            };
        }
    }
}