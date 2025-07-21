using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.ViewModels
{
    public class LibroInputModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public int AnioPublicacion { get; set; }
        public string Sinopsis { get; set; }
        public int EDITORIAL_idEDITORIAL { get; set; }
        public int GENERO_idGENERO { get; set; }
        public string Action { get; private set; }
        public void ChangeAction(string action)
        {
            Action = action;
        }

    }
}