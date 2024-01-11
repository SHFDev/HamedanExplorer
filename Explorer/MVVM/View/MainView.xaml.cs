using Explorer.MVVM.Views;

namespace Explorer.MVVM.View;

public partial class MainView : ContentPage
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Explorer_Btn(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Main_PlacesHistory_View());
    }

    private void Button_Clicked_Culture_notablesView(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Culture_notablesView());
    }

    private void Button_Clicked_Weather(object sender, EventArgs e)
    {
<<<<<<< HEAD
        Navigation.PushAsync(new WeatherView());
=======
     //   Navigation.PushAsync(new WeatherView());
>>>>>>> 9eb559b01b99df7e86d340eae799ebddd38abec1
    }

    private void Button_Clicked_Foods(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ResturantView());
    }

    private void Button_Clicked_Hotel(object sender, EventArgs e)
    {

    }
}