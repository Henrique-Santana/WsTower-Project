using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project_Grupo6.Models
{
    public class Database
    {
        static SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Usuario>().Wait();

        }
        public Task<List<Usuario>> GetUsuarioAsync()
        {
            return _database.Table<Usuario>().ToListAsync();
        }

        public Task<int> SaveUsuarioAsync(Usuario usuario)
        {
            return _database.InsertAsync(usuario);
        }
    }
}
