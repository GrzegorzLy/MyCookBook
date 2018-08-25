using MyCookBook.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCookBook.Data
{
    public class LocalDB
    {
        readonly SQLiteAsyncConnection database;

        public LocalDB(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Recipe>().Wait();
            database.CreateTableAsync<Igredient>().Wait();
        }

        public async Task<List<T>> GetItems<T>() where T : class, new()
        {
            return await database.Table<T>().ToListAsync();
        }

        public async Task<T> GetItemByID<T>(int id) where T : class, ISqlModel, new()
        {
            return await database.Table<T>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveItem<T>(T item)
        {
            var result = await database.UpdateAsync(item);

            if (result == 0)
                result = await database.InsertAsync(item);
            
            return result;
        }

        public async Task<int> DeleteItem<T>(T item)
        {
            return await database.DeleteAsync(item);
        }

        public void Drop<T>() where T : class, new()
        {
            database.ExecuteAsync("Truncate table RECIPE");
        }
    }
}
