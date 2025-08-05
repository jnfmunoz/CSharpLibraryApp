using Data;
using LinqToDB;
using Logica.DTOs;
using Logica.Helpers;
using Logica.Library;
using Logica.ViewModels;
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
                    DataGridViewHelper.SetupDataGridViewDefaults(_dataGridView);
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

        public async Task SaveGeneroAsync(GeneroInputModel input)
        {
            using (var db = new Conexion())
            {
                await db.BeginTransactionAsync();
                try
                {
                    switch (_action)
                    {
                        case "insert":
                            await db.GetTable<Genero>()
                                    .Value(g => g.nombre, input.Genero)
                                    .InsertAsync();
                            break;
                        case "update":
                            await db.GetTable<Genero>()
                                    .Where(g => g.idGENERO == _idGenero)
                                    .Set(g => g.nombre, input.Genero)
                                    .UpdateAsync();
                            break;
                    }

                    await db.CommitTransactionAsync();
                    MessageBox.Show("Género guardado exitosamente.");
                }
                catch (Exception ex)
                {
                    await db.RollbackTransactionAsync();
                    MessageBox.Show("Error al guardar género: " + ex.Message);
                }
            }
        }

        public async Task DeleteGeneroAsync()
        {
            GetGeneroSelected();
            if (_idGenero.Equals(0))
            {
                MessageBox.Show("Seleccione un género!");
            }
            else
            {
                if (MessageBox.Show("Está seguro de eliminar el género?",
                    "Eliminar género",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new Conexion())
                    {
                        await _Genero
                                .Where(g => g.idGENERO.Equals(_idGenero))
                                .DeleteAsync();
                    }
                }

                await ListGeneroAsync();
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

        public void GetGeneroSelected()
        {
            if (_dataGridView.CurrentRow != null)
            {
                _idGenero = Convert.ToInt32(_dataGridView.CurrentRow.Cells[0].Value);
            }
            else
            {
                _idGenero = 0;
            }
        }

        public void ChangeAction(string action)
        {
            _action = action;
        }
    }
}