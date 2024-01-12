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

            Restaurants.Add(new Hotel_Model { Name = "هتل بوعلی همدان", Rating = 4.5, Star = "⭐⭐⭐⭐" ,about="این هتل در تاریخ 1368 شمسی درست شده است",maploc= "https://neshan.org/maps/@34.784728,48.514918,15.9z,0p/places/9b0e28b66a4cd42738ef3467f924669b" ,profimage= "hboalititle.png", titelimage="hotelboali.png"});
            Restaurants.Add(new Hotel_Model { Name = "هتل بین المللی امیران همدان", Rating = 3.9, Star = "⭐⭐⭐⭐" });
            Restaurants.Add(new Hotel_Model { Name = "هتل پارسیان همدان", Rating = 3.8, Star = "⭐⭐⭐⭐" });
            Restaurants.Add(new Hotel_Model { Name = "هتل کتیبه همدان", Rating = 3.8, Star = "⭐⭐⭐⭐" });
            Restaurants.Add(new Hotel_Model { Name = "هتل باباطاهر همدان", Rating = 4.8, Star = "⭐⭐⭐⭐⭐", });
        }
        public ICommand Res => new Command((p) =>
        {
            var Data = (Hotel_Model)p;
            var navigation = Application.Current.MainPage.Navigation;
            navigation.PushAsync(new RoomDetail_View(Data));
        });
    }
}
