using Data;
using LinqToDB;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LPais : Librarys
    {
        public List<Pais> GetPaises()
        {
            using (var db = new Conexion())
            {
                return db.GetTable<Pais>().ToList();
            }
        }

    }

}
