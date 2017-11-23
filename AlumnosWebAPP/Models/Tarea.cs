using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlumnosWebAPP.Controllers
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string ArchivoURL { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public DateTime FechaLimite { get; set; }
    }
}