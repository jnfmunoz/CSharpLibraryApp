using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class LibroAutor
    {
        [Column(Name = "idLIBROAUTOR")]
        public int idLIBROAUTOR { get; set; }

        [Column(Name = "AUTOR_idAUTOR")]
        public int AUTOR_idAUTOR { get; set; }
        [Column(Name = "LIBRO_idLIBRO")]
        public int LIBRO_idLIBRO { get; set; }
    }
}
