using Explorer.MVVM.Sql.Repository;
using Explorer.MVVM.View;

namespace Explorer;

public partial class App : Application
{

    public static LikedRepos Liked { get; private set; }
    public static BookMarkedRepos BookMarked { get; private set; }
    public static ReviewRepo Review { get; private set; }
    public static UserRepo User { get; private set; }

    public App(LikedRepos Likeds, ReviewRepo reviewRepo, BookMarkedRepos bookMarkedRepos, UserRepo userRepo)
    {
        InitializeComponent();
        Liked = Likeds;
        BookMarked = bookMarkedRepos;
        User = userRepo;
        Review = reviewRepo;
        MainPage = new NavigationPage(new MainView());  
    }
}
