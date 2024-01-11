using Explorer.MVVM.Model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class PlacesHistoryViewModel
    {
        public List<Places_History_Model> History { get; set; } = new List<Places_History_Model>();
        public PlacesHistoryViewModel()
        {
            Places_History_Model history_Model = new Places_History_Model()
            {
                Id = 1,
                Name = "آرامگاه بوعلی سینا",
                Description = "\r\nزندگی و دستاوردها: ابوعلی حسین بن عبدالله بن سینا، معروف به بوعلی سینا و در غرب به ابن سینا، یکی از مشهورترین و تاثیرگذارترین فیلسوفان و دانشمندان دوران اسلامی است. او در حوزه‌های مختلفی چون پزشکی، فلسفه، ریاضیات و نجوم دستاوردهای مهمی داشته است.\r\nکتاب‌ها و آثار: از مهم‌ترین آثار او می‌توان به \"القانون فی الطب\" (قانون در طب) و \"کتاب الشفاء\" (کتاب شفا) اشاره کرد که در زمینه‌های پزشکی و فلسفه تأثیرات عمده‌ای داشته‌اند.",
                imageSource = new List<string>()
                {
                    "dotnet_bot.jpg", "mainpic.jpg", "mainpic.jpg",
                },
                MapLocation = new Uri("https://neshan.org/maps/@34.791511,48.51393,17.2z,0p/places/75d0dbb1fa8d831d3c6f9f8b36354482"),
            };
            
            History.Add(history_Model);
            Places_History_Model history_Model1 = new Places_History_Model()
            {
                Id = 1,
                Name = "Test2",
                Description = "test des2"
            };
            History.Add(history_Model1);
            Places_History_Model history_Model2 = new Places_History_Model()
            {
                Id = 1,
                Name = "Test3",
                Description = "test des3"
            };
            Places_History_Model history_Model3 = new Places_History_Model()
            {
                Id = 1,
                Name = "Test4",
                Description = "test des4",
                imageSource = new List<string>()
                {
                    "mainpic.jpg", "mainpic.jpg",  "mainpic.jpg",
                },
                MapLocation = new Uri("https://neshan.org/maps/@34.798402,48.515585,17.3z,0p/places/f4bf373cc75e64458ba760aa08420102"),

            };
            Places_History_Model history_Model4 = new Places_History_Model()
            {
                Id = 1,
                Name = "Test5",
                Description = "test des5"
            };
            History.Add(history_Model2);
            History.Add(history_Model3);
            History.Add(history_Model4);
        }
    }
}
