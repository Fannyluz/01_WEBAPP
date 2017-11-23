using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlumnosWebAPP.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String FotoURL { get; set; }
        public String Usuario { get; set; }
        public String Password { get; set; }

    }
}