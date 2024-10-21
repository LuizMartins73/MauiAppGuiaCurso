namespace MauiAppGuiaCurso;

public partial class ProjetosPage : ContentPage
{
    public ProjetosPage()
    {
        InitializeComponent();
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
