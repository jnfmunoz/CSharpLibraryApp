using Data;
using Logica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Mappers
{
    public static class EditorialMapper
    {
        public static EditorialInputModel ToViewModel(Editorial editorial)
        {
            return new EditorialInputModel
            {
                ID = editorial.idEDITORIAL,
                Editorial = editorial.nombre,
                Pais = editorial.PAIS_idPAIS
            };
        }

        public static Editorial ToEntity(EditorialInputModel model)
        {
            return new Editorial
            {
                nombre = model.Editorial,
                PAIS_idPAIS = model.Pais,
            };
        }

    }
}
