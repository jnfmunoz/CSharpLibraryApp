using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Helpers
{
    public static class NavigationHelper
    {
        public static void BackTo(Form currentForm, Form targetForm)
        {
            currentForm.Hide();
            targetForm.Show();
        }
    }
}
