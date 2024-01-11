using Explorer.MVVM.Model;
using Explorer.MVVM.ViewModel;
using System.Runtime.CompilerServices;

namespace Explorer.MVVM.View;

public partial class Main_PlacesHistory_View : ContentPage
{
    public Main_PlacesHistory_View()
    {
        InitializeComponent();
        BindingContext = new PlacesHistoryViewModel();
    }
    protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        base.OnPropertyChanged(propertyName);
        //History_SelectionChanged();
        //if (History_CollectionView.SelectedItem != null)
        //{
        //}
    }
    
    private void History_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //History_CollectionView.SelectedItem = null;
        var data = (Places_History_Model)History_CollectionView.SelectedItem;
        Description.Text = data.Description;
        Title.Text = data.Name;
        ImageSource.ItemsSource = data.imageSource;
        DetailsSheet.OpenSheet();
    }  
    
    private void Religious_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //History_CollectionView.SelectedItem = null;
        var data = (Places_History_Model)Religious_CollectionView.SelectedItem;
        Description.Text = data.Description;
        Title.Text = data.Name;
        ImageSource.ItemsSource = data.imageSource;
        DetailsSheet.OpenSheet();
    }  
    
    private void Explorer_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //History_CollectionView.SelectedItem = null;
        var data = (Places_History_Model)Explorer_CollectionView.SelectedItem;
        Description.Text = data.Description;
        Title.Text = data.Name;
        ImageSource.ItemsSource = data.imageSource;
        DetailsSheet.OpenSheet();
    }

    private void Show_Location_Map(object sender, EventArgs e)
    {
        DetailsSheet.CloseSheet();
        var mapUrl = new Uri("https://neshan.org/maps/@34.791536,48.51061,14.4z,0p/places/67d1e806591de693e0b965270cd60d8c");
        Navigation.PushAsync(new MapView(mapUrl));
        //History_CollectionView.SelectedItem = null;
    }

   
}