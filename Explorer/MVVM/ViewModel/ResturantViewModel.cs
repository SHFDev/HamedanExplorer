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
    public class ResturantViewModel
    {
        public ObservableCollection<Resturant_Model> Restaurants { get; } = new ObservableCollection<Resturant_Model>();

        public ResturantViewModel()
        {
            // افزودن رستوران‌ها به لیست

            Restaurants.Add(new Resturant_Model { Name = "رستوران عمارت", Rating = 4.5, Star = "⭐⭐⭐⭐",about= "این رستوران در زمان  های خیلی قدیم درست شد است خیلی خیلی قدیماین رستوران در زمان  های خیلی قدیم درست شد است خیلی خیلی قدیماین رستوران در زمان  های خیلی قدیم درست شد است خیلی خیلی قدیماین رستوران در زمان  های خیلی قدیم درست شد است خیلی خیلی قدیماین رستوران در زمان  های خیلی قدیم درست شد است خیلی خیلی قدیماین رستوران در زمان  های خیلی قدیم درست شد است خیلی خیلی قدیم ",Address="همدان خیابان مهدیه رو به روی عطا ویج" ,maploc= "https://neshan.org/maps/@34.790075,48.494531,18.1z,0p/places/600b924f7e4def6aa30d402ae20e3698" ,profimage="boali.png", titelimage="test.png"});
            Restaurants.Add(new Resturant_Model { Name = "باغ رستوران نعل اشکنه", Rating = 3.8, Star = "⭐⭐⭐⭐" });
            Restaurants.Add(new Resturant_Model { Name = "فست فود عطاویچ", Rating = 3.8, Star = "⭐⭐⭐⭐" });
            Restaurants.Add(new Resturant_Model { Name = "سفره سرای آریاییان", Rating = 3.8, Star = "⭐⭐⭐⭐⭐", Offering = 30, HasOffer = true });
            Restaurants.Add(new Resturant_Model { Name = "فست فود رضا آقاجون", Rating = 3.8, Star = "⭐⭐⭐", Offering = 10, HasOffer = true });
        }
        public ICommand Res => new Command((p) =>
        {
            var Data = (Resturant_Model)p;
            var navigation = Application.Current.MainPage.Navigation;
            navigation.PushAsync(new FoodDetail_View(Data));

        });
    }
}
