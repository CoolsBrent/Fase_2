using Les1Voorbeeld.Views;

namespace Les1Voorbeeld;

public partial class MainPage : ContentPage
{
    private int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void Voorbeeld1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Voorbeeld1());
    }

    private void Voorbeeld2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Voorbeeld2());
    }

    private void Voorbeeld3_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Voorbeeld3());
    }
}