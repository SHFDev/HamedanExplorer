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
    public class ReviewsViewModel
    {
        public ObservableCollection<Review_Model> Reviews { get; } = new ObservableCollection<Review_Model>();
        public Resturant_Model resturant { get; set; }
        public ReviewsViewModel(Resturant_Model resturant_Model)
        {
            // افزودن نمونه نظرات به لیست

            Reviews.Add(new Review_Model { UserNames = "علی", Comment = "معمولی بود ", Rating = 4, Star = "⭐⭐⭐⭐" ,Restorantname="رستوران عمارت"});
            Reviews.Add(new Review_Model { UserNames = "نادر", Comment = "خیلی عالی بود ❤❤ ", Rating = 5, Star = "⭐⭐⭐⭐⭐", Restorantname = "سفره سرای آریاییان " });
            Reviews.Add(new Review_Model { UserNames = "کاظم", Comment = "سرد بود 😡😡😡", Rating = 1, Star = "⭐",Restorantname = "رستوران عمارت" });
            Reviews = Reviews.Where(x => x.Restorantname == resturant_Model.Name).ToObservableCollection();
            resturant = resturant_Model;
            // ...
        }

    }
}
