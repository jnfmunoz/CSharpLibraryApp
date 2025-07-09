using Data;
using LinqToDB;
using LinqToDB.DataProvider.DB2;
using Logica.Library;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LGenero : Librarys
    {
        private DataGridView _dataGridView;
        private String _action = "insert";
        private int _idGenero = 0;

        public int IdGenero
        {
            get => _idGenero;
            set => _idGenero = value;
        }
      
        public LGenero() { }       

        public LGenero(object[] objetos)
        {
            _dataGridView = (DataGridView)objetos[0];            

        }

        public async Task ListGeneroAsync()
        {
            try
            {
                using (var db = new Conexion())
                {
                    var list = await (from g in db.GetTable<Genero>()
                                orderby g.idGENERO
                                select new
                                {
                                    ID = g.idGENERO,
                                    Genero = g.nombre
                                }).ToListAsync();

                    _dataGridView.DataSource = list;

                    foreach (DataGridViewColumn col in _dataGridView.Columns)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Géneros" + ex.Message);
            }
        }

        public async Task SearchGeneroAsync(string field)
        {
            using (var db = new Conexion())
            {
                var query = (from g in db.GetTable<Genero>()
                             orderby g.idGENERO
                             select new
                             {
                                 ID = g.idGENERO,
                                 Genero = g.nombre
                             });

                if (!string.IsNullOrWhiteSpace(field))
                {
                    query = query.Where(g => g.ID.ToString().StartsWith(field)
                                            || g.Genero.StartsWith(field));
                }

                var result = await query.ToListAsync();

                _dataGridView.DataSource = result;

                /* esta funcion la podria hacer global asi como las validaciones */
                foreach (DataGridViewColumn col in _dataGridView.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

            }

        }

        public async Task SaveGeneroAsync(string nombre)
        {
            using (var db = new Conexion())
            {
                var existeDuplicado = await db.GetTable<Genero>()
                    .AnyAsync(g => g.nombre == nombre && g.idGENERO != _idGenero);

                if (existeDuplicado)
                {
                    MessageBox.Show("Ya existe otro género con ese nombre.");
                    return;
                }

                await db.BeginTransactionAsync();

                try
                {
                    switch (_action)
                    {
                        case "insert":
                            await db.GetTable<Genero>()
                                .Value(g => g.nombre, nombre)
                                .InsertAsync();
                            break;

                        case "update":
                            await db.GetTable<Genero>()
                                .Where(g => g.idGENERO == _idGenero)
                                .Set(g => g.nombre, nombre)
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

        private void GetGeneroSelected()
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

        public async Task DeleteGeneroAsync()
        {
            GetGeneroSelected();

            if (_Genero.Equals(0))
            {
                MessageBox.Show("Seleccione un género");
            }
            else
            {
                if (MessageBox.Show("Estás seguro de eliminar el género?",
                    "Eliminar Editorial",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new Conexion())
                    {
                        await _Genero.Where(g => g.idGENERO.Equals(_idGenero)).DeleteAsync();
                    }

                }

                await ListGeneroAsync();
            }
        }

        public void ChangeAction(string action)
        {
            _action = action;
        }

    }
}
