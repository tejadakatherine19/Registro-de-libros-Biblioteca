using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamLibro.Models
{
    public class Libro
    {

        [Required (ErrorMessage = "El Id es requerido")]
        public string Id { get; set; }

        [Required (ErrorMessage ="El ISBN del libro es requerido")]
        [MaxLength(18, ErrorMessage ="El numero maximo de caracteres es 18, incluyendo guiones")]
        public string ISBN { get; set; }

        [Required (ErrorMessage ="El titulo del libro es requerido")]
        public string Titulo { get; set; }

        [Required (ErrorMessage ="El numero de paginas es requerido")]
        public int NumPaginas { get; set; }

        [Required (ErrorMessage = "El editorial es requerido")]
        public string Editorial { get; set; }

        [Required (ErrorMessage = "El autor es requerido")]
        public string Autor { get; set; }

        [Required (ErrorMessage = "La fecha de publicacion es requerida")]
        public DateTime FechaPubli { get; set; }
    }
}