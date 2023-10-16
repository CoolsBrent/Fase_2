using static Microsoft.Maui.Controls.Internals.Profile;

namespace VakkenOefening.Views;

public partial class ProgrammingAdvanced : ContentPage
{
    public ProgrammingAdvanced()
    {
        InitializeComponent();
    }

    private async void BtnOpslaan_Clicked(object sender, EventArgs e)
    {
        string infoString = string.Empty;

        infoString += "Voornaam: " + VoornaamEntry.Text;
        infoString += ", Naam: " + NaamEntry.Text;
        infoString += ", Locatie: " + Campuslocatie.Text;
        infoString += ", Vast lokaal: " + IsVastLokaal.IsChecked.ToString();
        infoString += ", Lokaalnummer: " + LokaalNummer.Text;
        infoString += ", Datum eerste les: " + DatumEersteLes.Date.ToShortDateString();
        infoString += ", Score: " + ScoreStep.Value.ToString() + "/20";

        await DisplayAlert("Info", infoString, "Terug aub");
    }

    private void ScoreStep_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        ScoreWaarde.Text = e.NewValue.ToString() + "/20";
    }
}