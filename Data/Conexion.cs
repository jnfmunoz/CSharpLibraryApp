﻿using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Conexion : LinqToDB.Data.DataConnection
    {
        public Conexion(): base("MySQL") {  }
        public ITable<Pais> _Pais => this.GetTable<Pais>();
        public ITable<Editorial> _Editorial => this.GetTable<Editorial>();
        public ITable<Genero> _Genero => this.GetTable<Genero>();
        public ITable<Autor> _Autor => this.GetTable<Autor>();
        public ITable<Libro> _Libro => this.GetTable<Libro>();
        public ITable<LibroAutor> _LibroAutor => this.GetTable<LibroAutor>();

    }
}
