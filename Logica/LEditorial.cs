using Data;
using LinqToDB;
using LinqToDB.SqlQuery;
using Logica.DTOs;
using Logica.Library;
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

                    foreach (DataGridViewColumn col in _dataGridView.Columns)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
