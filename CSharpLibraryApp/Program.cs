using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLibraryApp.Autor

{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormGeneros());
            Application.Run(new FormAutores());
            //Application.Run(new FormEditoriales());
            //Application.Run(new FormLibros());
        }
    }
}
