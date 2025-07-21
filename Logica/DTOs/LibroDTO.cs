using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.DTOs
{
    public class LibroDTO
    {
            public int ID { get; set; }
            public string Titulo { get; set; }
            public string ISBN { get; set; }
            public int AnioPublicacion { get; set; }
            public string Sinopsis { get; set; }
            public string Editorial { get; set; }
            public string Genero { get; set; }
            public string Autor { get; set; }        
    }
}
