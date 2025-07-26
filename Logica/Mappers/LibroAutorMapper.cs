using Data;
using Logica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Mappers
{
    public static class LibroAutorMapper
    {
        public static LibroAutorInputModel ToViewModel(LibroAutor libroAutor)
        {
            return new LibroAutorInputModel
            {
                Id = libroAutor.idLIBROAUTOR,
                Libro = libroAutor.LIBRO_idLIBRO,
                Autor = libroAutor.AUTOR_idAUTOR
            };
        }

        public static LibroAutor ToEntity(LibroAutorInputModel model)
        {
            return new LibroAutor
            {
                idLIBROAUTOR = model.Id,
                LIBRO_idLIBRO = model.Libro,
                AUTOR_idAUTOR = model.Autor
            };
        }
    }
}

