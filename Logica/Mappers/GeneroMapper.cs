using Data;
using Logica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Mappers
{
    public class GeneroMapper
    {
        public static GeneroInputModel ToViewModel(Genero genero)
        {
            return new GeneroInputModel
            {
                ID = genero.idGENERO,
                Genero = genero.nombre
            };
        }

        public static Genero ToEntity(GeneroInputModel model)
        {
            return new Genero
            {
                nombre = model.Genero
            };
        }
    }
}
