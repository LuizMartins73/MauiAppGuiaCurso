namespace MauiAppGuiaCurso;

public partial class SobreOCursoPage : ContentPage
{
    public SobreOCursoPage()
    {
        InitializeComponent();
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
