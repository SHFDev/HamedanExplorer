using Explorer.MVVM.Model;
using Explorer.MVVM.Sql.Modle;
using Explorer.MVVM.ViewModel;

namespace Explorer.MVVM.View;

public partial class RoomDetail_View : ContentPage
{
    private string MapLocation;
    public RoomDetail_View(Hotel_Model resturant_Model)//این هاا یاد درست شه
    {
        InitializeComponent();
        BindingContext = new HotelDtlViewModel(resturant_Model);
        MapLocation = resturant_Model.maploc;
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
        var mapUrl = new Uri($"{MapLocation}");//باید اطلاعات از model رستوران ها ادرس را بخواند string ذخیره شود در مودل
        Navigation.PushAsync(new MapView(mapUrl));
    }
}