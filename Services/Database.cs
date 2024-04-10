using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6002CEM_BohdanYermakov.Services
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);      
            _database.CreateTableAsync<User>();     

    

            var newUser = new User { Email = "b@gmail.com", Password = "b" };  
            _database.InsertAsync(newUser);

        }


        public Task<List<User>> GetUsersAsync()     
        {
            return _database.Table<User>().ToListAsync();
        }

        public Task<List<User>> GetEmailAsync(string email) 
        {
            return _database.Table<User>().Where(u => u.Email == email).ToListAsync();
        }

        public Task<int> AddUsersAsync(User user)       
        {
            return _database.InsertAsync(user);
        }


    }
}
