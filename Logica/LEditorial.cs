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
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar editoriales: " + ex.Message);
            }
        }

        public async Task SaveEditorialAsync(EditorialInputModel input)
        {
            using (var db = new Conexion())
            {
                await db.BeginTransactionAsync();
            
                try
                {
                    switch (_action)
                    {
                        case "insert":
                            await db.GetTable<Editorial>()
                                .Value(e => e.nombre, input.Editorial)
                                .Value(e => e.PAIS_idPAIS, input.Pais)
                                .InsertAsync();
                            break;
                        case "update":
                            await db.GetTable<Editorial>()
                                .Where(e => e.idEDITORIAL == _idEditorial)
                                .Set(e => e.nombre, input.Editorial)
                                .Set(e => e.PAIS_idPAIS, input.Pais)
                                .UpdateAsync();
                            break;
                    }
                    await db.CommitTransactionAsync();
                    MessageBox.Show("Editorial guardada exitosamente.");
                }
                catch (Exception ex)
                {
                    await db.RollbackTransactionAsync();
                    MessageBox.Show("Error al guardar editorial: " + ex.Message);
                }
            }
        }

        public async Task DeleteEditorialAsync()
        {
            GetEditorialSelected();

            if (_idEditorial.Equals(0))
            {
                MessageBox.Show("Seleccione una editorial!");
            }
            else
            {
                if(MessageBox.Show("Estás seguro de eliminar la editorial?",
                        "Eliminar Editorial",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new Conexion())
                    {
                        await _Editorial
                            .Where(e => e.idEDITORIAL.Equals(_idEditorial))
                            .DeleteAsync();
                    }
                }
                await ListEditorialAsync();
            }
        }

        public List<Editorial> GetEditoriales()
        {
            using (var db = new Conexion())
            {
                return db.GetTable<Editorial>().ToList();
            }
        }

        public Editorial GetEditorial(int idEditorial)
        {
            using (var db = new Conexion())
            {
                return db._Editorial.FirstOrDefault(e => e.idEDITORIAL == idEditorial);
            }
        }

        public void GetEditorialSelected()
        {
            if (_dataGridView.CurrentRow != null)
            {
                _idEditorial = Convert.ToInt32(_dataGridView.CurrentRow.Cells[0].Value);
            }
            else
            {
                _idEditorial = 0;
            }
        }

        public void ChangeAction(string action)
        {
            _action = action;
        }

    }
}
