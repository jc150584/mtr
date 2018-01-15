using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using Xamarin.Forms;

namespace MuscleTrainingRecords00.sqlite
{
    class TrainingDatabase
    {

        readonly SQLiteAsyncConnection database;

        public TrainingDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Training>().Wait();
        }

        public Task<List<Training>> GetItemsAsync()
        {
            return database.Table<Training>().ToListAsync();
        }


        /***
        public Task<List<Training>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Training>("SELECT * FROM [Training] WHERE [Done] = 0 "
                                                  + " order by [Created] desc"
                                                );
        }
        ***/

        public Task<Training> GetItemAsync(String menu)
        {
            return database.Table<Training>().Where(i => i.Menu == menu).FirstOrDefaultAsync();
        }
        public Task<List<Training>> GetItemsAsyncByParts(String parts)
        {
            return database.Table<Training>().Where(i => i.parts == parts).ToListAsync();
        }


        public Task<int> SaveItemAsync(Training item)
        {
            if (item.Menu != "")
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> InsertItemAsync(Training item)
        {
            return database.InsertAsync(item);
        }

        public Task<int> DeleteItemAsync(Training item)
        {
            return database.DeleteAsync(item);
        }

        private static TrainingDatabase db = null;

        public static TrainingDatabase getDatabase()
        {
            if (db == null)
            {
//                db = new TrainingDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("TrainingSQLite.db3"));
                db = new TrainingDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoSQLite.db3"));

            }
            return db;
        }
    }
}