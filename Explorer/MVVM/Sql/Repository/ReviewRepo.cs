
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
    public class ReviewRepo : IDisposable
    {

        SQLiteConnection connection;
        public SQLiteConnection connectionData { get; set; }
        public string StatusMessage { get; set; }

        public ReviewRepo()
        {
            // AddSingelton &  App 
            connection = new SQLiteConnection(Constants.DataPath, Constants.Flags);
            connection.CreateTable<ReviewsModel>();
            connectionData = connection;
        }
        public void Add(ReviewsModel item)
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

        public void Update(ReviewsModel item)
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
        public List<ReviewsModel> GetAll()
        {
            try
            {
                return connection.Table<ReviewsModel>().ToList();
            }
            catch (Exception ex)
            {

                StatusMessage = $"{ex.Message} !!خطا ";
            }
            return null;
        }
        //public List<QC_SQL_QualityControl> GetAllByID(int ID)
        //{
        //    try
        //    {
        //        return connection.Table<QC_SQL_QualityControl>().Take(ID).OrderBy(x => x.DocumentTempDtl_ID).ToList();

        //    }
        //    catch (Exception ex)
        //    {

        //        StatusMessage = $"{ex.Message} !!خطا ";
        //    }
        //    return null;
        //}

        public ReviewsModel GetByID(int ID)
        {
            try
            {
                return connection.Table<ReviewsModel>().FirstOrDefault(x => x.Id == ID);
            }
            catch (Exception ex)
            {

                StatusMessage = $"{ex.Message} !!خطا ";
            }
            return null;
        }

        //public int getMaxID()
        //{
        //    try
        //    {
        //        return connection.Table<QC_SQL_Components>().Max(x => x.Component_ID) + 1;
        //    }
        //    catch
        //    {
        //        return 1;
        //    }
        //}

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



