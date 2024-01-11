using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.MVVM.Sql.Modle
{
    public class ResturantBookmark
    {
        [PrimaryKey, AutoIncrement, Column("Fld_bookmarkID")]
        public int Id { get; set; }

        [Column("Fld_bookmark_UserId")]
        public int UserId { get; set; }

        [Column("Fld_bookmark_ResturantName")]
        public string ResturantName { get; set; }

        [Column("Fld_bookmark_ResturantID")]
        public int ResturantID { get; set; }
    }
}
