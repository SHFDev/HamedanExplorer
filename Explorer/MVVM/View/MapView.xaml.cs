namespace Explorer.MVVM.View;

public partial class MapView : ContentPage
{
	public MapView(Uri LocationAddress)
	{
		InitializeComponent();
        MapLocation.Source = LocationAddress;
    }
}