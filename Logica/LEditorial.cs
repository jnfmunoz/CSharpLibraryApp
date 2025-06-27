using Data;
using LinqToDB;
using Logica.Library;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LEditorial : Librarys
    {
        private DataGridView _dataGridView;

        public LEditorial(object[] objetos)
        {
            _dataGridView = (DataGridView)objetos[0];
        }

        public void ListEditorial()
        {
            try 
            {            
                using (var db = new Conexion())
                {
                    var list = (from e in db.GetTable<Editorial>()
                                join p in db.GetTable<Pais>()
                                on e.PAIS_idPAIS equals p.idPAIS
                                select new
                                {
                                    ID = e.idEDITORIAL,
                                    Editorial = e.nombre,
                                    Pais = p.nombre
                                }).ToList();

                    _dataGridView.DataSource = list;
                }
            }
            catch (Exception ex) { 
                MessageBox.Show("Error al listar editoriales: " + ex.Message);
            }
        }

        public void GetEditorial()
        {
            return;
        }



    }
}
