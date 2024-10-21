namespace MauiAppGuiaCurso;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // Navegação para as páginas
    private async void OnSobreOCursoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobreOCursoPage());
    }

    private async void OnDisciplinasClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DisciplinasPage());
    }

    private async void OnProjetosClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProjetosPage());
    }

    private async void OnMercadoTrabalhoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MercadoTrabalhoPage());
    }

    private async void OnFaleConoscoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FaleConoscoPage());
    }
}
