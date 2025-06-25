using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Table(Name = "pais")]
    public class Pais
    {
        [PrimaryKey, Identity, Column(Name = "idPAIS")]
        public int idPAIS { get; set; }
        [Column(Name = "nombre")]
        public string nombre { get; set; }
        [Column(Name = "codigo")]
        public string codigo { get; set; }

    }
}
