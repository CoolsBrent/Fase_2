using Onderneming_MVVM.ViewModels;
using Models;

namespace Onderneming_MVVM.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}