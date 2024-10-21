namespace MauiAppGuiaCurso;

public partial class DisciplinasPage : ContentPage
{
    public DisciplinasPage()
    {
        InitializeComponent();
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
