using Explorer.MVVM.Model;
using Explorer.MVVM.Sql.Modle;
using Explorer.MVVM.ViewModel;

namespace Explorer.MVVM.View;

public partial class FoodDetail_View : ContentPage
{
    private Resturant_Model _resturant;
    public FoodDetail_View(Resturant_Model resturant_Model)
    {
        InitializeComponent();
        BindingContext = new ReviewsViewModel(resturant_Model);
        _resturant = resturant_Model;
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
            var liked = new LikedModel()
            {
                Id = 1,
                ResturantID = 1,
                ResturantName = _resturant.Name,
                UserID = 1,

            };
            App.Liked.Add(liked);
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
        var mapUrl = new Uri($"{_resturant.maploc}");
        Navigation.PushAsync(new MapView(mapUrl));
    }
}