using Explorer.MVVM.ViewModel;
using System.Windows.Input;

namespace Explorer.MVVM.View;

public partial class HotelView : TabbedPage
{
    public HotelView()
    {
        InitializeComponent();
        BindingContext = new ResturantViewModel();
    }

}