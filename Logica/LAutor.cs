using Data;
using LinqToDB;
using Logica.Library;
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
