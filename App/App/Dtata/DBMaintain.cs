using App.Models;
using SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Dtata
{
    public class DBMaintain
    {
        public SQLiteAsyncConnection dbConn;

        public DBMaintain(string dbPath)
        {
            //若不存在則自動建立資料庫，若已經存在則自動載入資料庫
            dbConn = new SQLiteAsyncConnection(dbPath);
            dbConn.CreateTableAsync<CustomerModel>();
            dbConn.CreateTableAsync<ItemModel>();
        }

        //public async Task<List<T>> ExecuteQueryAsync<T>(int index, string sql)
        //{
        //    switch (index)
        //    {
        //        case 0:
        //            return await dbConn.QueryAsync<CustomerModel>(sql);
        //            break;
        //    }

        //}
        public Task<List<CustomerModel>> GetCustomerAsync()
        {
            return dbConn.Table<CustomerModel>().ToListAsync();
        }

        public Task<CustomerModel> GetCustomerAsync(int id)
        {
            return dbConn.Table<CustomerModel>()
                         .Where(i => i.ID == id)
                         .FirstOrDefaultAsync();
        }

        public Task<List<ItemModel>> GetItemAsync()
        {
            return dbConn.Table<ItemModel>().ToListAsync();
        }
        public Task<ItemModel> GetItemAsync(int id)
        {
            return dbConn.Table<ItemModel>().FirstOrDefaultAsync();
        }

        public Task<int> SaveCustomerAsync(CustomerModel cust)
        {
            if (cust.ID != 0)
                return dbConn.UpdateAsync(cust);
            else
            {
                //var result = dbConn.ExecuteAsync("select * from CustomerModel where Name = '" + cust.Name + "'");
                //if (result.AsyncState == null)
                    return dbConn.InsertAsync(cust);
            }
        }
        //public Task<int> SaveCustomerAsync(CustomerModel cust)
        //{
        //    if (cust.ID != 0)
        //        return dbConn.UpdateAsync(cust);
        //    else
        //        return dbConn.InsertAsync(cust);
        //}

        public Task<int> DeleteNoteAsync(CustomerModel cust)
        {
            return dbConn.DeleteAsync(cust);
        }
    }
}
