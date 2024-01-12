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

        public ReviewsViewModel(Resturant_Model resturant_Model)
        {
            // افزودن نمونه نظرات به لیست

            Reviews.Add(new Review_Model { UserNames = "علی", Comment = "معمولی بود ", Rating = 4, Star = "⭐⭐⭐⭐" });
            Reviews.Add(new Review_Model { UserNames = "نادر", Comment = "خیلی عالی بود ❤❤ ", Rating = 5, Star = "⭐⭐⭐⭐⭐" });
            Reviews.Add(new Review_Model { UserNames = "کاظم", Comment = "سرد بود 😡😡😡", Rating = 1, Star = "⭐" });
            // ...
        }

    }
}
