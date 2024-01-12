using Explorer.MVVM.Model;
using Explorer.MVVM.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Explorer.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class HotelViewModel
    {
        public ObservableCollection<Hotel_Model> Restaurants { get; } = new ObservableCollection<Hotel_Model>();

        public HotelViewModel()
        {
            // افزودن رستوران‌ها به لیست

            Restaurants.Add(new Hotel_Model { Name = "هتل بوعلی همدان", Address = "همدان ، میدان جهاد ", Rating = 4.5, Star = "⭐⭐⭐⭐", about = "این هتل در تاریخ 1368 شمسی درست شده است", maploc = "https://neshan.org/maps/@34.784728,48.514918,15.9z,0p/places/9b0e28b66a4cd42738ef3467f924669b", profimage = "logoboali.png", titelimage = "h_boali.png" });
            Restaurants.Add(new Hotel_Model { Name = "هتل بین المللی امیران همدان", Rating = 3.9, Star = "⭐⭐⭐⭐", Address = "همدان پایین تر از پل فرهنگیان", about="هتل امیران در همدان یکی از بهترین هاب عهای بین المللی میباشد " ,HasOffer=true , Offering=10 ,maploc= "https://neshan.org/maps/@34.829923,48.525922,14.4z,0p/places/7826dd6cdb0bb2907725a7bca78eb810",profimage= "amiranlogo.png",titelimage= "amiran.jpeg" });
            Restaurants.Add(new Hotel_Model { Name = "هتل پارسیان همدان", Rating = 3.8, Star = "⭐⭐⭐⭐",maploc= "https://neshan.org/maps/@34.781109,48.491191,14.5z,0p/places/44df30cb83f915e3518093c14c706f53",about="هتل پارسیان یکی از با سابفه ترین هتل ها در ایران و حتی همدان است",Address="همدان بلوار ، رو یه روی شهر بازی رنگین کمان" ,HasOffer=false ,profimage= "parsianlogo.png" , });
            Restaurants.Add(new Hotel_Model { Name = "هتل کتیبه همدان", Rating = 3.8, Star = "⭐⭐⭐⭐", Offering = 20, HasOffer = true, maploc = "https://neshan.org/maps/@34.782656,48.485001,17.9z,0p/places/209c0d5f31d79a6fd3629509946ed574", about = " هتل کتیبه  یکی از شکیل ترین هتل ها یهمکدان محصوب می شود", Address = "همدان ، بلوار روبه روی بیمارستان بهشتی", profimage = "katibelogo.png", titelimage = "katibe.jpg" });
            Restaurants.Add(new Hotel_Model { Name = "هتل باباطاهر همدان", Rating = 4.8, Star = "⭐⭐⭐⭐⭐", Offering = 13, HasOffer = true ,maploc= "https://neshan.org/maps/@34.810453,48.511412,17.2z,0p/places/0fa02e944cfa6c6d2e660d361662250d" ,about="یکی از بهترین هتل های پنج ستاره همدان هتل باباطاهر است" ,Address="همدان ، دور میدان باباطاهر" ,profimage= "babtaher.jpg",titelimage= "babtaher_img.png" });
        }
        public ICommand Res => new Command((p) =>
        {
            var Data = (Hotel_Model)p;
            var navigation = Application.Current.MainPage.Navigation;
            navigation.PushAsync(new RoomDetail_View(Data));
        });
    }
}
