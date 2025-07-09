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
        /*  
            `AUTOR_idAUTOR` INT NOT NULL,
            `LIBRO_idLIBRO` INT NOT NULL, 
        */

        [Column(Name = "AUTOR_idAUTOR")]
        public int AUTOR_idAUTOR { get; set; }
        [Column(Name = "LIBRO_idLIBRO")]
        public int LIBRO_idLIBRO { get; set; }

    }
}
