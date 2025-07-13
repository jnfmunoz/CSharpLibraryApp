using Data;
using Logica.ViewModels;
using Logica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Mappers
{
    public static class LibroMapper
    {
        /* Convierte una entidad Libro obtenida de la 
         * base de datos en un ViewModel para la interfaz de usuario 
         */
        public static LibroInputModel ToViewModel(Libro libro)
        {
            return new LibroInputModel
            {
                Id = libro.idLIBRO,
                Titulo = libro.titulo,
                ISBN = libro.isbn,
                AnioPublicacion = libro.anio_publicacion,
                Sinopsis = libro.sinopsis,
                EDITORIAL_idEDITORIAL = libro.EDITORIAL_idEDITORIAL,
                GENERO_idGENERO = libro.GENERO_idGENERO
            };
        }

        /* Convierte el ViewModel en entidad para guardar en la BD */
        public static Libro ToEntity(LibroInputModel model)
        {
            return new Libro
            {
                titulo = model.Titulo,
                isbn = model.ISBN,
                anio_publicacion = model.AnioPublicacion,
                sinopsis = model.Sinopsis,
                EDITORIAL_idEDITORIAL = model.EDITORIAL_idEDITORIAL,
                GENERO_idGENERO = model.GENERO_idGENERO
            };
        }
    }
}
