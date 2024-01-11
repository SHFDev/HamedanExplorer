using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.MVVM.Sql.Modle
{
    [Table("Tbl_Reviews")]
    public class ReviewsModel
    {
        [Column("Fld_Reviews_Id")]
        public int Id { get; set; }


        [Column("Fld_Reviews_UserName")]
        public string UserName { get; set; }


        [Column("Fld_Reviews_Rate")]
        public int Rate { get; set; }


        [Column("Fld_Reviews_Comment")]
        public string Comment { get; set; }
    }
}
