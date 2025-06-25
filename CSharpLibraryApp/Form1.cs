using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProbarConexion();
        }

        private void ProbarConexion()
        {
            try
            {
                using (var db = new Conexion())
                {
                    var paises = db._Pais.ToList();

                    if (paises.Any())
                    {
                        MessageBox.Show("Conexión exitosa. Hay países en la base de datos.");
                    }
                    else
                    {
                        MessageBox.Show("Conexión exitosa, pero la tabla PAIS está vacía.");
                    }
                }
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException != null ? ex.InnerException.Message : "Sin excepción interna.";
                MessageBox.Show("Error al conectar: " + ex.Message +
                                "\n\nExcepción interna: " + inner +
                                "\n\nStackTrace: " + ex.StackTrace);
            }


        }

    }
}
