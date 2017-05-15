using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace ToDoListApp
{
    public class ToDoItemDatabase
    {
        readonly SQLiteAsyncConnection database;

        public ToDoItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<ToDoList>().Wait();
        }

        public Task<List<ToDoList>> GetItemsAsync()
        {
            return database.Table<ToDoList>().ToListAsync();
        }

        public Task<List<ToDoList>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<ToDoList>("SELECT * FROM [ToDoList] WHERE [Done] = 0");
        }

        public Task<ToDoList> GetItemAsync(int id)
        {
            return database.Table<ToDoList>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(ToDoList item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(ToDoList item)
        {
            return database.DeleteAsync(item);
        }
    }
}

