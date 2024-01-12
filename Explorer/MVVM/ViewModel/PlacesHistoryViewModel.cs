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
        public List<Places_History_Model> Religious { get; set; } = new List<Places_History_Model>();
        public List<Places_History_Model> Explorer { get; set; } = new List<Places_History_Model>();
        public PlacesHistoryViewModel()
        {
            Places_History_Model history_Model = new Places_History_Model()
            {
                Id = 1,
                Name = "آرامگاه بوعلی سینا",
                Description = "\r\nزندگی و دستاوردها: ابوعلی حسین بن عبدالله بن سینا، معروف به بوعلی سینا و در غرب به ابن سینا، یکی از مشهورترین و تاثیرگذارترین فیلسوفان و دانشمندان دوران اسلامی است. او در حوزه‌های مختلفی چون پزشکی، فلسفه، ریاضیات و نجوم دستاوردهای مهمی داشته است.\r\nکتاب‌ها و آثار: از مهم‌ترین آثار او می‌توان به \"القانون فی الطب\" (قانون در طب) و \"کتاب الشفاء\" (کتاب شفا) اشاره کرد که در زمینه‌های پزشکی و فلسفه تأثیرات عمده‌ای داشته‌اند.",
                imageSource = new List<string>()
                {
                    "bo_ali.jpg", "boali.jpg", 
                },
                TitleImageSource = "bo_ali.jpg",
                MapLocation = new Uri("https://neshan.org/maps/@34.791511,48.51393,17.2z,0p/places/75d0dbb1fa8d831d3c6f9f8b36354482"),
            };
            
            Places_History_Model history_Model1 = new Places_History_Model()
            {
                Id = 1,
                Name = "گنبد علویان",
                Description = "\r\nیکی از علامت‌های شهر همدان است و در مرکز شهر واقع شده است. این بنا به عنوان یک گنبد آرامگاهی معروف است و در داخل آن، چندین گنبد و سردر وجود دارد",
                TitleImageSource= "alavian.png",
                imageSource = new List<string>()
                {
                    "alavian.png",
                },
                MapLocation = new Uri("https://neshan.org/maps/@34.803809,48.51416,15z,0p/places/b3c437ee561a3029b80697ebf43d908a"),

            };
           
            Places_History_Model history_Model2 = new Places_History_Model()
            {
                Id = 1,
                Name = "گنج نامه",
                Description = "",
                TitleImageSource= "ganjname.png",
                
                 imageSource = new List<string>()
                {
                    "g1.jpg",  "g2.jpg",
                },
                MapLocation = new Uri("https://neshan.org/maps/@34.798402,48.515585,17.3z,0p/places/f4bf373cc75e64458ba760aa08420102"),

            };
          
            History.Add(history_Model);
            History.Add(history_Model1);
            History.Add(history_Model2);
           

            Places_History_Model Religious_Model = new Places_History_Model()
            {
                Id = 1,
                Name = "امازاده عبدالله",
                Description = "امامزاده عبدالله یکی از مشهورترین بقاع متبرکه در همدان است. این بنا متعلق به دوره سلجوقی است و دارای گنبدی زیبا و کاشی‌کاری‌های منحصربه‌فرد است",
                imageSource = new List<string>()
                {
                    "em1.png", "em.png", 
                },
                TitleImageSource = "em1.jpg",
                MapLocation = new Uri("https://neshan.org/maps/@34.802641,48.509378,16.3z,0p/places/32e98ce134daae5a6e806b9c4107d610"),
            };
            Places_History_Model Religious_Model4 = new Places_History_Model()
            {
                Id = 1,
                Name = "امامزاده یحیی",
                Description = "این امامزاده نیز از جمله مکان‌های مقدس و مورد احترام در همدان است که برای زائران و علاقه‌مندان به اماکن مذهبی اهمیت دارد",
                 imageSource = new List<string>()
                {
                    "eah1.jpg", "eah12.jpg", 
                },
                TitleImageSource = "eah1.jpg",
                MapLocation = new Uri("https://neshan.org/maps/@34.793174,48.520018,18.7z,0p/places/616797e8c31adb9692fe4441494d1c11"),
            };
            Religious.Add(Religious_Model);
            Religious.Add(Religious_Model4); 
            
           
            Places_History_Model Explorer_Model1 = new Places_History_Model()
            {

                Id = 1,
                Name = "پارک مردم همدان",
                Description = "\r\nاین پارک یکی از بزرگ‌ترین و زیباترین پارک‌های همدان است که فضایی دلپذیر برای پیاده‌روی، استراحت و تفریح خانوادگی فراهم می‌کند.",
                TitleImageSource="park1.png",
                 imageSource = new List<string>()
                {
                    "park1.jpg", "park2.jpg", "park3.jpg"
                },
                MapLocation = new Uri("https://neshan.org/maps/@34.802641,48.509239,16.5z,0p/places/32e98ce134daae5a6e806b9c4107d610"),
            };
            Places_History_Model Explorer_Model3 = new Places_History_Model()
            {
                Id = 1,
                Name = "کوه الوند",
                Description = "کوهستان الوند با مناظر طبیعی خیره‌کننده، مکانی عالی برای کوهنوردی، طبیعت‌گردی و تفریحات فضای باز است. این کوهستان فرصت‌های عالی برای عکاسی و لذت بردن از مناظر طبیعی فراهم می‌کند.",
                imageSource = new List<string>()
                {
                    "al1.png", "al2.png", "al3.png",
                },
                MapLocation = new Uri("https://neshan.org/maps/@34.798402,48.515585,17.3z,0p/places/f4bf373cc75e64458ba760aa08420102"),
                TitleImageSource = "al1.png",
            };

            Explorer.Add(Explorer_Model1);
            Explorer.Add(Explorer_Model3);
        }
    }
}
