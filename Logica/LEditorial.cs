using Data;
using LinqToDB;
using LinqToDB.SqlQuery;
using Logica.DTOs;
using Logica.Helpers;
using Logica.Library;
using Logica.ViewModels;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LEditorial : Librarys
    {
        private DataGridView _dataGridView;
        private String _action = "insert";
        private int _idEditorial = 0;

        public int idEditorial
        {
            get => _idEditorial;
            set => _idEditorial = value;
        }

        public LEditorial() { }
        public LEditorial(object[] obj)
        {
            _dataGridView = (DataGridView)obj[0];
        }

        private async Task<List<EditorialDTO>> GetEditorialesAsync(Conexion db)
        {
            var rawData = await (from e in db.GetTable<Editorial>()
                                 join p in db.GetTable<Pais>()
                                 on e.PAIS_idPAIS equals p.idPAIS
                                 select new
                                 {
                                     e.idEDITORIAL,
                                     e = e.nombre,
                                     p = p.nombre
                                 }).ToListAsync();
            var result = rawData
                .GroupBy(x => new
                {
                    x.idEDITORIAL,
                    x.e,
                    x.p
                })
                .Select(group => new EditorialDTO
                {
                    ID = group.Key.idEDITORIAL,
                    Editorial = group.Key.e,
                    Pais = group.Key.p
                })
                .ToList();

            return result;
        }

        public async Task ListEditorialAsync()
        {
            try
            {
                using (var db = new Conexion())
                {
                    var list = await GetEditorialesAsync(db);

                    _dataGridView.DataSource = list;
                    _dataGridView.Columns["Pais"].HeaderText = "País";

                    DataGridViewHelper.AutoResizeColumns(_dataGridView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar editoriales: " + ex.Message);
            }
        }

        public async Task SearchEditorialAsync(string field)
        {
            try
            {
                using (var db = new Conexion())
                {
                    var editoriales = await GetEditorialesAsync(db);

                    if (!string.IsNullOrWhiteSpace(field))
                    {
                        if (!string.IsNullOrEmpty(field))
                        {
                            editoriales = editoriales
                                .Where(e =>
                                       e.ID.ToString().Contains(field) || 
                                       e.Editorial != null && e.Editorial.ToLower().Contains(field) ||
                                       e.Pais != null && e.Pais.ToLower().Contains(field))
                                .ToList();
                        }
                        _dataGridView.DataSource = editoriales;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar editoriales: " + ex.Message);
            }
        }

        public async Task SaveEditorialAsync(EditorialInputModel input)
        {
            /* aqui quedé 
             * nota: revisar el método buscar, con el fin de que cuando el textbox vuelva
             * a quedar vacío se pueda reiniciar ListXXXXAsync ✔
             */
        }

        public List<Editorial> GetEditoriales()
        {
            using (var db = new Conexion())
            {
                return db.GetTable<Editorial>().ToList();
            }
        }

    }
}
