using Data;
using LinqToDB;
using Logica.DTOs;
using Logica.Helpers;
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
                    DataGridViewHelper.RenameHeaderTextGenero(_dataGridView);
                    DataGridViewHelper.AutoResizeColumns(_dataGridView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar géneros: " + ex.Message);
            }
        }

        public async Task SearchGeneroAsync(string field)
        {
            try
            {
                using (var db = new Conexion())
                {
                    var generos = await GetGenerosAsync(db);

                    if(!string.IsNullOrWhiteSpace(field))
                    {
                        generos = generos
                                  .Where(g => 
                                    g.ID.ToString().Contains(field) ||
                                    (g.Genero != null && g.Genero.ToLower().Contains(field.ToLower())))
                                  .ToList();
                    }

                    _dataGridView.DataSource = generos;
                    DataGridViewHelper.RenameHeaderTextGenero(_dataGridView);
                    DataGridViewHelper.AutoResizeColumns(_dataGridView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar Género: " + ex.Message);
            }
        }

        public Genero GetGenero (int idGenero)
        {
            using (var db = new Conexion())
            {
                return db._Genero.FirstOrDefault(g => g.idGENERO == idGenero);
            }
        }

        public List <Genero> GetGeneros()
        {
            using (var db = new Conexion())
            { 
                return db.GetTable<Genero>().ToList();
            }
        }

        public void ChangeAction(string action)
        {
            _action = action;
        }
    }
}