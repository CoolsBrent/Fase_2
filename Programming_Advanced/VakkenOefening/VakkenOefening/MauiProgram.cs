using Models;
using VakkenOefening.ViewModels;
using VakkenOefening.Views;

namespace VakkenOefening;

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
                fonts.AddFont("TMCandor-BoldItalic.otf", "TitelFont");
                fonts.AddFont("TMCandor-ExtraLight.otf", "DetailFont");
            });

        builder.Services.AddSingleton<DocentRepository>();
        builder.Services.AddSingleton<VakRepository>();
        builder.Services.AddSingleton<OverzichtVakkenFlex>();
        builder.Services.AddSingleton<OverzichtVakkenGrid>();
        builder.Services.AddSingleton<OverzichtVakkenStack>();
        builder.Services.AddSingleton<OverzichtVakkenViewModel>();
        builder.Services.AddSingleton<ProgrammingAdvanced>();
        builder.Services.AddSingleton<VakRepository>();
        builder.Services.AddSingleton<FrontendFrameworks>();
        builder.Services.AddSingleton<ItProfessional2>();
        builder.Services.AddSingleton<InteractieveWebsites>();
        builder.Services.AddSingleton<StatischeWebsites>();

        return builder.Build();
    }
}