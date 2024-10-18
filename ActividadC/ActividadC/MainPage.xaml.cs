namespace ActividadC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        private async void OnOpenWebsiteButtonClicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.youtube.com/");
            await Launcher.Default.OpenAsync(uri);
        }

    }

}
