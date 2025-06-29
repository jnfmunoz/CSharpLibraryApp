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

        public int GetIdPaisFromName(string nombre)
        {
            using (var db = new Conexion())
            {
                var pais = db.GetTable<Pais>().FirstOrDefault(p => p.nombre == nombre);
                return pais != null ? pais.idPAIS : 0;

            }
        }

    }

}
