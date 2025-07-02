using Data;
using LinqToDB;
using LinqToDB.DataProvider.DB2;
using Logica.Library;
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

        protected Conexion _db;

        public LGenero(object[] objetos)
        {
            _dataGridView = (DataGridView)objetos[0];
            _db = new Conexion();

        }
        public LGenero()
        {
            _db = new Conexion();
        }

        public void ListGenero()
        {
            try
            {
                using (var db = new Conexion())
                {
                    var list = (from g in db.GetTable<Genero>()
                                orderby g.idGENERO
                                select new
                                {
                                    ID = g.idGENERO,
                                    Genero = g.nombre
                                }).ToList();

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

        public void SearchGenero(string field)
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

                var result = query.ToList();

                _dataGridView.DataSource = result;

                /* esta funcion la podria hacer global asi como las validaciones */
                foreach (DataGridViewColumn col in _dataGridView.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

            }

        }

        public void SaveGenero(string nombre)
        {
            /* esta funcion la podria hacer global asi como las validaciones */
            //var existeDuplicado = _db.GetTable<Genero>()
            //                    .Any(g => g.nombre == nombre && g.idGENERO != _idGenero);

            //if (existeDuplicado)
            //{
            //    MessageBox.Show("Ya existe otro género con ese nombre.");
            //    return;
            //}

            using (var db = new Conexion())
            {
                var existeDuplicado = db.GetTable<Genero>()
                    .Any(g => g.nombre == nombre && g.idGENERO != _idGenero);

                if (existeDuplicado)
                {
                    MessageBox.Show("Ya existe otro género con ese nombre.");
                    return;
                }
            }

            _db.BeginTransactionAsync();

            try
            {
                switch (_action)
                {
                    case "insert":
                        _db.GetTable<Genero>()
                            .Value(g => g.nombre, nombre)
                            .Insert();
                        break;

                    case "update":
                        _db.GetTable<Genero>()
                            .Where(g => g.idGENERO == _idGenero)
                            .Set(g => g.nombre, nombre)
                            .Update();
                        break;
                }

                _db.CommitTransaction();
                MessageBox.Show("Género guardado exitosamente.");

            }
            catch (Exception ex)
            {
                _db.RollbackTransaction();
                MessageBox.Show("Error al guardar género: " + ex.Message);
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

        public void DeleteGenero()
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
                    _Genero.Where(g => g.idGENERO.Equals(_idGenero)).Delete();

                }

                ListGenero();
            }

        }



    }
}
