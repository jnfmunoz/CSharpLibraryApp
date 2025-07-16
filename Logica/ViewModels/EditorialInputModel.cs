using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.ViewModels
{
    public class EditorialInputModel
    {
        public int ID { get; set; }
        public string Editorial { get; set; }
        public int Pais { get; set; }
        public string Action {  get; set; }
        public void ChangeAction(string action)
        {
            Action = action;
        }

    }
}
