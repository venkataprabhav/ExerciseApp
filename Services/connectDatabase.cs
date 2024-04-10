using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6002CEM_BohdanYermakov.Services
{
    public class connectDatabase
    {
        private readonly SQLiteConnection _database;

        public static string dbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "users.db"); 

        public connectDatabase()
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<User>();  
        }

        public List<User> List()
        {
            return _database.Table<User>().ToList();    
        }
    }
}
