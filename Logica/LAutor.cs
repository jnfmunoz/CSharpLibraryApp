using Data;
using LinqToDB;
using LinqToDB.SqlQuery;
using Logica.Library;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LAutor : Librarys
    {
        private DataGridView _dataGridView;
        private String _action = "insert";
        private int _idAutor= 0;

        public int IdAutor
        {
            get => _idAutor;
            set => _idAutor = value;
        }

        public LAutor () { }

        public LAutor(object[] objetos)
        {
            _dataGridView = (DataGridView)objetos[0];
        }

        public async Task ListAutorAsync()
        {
            try
            {
                using (var db = new Conexion())
                {
                    var list = await (from a in db.GetTable<Autor>()
                                      join p in db.GetTable<Pais>()
                                        on a.PAIS_idPAIS equals p.idPAIS
                                      orderby a.idAUTOR
                                      select new
                                      {
                                          ID = a.idAUTOR,
                                          a.nombre,
                                          a.fecha_nacimiento,
                                          nacionalidad = p.nombre
                                      }).ToListAsync();

                    _dataGridView.DataSource = list;

                    foreach (DataGridViewColumn col in _dataGridView.Columns)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al listar Autores" + ex.Message); 
            }

        }

        public async Task SearchAutorAsync(string field)
        {
            using (var db = new Conexion())
            {
                var query = (from a in db.GetTable<Autor>()
                             join p in db.GetTable<Pais>()
                                on a.PAIS_idPAIS equals p.idPAIS
                             orderby a.idAUTOR                                
                             select new
                             {
                                ID = a.idAUTOR,
                                Nombre = a.nombre,
                                Fecha_Nacimiento = a.fecha_nacimiento,
                                Nacionalidad = p.nombre

                             });
                if (!string.IsNullOrWhiteSpace(field))
                {
                    query = query.Where(a => a.ID.ToString().StartsWith(field)
                                            || a.Nombre.StartsWith(field)
                                            || a.Nacionalidad.StartsWith(field));
                }

                var result = await query.ToListAsync();

                _dataGridView.DataSource = result;

                foreach (DataGridViewColumn col in _dataGridView.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void GetAutorSelected()
        {
            if(_dataGridView.CurrentRow != null)
            {
                _idAutor = Convert.ToInt32(_dataGridView.CurrentRow.Cells[0].Value);
            }
            else
            {
                _idAutor = 0;
            }
        }

        public async Task SaveAutorAsync(string nombre, DateTime fecha_nacimiento, int idPais)
        {
            using (var db = new Conexion())
            {              
                var existeDuplicado = await db.GetTable<Autor>()
                    .AnyAsync(a => a.idAUTOR == _idAutor && a.nombre == nombre);

                if (existeDuplicado)
                {
                    MessageBox.Show("Ya existe un autor con ese nombre.");
                    return;
                }

                await db.BeginTransactionAsync();

                try
                {
                    switch (_action)
                    {
                        case "insert":
                            await db.GetTable<Autor>()
                                .Value(a => a.nombre, nombre)
                                .Value(a => a.fecha_nacimiento, fecha_nacimiento)
                                .Value(a => a.PAIS_idPAIS, idPais)
                                .InsertAsync();
                            break;
                        case "update":
                            await db.GetTable<Autor>()
                                .Where(a => a.idAUTOR== _idAutor)
                                .Set(a => a.nombre, nombre)
                                .Set(a => a.fecha_nacimiento, fecha_nacimiento)
                                .Set(a => a.PAIS_idPAIS, idPais)
                                .UpdateAsync();
                            break;
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        public async Task DeleteAutorAsync()
        {
            GetAutorSelected();

            if(_Autor.Equals(0))
            {
                MessageBox.Show("Seleccion un autor");
            }
            else
            {
                if (MessageBox.Show("Estás seguro de eliminar este autor?",
                    "Eliminar Autor",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new Conexion())
                    {
                        await _Autor.Where(a => a.idAUTOR.Equals(_idAutor)).DeleteAsync();
                    }
                }

                await ListAutorAsync();
            }

        }

        public void ChangeAction(string action)
        {
            _action = action;
        }

    }
}
