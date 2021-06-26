using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WhatAppPlus.LocalDatabase
{
    public class SqliteDatabase
    {
        private SQLite.SQLiteOpenFlags flags =
            SQLite.SQLiteOpenFlags.ReadWrite | SQLite.SQLiteOpenFlags.Create | SQLite.SQLiteOpenFlags.SharedCache;

        //private string DatabaseName;

        private string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        private SQLiteAsyncConnection Database;

        public SqliteDatabase(string name)
        {
            Database = new SQLiteAsyncConnection(Path.Combine(path, string.Format("{0}.db3", name)));
        }



    }
}
