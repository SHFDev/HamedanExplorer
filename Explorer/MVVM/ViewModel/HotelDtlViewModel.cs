using CommunityToolkit.Maui.Core.Extensions;
using Explorer.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Explorer.MVVM.ViewModel
{
    public class HotelDtlViewModel
    {
        public ObservableCollection<CommHotel_Model> Reviews { get; } = new ObservableCollection<CommHotel_Model>();
        public Hotel_Model resturant { get; set; }

        public HotelDtlViewModel(Hotel_Model resturant_Model)
        {
            // افزودن نمونه نظرات به لیست

            Reviews.Add(new CommHotel_Model {ID=1, UserNames = "قاسم", Comment = "هتل تمیزی  بود ", Rating = 4, Star = "⭐⭐⭐⭐" , Restorantname ="هتل بوعلی همدان"});
            Reviews.Add(new CommHotel_Model { ID = 1, UserNames = "اکبر", Comment = "خیلی عالی بود ❤❤ ", Rating = 5, Star = "⭐⭐⭐⭐⭐", Restorantname = "هتل بوعلی همدان" });
            Reviews.Add(new CommHotel_Model { ID = 1, UserNames = "محمد", Comment = "سرد بود 😡😡😡", Rating = 1, Star = "⭐",Restorantname ="رستوران "});
            resturant = resturant_Model;
            Reviews = Reviews.Where(x=>x.Restorantname == resturant_Model.Name).ToObservableCollection();
            // ...
        }

    }
}
