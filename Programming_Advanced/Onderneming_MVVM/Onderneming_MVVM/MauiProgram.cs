using Onderneming_MVVM.Data;
using Onderneming_MVVM.ViewModels;
using Onderneming_MVVM.Views;

namespace Onderneming_MVVM;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        builder.Services.AddSingleton<MainPageViewModel>();

        builder.Services.AddSingleton<WerknemerRepository>();

        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
    }
}