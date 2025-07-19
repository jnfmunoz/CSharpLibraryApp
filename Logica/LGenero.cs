using Data;
using LinqToDB;
using Logica.DTOs;
using Logica.Library;
using Org.BouncyCastle.Crypto.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LGenero : Librarys
    {
        private DataGridView _dataGridView;
        private String _action = "insert";
        private int _idGenero = 0;

        public int idGenero
        {
            get => _idGenero;
            set => _idGenero = value;
        }

        public LGenero() { }

        public LGenero(object[] obj) 
        {
            _dataGridView = (DataGridView)obj[0];
        }

        private async Task<List<GeneroDTO>> GetGenerosAsync(Conexion db)
        {
            var rawData = await (from g in db.GetTable<Genero>()
                                 select new
                                 {
                                     g.idGENERO,
                                     g.nombre
                                 })
                                 .ToListAsync();

            var result = rawData
                        .GroupBy(x => new
                        {
                            x.idGENERO,
                            x.nombre
                        })
                        .Select(group => new GeneroDTO
                        {
                            ID = group.Key.idGENERO,
                            Genero = group.Key.nombre
                        })
                        .ToList();
            return result;
        }

        public async Task ListGeneroAsync()
        {
            try
            {
                using (var db = new Conexion())
                {
                    var list = await GetGenerosAsync(db);

                    _dataGridView.DataSource = list;

                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}