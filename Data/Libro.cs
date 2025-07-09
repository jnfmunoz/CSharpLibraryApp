using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Libro
    {
        [PrimaryKey, Identity, Column(Name = "idLIBRO")]
        public int idLIBRO { get; set; }
        [Column(Name = "titulo")]
        public string titulo { get; set; }
        [Column(Name = "isbn")]
        public string isbn { get; set; }
        [Column(Name = "anio_publicacion")]
        public int anio_publicacion { get; set; }
        [Column(Name = "sinopsis")]
        public string sinopsis { get; set; }
        [Column(Name = "EDITORIAL_idEDITORIAL")]
        public int EDITORIAL_idEDITORIAL { get; set; }
        [Column(Name = "GENERO_idGENERO")]
        public int GENERO_idGENERO { get; set; }

    }
}
