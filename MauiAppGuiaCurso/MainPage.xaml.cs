namespace MauiAppGuiaCurso
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Exemplo de lista de cursos
            var courses = new List<Course>
        {
            new Course { CourseName = "Programação", Description = "Aprenda lógica e sintaxe de programação." },
            new Course { CourseName = "Banco de Dados", Description = "Entenda conceitos de banco de dados relacionais." },
            new Course { CourseName = "Desenvolvimento Web", Description = "Criação de sites e aplicativos web." }
        };

            CoursesList.ItemsSource = courses;
        }

        private async void OnCourseSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedCourse = (Course)e.SelectedItem;
            if (selectedCourse != null)
            {
                // Navegar para a página de detalhes do curso
                await Navigation.PushAsync(new CourseDetailPage(selectedCourse));
            }
        }
    }

    public class Course
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
    }

}
