﻿using Explorer.MVVM.Model;
using Explorer.MVVM.Sql.Modle;
using Explorer.MVVM.ViewModel;

namespace Explorer.MVVM.View;

public partial class RoomDetail_View : ContentPage
{
    public RoomDetail_View(Hotel_Model resturant_Model)//این هاا یاد درست شه
    {
        InitializeComponent();
        BindingContext = new HotelDtlViewModel(resturant_Model);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (btnliked.Text == "❤")
        {
            btnliked.Text = "🤍";
        }
        else
        {
            btnliked.Text = "❤";
        }
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

        var img = imgbookmark.Source.ToString().Replace("File:", "").TrimStart();
        if (img == "save.svg")
        {
            imgbookmark.Source = "bookmark.svg";
        }
        else
        {
            var Bookmark = new ResturantBookmark()
            {
                Id = 1,
                ResturantID = 1,
                ResturantName = "name",
                UserId = 1,
            };
            App.BookMarked.Add(Bookmark);
            imgbookmark.Source = "save.svg";
        }

    }

    private void imgbookmark_Clicked(object sender, EventArgs e)
    {

    }

    private void ShowMaplocation_Btn(object sender, EventArgs e)
    {
        var mapUrl = new Uri("https://neshan.org/maps/@34.791029,48.496008,14.2z,0p/places/600b924f7e4def6aa30d402ae20e3698");//باید اطلاعات از model رستوران ها ادرس را بخواند string ذخیره شود در مودل
        Navigation.PushAsync(new MapView(mapUrl));
    }
}