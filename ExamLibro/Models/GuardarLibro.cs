using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace ExamLibro.Models
{
    public class GuardarLibro
    {


        public void Guardar(Libro model)
        {
            StreamWriter libro = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/biblioteca.txt", true);
            libro.WriteLine("<tr><td>" + model.Id + "</td>"
                + "<td>" + model.ISBN + "</td>" 
                + "<td>" + model.Titulo + "</td>"
                + "<td>" + model.NumPaginas + "</td>"
                + "<td>" + model.Editorial + "</td>"
                + "<td>" + model.Autor + "</td>"
                + "<td>" + model.FechaPubli + "</td></tr>");

            libro.Close();
        }


        public string Leer()
        {
            StreamReader libro = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/biblioteca.txt");
            string contenido = libro.ReadToEnd();
            libro.Close();

            return (contenido);
        }
    }
}