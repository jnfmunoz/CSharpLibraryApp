using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.ViewModels
{
    public class GeneroInputModel
    {
        public int ID { get; set; }
        public string Genero { get; set; }
        public string Action { get; set; }
        public void ChangeAction(string action)
        {
            Action = action;
        }

    }
}
