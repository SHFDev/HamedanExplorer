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


            Reviews.Add(new Review_Model { UserNames = resturant_Model.Name, Comment = "نظر اول", Rating = 4.5 });
            Reviews.Add(new Review_Model { UserNames = "کاربر2", Comment = "نظر دوم", Rating = 3.8 });
            // ...
        }

    }
}
