using Explorer.MVVM.ViewModel;
using System.Windows.Input;

namespace Explorer.MVVM.View;

public partial class ResturantView : TabbedPage
{
    public ResturantView()
    {
        InitializeComponent();
        BindingContext = new ResturantViewModel();
    }


}