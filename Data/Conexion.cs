using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Conexion : LinqToDB.Data.DataConnection
    {
        public Conexion(): base("MySQL") {  }
        public ITable<Pais> _Pais => this.GetTable<Pais>();
        public ITable<Editorial> _Editorial => this.GetTable<Editorial>();

    }
}
