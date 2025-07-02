using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Autor
    {
        [PrimaryKey, Identity, Column(Name = "idAUTOR")]
        public int idAUTOR { get; set; }
        [Column(Name = "nombre")]
        public string nombre { get; set; }
        [Column(Name = "fecha_nacimiento")]
        public DateTime fecha_nacimiento { get; set; }
        [Column(Name = "PAIS_idPAIS")]
        public int PAIS_idPAIS { get; set; }

    }
}
