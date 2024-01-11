using SQLite;


namespace Explorer.DataBase
{
    public class Constants
    {
        private const string DBFileName = "Explorerdb.db3";
        public const SQLiteOpenFlags Flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache;
        public static string DataPath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }

    }
}
