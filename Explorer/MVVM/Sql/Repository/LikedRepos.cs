
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
    public class LikedRepos : IDisposable
    {

        SQLiteConnection connection;
        public SQLiteConnection connectionData { get; set; }
        public string StatusMessage { get; set; }

        public LikedRepos()
        {
            // AddSingelton &  App 
            connection = new SQLiteConnection(Constants.DataPath, Constants.Flags);
            connection.CreateTable<LikedModel>();
            connectionData = connection;
        }
        public void Add(LikedModel item)
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
       
        public void Update(LikedModel item)
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
        public List<LikedModel> GetAll()
        {
            try
            {
                return connection.Table<LikedModel>().ToList();
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

        public LikedModel GetByID(int ID)
        {
            try
            {
                return connection.Table<LikedModel>().FirstOrDefault(x => x.Id == ID);
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



