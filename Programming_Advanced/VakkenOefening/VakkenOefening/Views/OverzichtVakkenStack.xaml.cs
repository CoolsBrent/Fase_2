namespace VakkenOefening.Views;

public partial class OverzichtVakkenStack : ContentPage
{
    public OverzichtVakkenStack()
    {
        InitializeComponent();
    }

    private void FfClicked(object sender, EventArgs e)
    {
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        string idVak = (sender as ImageButton).AutomationId;
        if (idVak != "0")
        {
            switch (idVak)
            {
                case "1":
                    Navigation.PushAsync(new ProgrammingAdvanced());

                    break;

                case "2":
                    Navigation.PushAsync(new FrontendFrameworks());

                    break;

                case "3":
                    Navigation.PushAsync(new ItProfessional2());

                    break;

                case "4":
                    Navigation.PushAsync(new InteractieveWebsites());

                    break;

                case "5":
                    Navigation.PushAsync(new StatischeWebsites());

                    break;
            }
        }
    }

    private void Ip2Clicked(object sender, EventArgs e)
    {
    }

    private void IwClicked(object sender, EventArgs e)
    {
    }

    private void PaClicked(object sender, EventArgs e)
    {
    }

    private void SwClicked(object sender, EventArgs e)
    {
    }
}