using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.MVVM.Sql.Modle
{
    public class UserModel
    {
        [PrimaryKey, AutoIncrement, Column("Fld_UserID")]
        public int Id { get; set; }


        [Column("Fld_User_UserName")]
        public string UserName { get; set; }


        [Column("Fld_User_Email")]
        public string Email { get; set; }


        [Column("Fld_User_Password")]
        public string Password { get; set; }
    }
}
