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

            Restaurants.Add(new Hotel_Model { Name = "هتل بوعلی همدان", Rating = 4.5, Star = "⭐⭐⭐⭐" });
            Restaurants.Add(new Hotel_Model { Name = "هتل بین المللی امیران همدان", Rating = 3.8, Star = "⭐⭐⭐⭐" });
            Restaurants.Add(new Hotel_Model { Name = "هتل پارسیان همدان", Rating = 3.8, Star = "⭐⭐⭐⭐" });
            Restaurants.Add(new Hotel_Model { Name = "هتل کتیبه همدان", Rating = 3.8, Star = "⭐⭐⭐⭐" });
            Restaurants.Add(new Hotel_Model { Name = "هتل باباطاهر همدان", Rating = 3.8, Star = "⭐⭐⭐⭐⭐" });
        }
        public ICommand Res => new Command((p) =>
        {
            var Data = (Hotel_Model)p;
            var navigation = Application.Current.MainPage.Navigation;
            //navigation.PushAsync(new HotelView(Data));
        });
    }
}
