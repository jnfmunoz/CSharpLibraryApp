using Data;
using Logica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Mappers
{
    public class AutorMapper
    {
        public static AutorInputModel ToViewModel(Autor autor)
        {
            return new AutorInputModel
            {
                Id = autor.idAUTOR,
                Nombre = autor.nombre,
                FechaNacimiento = autor.fecha_nacimiento,
                Pais = autor.PAIS_idPAIS
            };
        }

        public static Autor ToEntity(AutorInputModel model)
        {
            return new Autor
            {
                nombre = model.Nombre,
                fecha_nacimiento = model.FechaNacimiento,
                PAIS_idPAIS = model.Pais
            };
        }
    }
}
