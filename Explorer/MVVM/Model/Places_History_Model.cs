using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.MVVM.Model
{
    public class Places_History_Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> imageSource { get; set; }
        public Uri MapLocation { get; set; }


    }
}
