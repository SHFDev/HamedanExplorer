
using Explorer.DataBase;
using Explorer.MVVM.Sql.Modle;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.MVVM.Sql.Repository
{
    public class BookMarkedRepos : IDisposable
    {

        SQLiteConnection connection;
        public SQLiteConnection connectionData { get; set; }
        public string StatusMessage { get; set; }

        public BookMarkedRepos()
        {
            // AddSingelton &  App 
            connection = new SQLiteConnection(Constants.DataPath, Constants.Flags);
            connection.CreateTable<ResturantBookmark>();
            connectionData = connection;
        }
        public void Add(ResturantBookmark item)
        {

            int result = 0;
            try
            {
                result = connection.Insert(item);
                StatusMessage = $"{result} با موفیت اضافه شد";

            }
            catch (Exception ex)
            {
                StatusMessage = $"!! خطا : {ex.Message}";
            }
        }
       
        public void Update(ResturantBookmark item)
        {
            int result = 0;
            try
            {
                result = connection.Update(item);
                StatusMessage = $"{result} با موفیت به روز رسانی شد";
            }
            catch (Exception ex)
            {
                StatusMessage = $"!! خطا  {ex.Message}";
            }
        }
        public List<ResturantBookmark> GetAll()
        {
            try
            {
                return connection.Table<ResturantBookmark>().ToList();
            }
            catch (Exception ex)
            {

                StatusMessage = $"{ex.Message} !!خطا ";
            }
            return null;
        }

        public ResturantBookmark GetByID(int ID)
        {
            try
            {
                return connection.Table<ResturantBookmark>().FirstOrDefault(x => x.Id == ID);
            }
            catch (Exception ex)
            {

                StatusMessage = $"{ex.Message} !!خطا ";
            }
            return null;
        }

        public void Delete(int id)
        {
            try
            {
                var ID = GetByID(id);
                connection.Delete(ID);
            }
            catch (Exception ex)
            {

                StatusMessage = $"{ex.Message} !!خطا ";
            }
        }

        public void Dispose()
        {
            connection.Dispose();
        }

    }
}



