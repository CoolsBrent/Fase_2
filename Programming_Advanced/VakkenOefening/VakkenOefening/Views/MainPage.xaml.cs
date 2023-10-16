using VakkenOefening.Views;

namespace VakkenOefening;

public partial class MainPage : ContentPage
{
    //private int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OverzichtVakkenFlex_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new OverzichtVakkenFlex());
    }

    private void OverzichtVakkenGrid_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new OverzichtVakkenGrid());
    }

    private void OverzichtVakkenStack_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new OverzichtVakkenStack());
    }

    /*private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}*/
}