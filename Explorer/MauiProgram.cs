using CommunityToolkit.Maui;
using Explorer.MVVM.Sql.Repository;

namespace Explorer;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit();
        builder.Services.AddSingleton<LikedRepos>();
        builder.Services.AddSingleton<BookMarkedRepos>();
        builder.Services.AddSingleton<UserRepo>();
        builder.Services.AddSingleton<ReviewRepo>();
        return builder.Build();
    }
}
