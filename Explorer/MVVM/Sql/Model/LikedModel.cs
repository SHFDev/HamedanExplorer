using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.MVVM.Sql.Modle
{
    [Table("Tbl_Liked")]
    public class LikedModel
    {
        [PrimaryKey,AutoIncrement, Column("Fld_Liked_ID")]
        public int Id { get; set; }
       
        [Column("Fld_Liked_ResturantName")]

        public string ResturantName { get; set; }
       
        [ Column("Fld_Liked_UserID")]

        public int UserID { get; set; }
       
        [ Column("Fld_Liked_ResturantID")]

        public int ResturantID { get; set; }
    }
}
