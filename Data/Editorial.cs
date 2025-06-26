using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Editorial
    {
        [PrimaryKey, Identity, Column(Name = "idEDITORIAL")]
        public int idEDITORIAL { get; set; }
        [Column(Name = "nombre")]
        public string nombre { get; set; }
        [Column(Name = "PAIS_idPAIS")]
        public int PAIS_idPAIS { get; set; }

    }
}
