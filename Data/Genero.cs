using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Genero
    {
        [PrimaryKey, Identity, Column(Name = "idGENERO")]
        public int idGENERO{ get; set; }
        [Column(Name = "nombre")]
        public string nombre { get; set; }

    }
}
