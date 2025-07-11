﻿using Data;
using LinqToDB;
using LinqToDB.SqlQuery;
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

        public int IdEditorial
        {
            get => _idEditorial;
            set => _idEditorial = value;
        }

        protected Conexion _db;

        public LEditorial(object[] objetos)
        {
            _dataGridView = (DataGridView)objetos[0];
            _db = new Conexion();
        }
        
        public LEditorial()
        {
            _db = new Conexion();
        }

        public void ListEditorial()
        {
            try 
            {            
                using (var db = new Conexion())
                {
                    var list = (from e in db.GetTable<Editorial>()
                                join p in db.GetTable<Pais>()
                                on e.PAIS_idPAIS equals p.idPAIS
                                select new
                                {
                                    ID = e.idEDITORIAL,
                                    Editorial = e.nombre,
                                    Pais = p.nombre
                                }).ToList();

                    _dataGridView.DataSource = list;

                    foreach (DataGridViewColumn col in _dataGridView.Columns)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception ex) { 
                MessageBox.Show("Error al listar editoriales: " + ex.Message);
            }
        }       

        public void SearchEditorial(string field)
        {
            using (var db = new Conexion())
            {
                var query = (from e in db.GetTable<Editorial>()
                            join p in db.GetTable<Pais>()
                            on e.PAIS_idPAIS equals p.idPAIS
                            select new
                            {
                                ID = e.idEDITORIAL,
                                Editorial = e.nombre,
                                Pais = p.nombre
                            });

                if (!string.IsNullOrWhiteSpace(field))
                {
                    query = query.Where(e => e.ID.ToString().StartsWith(field)
                                           || e.Editorial.StartsWith(field)
                                           || e.Pais.StartsWith(field));
                }

                var result = query.ToList();

                _dataGridView.DataSource = result;
                
                foreach (DataGridViewColumn col in _dataGridView.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }


        public void SaveEditorial(string nombre, int idPais)
        {            
            var existeDuplicado = _db.GetTable<Editorial>()
                .Any(e => e.nombre == nombre && e.idEDITORIAL != _idEditorial);

            if (existeDuplicado)
            {
                MessageBox.Show("Ya existe otra editorial con ese nombre.");
                return;
            }

            _db.BeginTransactionAsync();
            try
            {
                switch (_action)
                {
                    case "insert":
                        _db.GetTable<Editorial>()
                            .Value(e => e.nombre, nombre)
                            .Value(e => e.PAIS_idPAIS, idPais)
                            .Insert();
                        break;

                    case "update":
                        _db.GetTable<Editorial>()
                            .Where(e => e.idEDITORIAL == _idEditorial)
                            .Set(e => e.nombre, nombre)
                            .Set(e => e.PAIS_idPAIS, idPais)
                            .Update();
                        break;

                }

                _db.CommitTransaction();
                MessageBox.Show("Editorial guardada exitosamente.");
            }
            catch (Exception ex)
            {
                _db.RollbackTransaction();
                MessageBox.Show("Error al guardar editorial: " + ex.Message);
            }
        }

        private void GetEditorialSelected()
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

        public void DeleteEditorial()
        {
            GetEditorialSelected();

            if (_Editorial.Equals(0))
            {
                MessageBox.Show("Seleccione una editorial!");
            }
            else
            {
                if (MessageBox.Show("Estás seguro de eliminar la editorial?",
                    "Eliminar Editorial",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _Editorial.Where(e => e.idEDITORIAL.Equals(_idEditorial)).Delete();

                }
                ListEditorial();
            }
        }

        public void ChangeAction(string action)
        {
            _action = action;
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
