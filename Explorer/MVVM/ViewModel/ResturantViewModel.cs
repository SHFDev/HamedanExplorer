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

            Restaurants.Add(new Resturant_Model { Name = "رستوران عمارت", Rating = 4.5 });
            Restaurants.Add(new Resturant_Model { Name = "باغ رستوران نعل اشکنه", Rating = 3.8 });
            Restaurants.Add(new Resturant_Model { Name = "فست فود عطاویچ (شعبه همدان)", Rating = 3.8 });
            Restaurants.Add(new Resturant_Model { Name = "سفره سرای آریاییان", Rating = 3.8 });
            Restaurants.Add(new Resturant_Model { Name = "فست فود رضا آقاجون", Rating = 3.8 });
        }
        public ICommand Res => new Command((p) =>
        {
            var Data = (Resturant_Model)p;
            var navigation = Application.Current.MainPage.Navigation;
            navigation.PushAsync(new FoodDetail_View(Data));
        });
    }
}
