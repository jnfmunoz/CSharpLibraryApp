using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLibraryApp.Helpers
{
    public class LabelHelper
    {
        public static void BindClickToButton(Label label, Button button)
        {
            label.Click += (s, e) => button.PerformClick();
        }

        public static void BindClickAndFocus(Label label, Button button)
        {
            label.MouseDown += (s, e) =>
            {
                button.PerformClick();
                button.Focus();
            };
        }

    }
}
